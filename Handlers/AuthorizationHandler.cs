
namespace HotelManagement
{
    public class AuthorizationHandler : ILoginHandler
    {
        public void SetNextHandler(ILoginHandler handler)
        {
            // skip this because it is the end of the chain of responsibility
        }

        public bool HandleRequest(string username, string password)
        {
            // Here you can implement your actual authentication logic
            if (username == "admin")
            {
                return true;
            }

            MessageBox.Show("Invalid username or password.", "Failed to authenticate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
