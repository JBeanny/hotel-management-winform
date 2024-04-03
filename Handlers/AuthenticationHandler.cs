using HotelManagement.Models;

namespace HotelManagement
{
    public class AuthenticationHandler : ILoginHandler
    {
        private ILoginHandler _nextHandler;
        private IStrategy<User> UserStrategy = new UserStrategy();
        public void SetNextHandler(ILoginHandler handler)
        {
            _nextHandler = handler;
        }

        public bool HandleRequest(string username, string password)
        {
            User user = UserStrategy.ReadById(username);

            if(user == null)
            {
                MessageBox.Show("Invalid username or password.", "Failed to authenticate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Here you can implement your actual authentication logic
            if (user.password == Utils.hashPassword(password))
            {
                return _nextHandler.HandleRequest(username, password);
            }

            MessageBox.Show("Invalid username or password.", "Failed to authenticate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
