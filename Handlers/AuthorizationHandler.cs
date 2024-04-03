
namespace HotelManagement
{
    public class AuthorizationHandler : ILoginHandler
    {
        private List<String> admins = new List<String>((new string[] { "admin", "tharoth", "chakriya","bormey","hourmeng" }));
        public void SetNextHandler(ILoginHandler handler)
        {
            // skip this because it is the end of the chain of responsibility
        }

        public bool HandleRequest(string username, string password)
        {
            // Here you can implement your actual authentication logic
            if (isAuthorizedUser(username))
            {
                return true;
            }

            MessageBox.Show("You are not authorized to our application.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool isAuthorizedUser(string username)
        {
            foreach(String user in admins)
            {
                if (user == username)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
