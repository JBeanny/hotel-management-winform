namespace HotelManagement
{
    public interface ILoginHandler
    {
        void SetNextHandler(ILoginHandler handler);
        bool HandleRequest(string username, string password);
    }
}
