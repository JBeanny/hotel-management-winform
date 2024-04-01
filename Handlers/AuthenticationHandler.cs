namespace HotelManagement
{
    public class AuthenticationHandler : ILoginHandler
    {
        private ILoginHandler _nextHandler;
        public void SetNextHandler(ILoginHandler handler)
        {
            _nextHandler = handler;
        }

        public bool HandleRequest(string username, string password)
        {
            // Here you can implement your actual authentication logic
            if (username == "admin" && password == "password")
            {
                return _nextHandler.HandleRequest(username, password);
            }

            MessageBox.Show("Invalid username or password.", "Failed to authenticate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
