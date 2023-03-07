using SampleApp.BackendAPI.Models;
using Microsoft.Data.SqlClient;

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
            throw new NotImplementedException();
        }

        public IEnumerable<Samurai> GetAll()
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
        }

        public Samurai GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Samurai> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Samurai Insert(Samurai obj)
        {
            throw new NotImplementedException();
        }

        public Samurai Update(int id, Samurai obj)
        {
            throw new NotImplementedException();
        }
    }
}
