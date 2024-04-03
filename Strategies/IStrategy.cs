namespace HotelManagement
{
    public interface IStrategy<T>
    {
        void Insert(T Data);
        List<T> Read();
        T ReadById(string Id);
        void Delete(string Id);
        void Update(string Id, T Data);
    }
}