namespace SampleApp.BackendAPI.Services
{
    public interface ICrud<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Insert(T obj);
        T Update(int id, T obj);
        void Delete(int id);
    }
}
