namespace HotelManagement
{
    public partial class InitialForm : Form
    {
        private MainApplication app = null;

        public InitialForm()
        {
            InitializeComponent();
        }

        public void loginClick(object sender, EventArgs e)
        {
            var DbContext = DatabaseConfig.GetInstance();

            this.Hide();
            app = new MainApplication();
            app.Show();
        }
    }
}