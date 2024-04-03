
using HotelManagement.Models;
using System.Runtime.CompilerServices;

namespace HotelManagement
{
    public partial class InitialForm : Form
    {
        private MainApplication app = null;
        private ILoginHandler _loginHandler;
        private IStrategy<User> UserStrategy = new UserStrategy();

        public InitialForm()
        {
            InitializeComponent();

            // Setting up the chain of responsibility
            _loginHandler = new UsernameHandler();
            var passwordHandler = new PasswordHandler();
            var authenticationHandler = new AuthenticationHandler();
            var authorizationHandler = new AuthorizationHandler();

            _loginHandler.SetNextHandler(passwordHandler);
            passwordHandler.SetNextHandler(authenticationHandler);
            authenticationHandler.SetNextHandler(authorizationHandler);
        }

        public void showForm()
        {
            this.Show();
        }

        public void loginClick(object sender, EventArgs e)
        {
            // credentials
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            Boolean isAuthenticated = _loginHandler.HandleRequest(username, password);

            if (isAuthenticated)
            {
                this.Hide();
                app = new MainApplication();
                app.Show();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // credentials
            string id = Utils.generateRandomId(5, "User");
            string username = usernameInput.Text.ToLower();
            string password = passwordInput.Text;

            string encryptedPassword = Utils.hashPassword(password);

            User user = new User(id, username, encryptedPassword);

            UserStrategy.Insert(user);

            bool isAuthorized = new AuthorizationHandler().HandleRequest(username, password);

            if (isAuthorized)
            {
                this.Hide();
                app = new MainApplication();
                app.Show();
            }
        }

        private void handleEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void InitialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}