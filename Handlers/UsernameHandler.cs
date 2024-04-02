namespace HotelManagement
{
    public class UsernameHandler : ILoginHandler
    {
        private ILoginHandler _nextHandler;

        public void SetNextHandler(ILoginHandler handler)
        {
            _nextHandler = handler;
        }

        public bool HandleRequest(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Bad Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Pass the request to the next handler
            if (_nextHandler != null)
                return _nextHandler.HandleRequest(username, password);

            return true; // Reached end of the chain
        }
    }
}
