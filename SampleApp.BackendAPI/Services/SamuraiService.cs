using SampleApp.BackendAPI.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace SampleApp.BackendAPI.Services
{
    public class SamuraiService : ISamurai
    {
        private readonly IConfiguration _config;
        public SamuraiService(IConfiguration config)
        {
            _config = config;
        }

        private string GetConn()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConn()))
            {
                string strSql = @"delete from Samurais where Id=@Id";
                var param = new { Id = id };
                try
                {
                    conn.Execute(strSql,param);
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception(sqlEx.Message);
                }
            }
        }

        public IEnumerable<Samurai> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConn()))
            {
                string strSql = @"select * from Samurais 
                                  order by Name";
                var results = conn.Query<Samurai>(strSql);
                return results;
            }
        }

        /*public IEnumerable<Samurai> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(GetConn()))
            {
                List<Samurai> lstSamurai = new List<Samurai>();
                string strSql = @"select * from Samurais order by Name";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        lstSamurai.Add(new Samurai()
                        {
                           Id = Convert.ToInt32(reader["Id"]),
                           Name = reader["Name"].ToString()
                        });
                    }
                }
                reader.Close();
                cmd.Dispose();
                conn.Close();

                return lstSamurai;
            }
        }*/

        public Samurai GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConn()))
            {
                string strSql = @"select * from Samurais where Id=@Id";
                var param = new { Id = id };
                var result = conn.QueryFirstOrDefault<Samurai>(strSql,param);
                if (result == null)
                    throw new Exception($"Data samurai {id} tidak ditemukan");
                return result;
            }
        }

        public IEnumerable<Samurai> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Samurai Insert(Samurai obj)
        {
            using (SqlConnection conn = new SqlConnection(GetConn()))
            {
                string strSql = @"insert into Samurais(Name) values(@Name);select * from Samurais where Id=@@identity";
                var param = new { Name = obj.Name };
                try
                {
                    var newSamurai = conn.QueryFirstOrDefault<Samurai>(strSql, param);
                    return newSamurai;
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"{sqlEx.Message}");
                }
            }
        }

        public Samurai Update(int id, Samurai obj)
        {
            using (SqlConnection conn = new SqlConnection(GetConn()))
            {
                string strSql = @"update Samurais set Name=@Name where Id=@Id";
                var param = new { Id = id, Name = obj.Name };
                try
                {
                    conn.Execute(strSql, param);
                    var samuraiUpdate = GetById(id);
                    return samuraiUpdate;
                }
                catch (SqlException sqlEX)
                {
                    throw new Exception(sqlEX.Message);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
