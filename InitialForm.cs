
namespace HotelManagement
{
    public partial class InitialForm : Form
    {
        private MainApplication app = null;
        private ILoginHandler _loginHandler;

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

        public void loginClick(object sender, EventArgs e)
        {
            var DbContext = DatabaseConfig.GetInstance();

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
            this.Hide();
            app = new MainApplication();
            app.Show();
        }
    }
}