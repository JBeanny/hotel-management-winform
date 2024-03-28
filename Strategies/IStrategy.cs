namespace HotelManagement
{
    public interface IStrategy<T>
    {
        void Insert(T Data);
        List<T> Read();
        T ReadById(int Id);
        void Delete(int Id);
        void Update(int Id, T Data);
    }
}