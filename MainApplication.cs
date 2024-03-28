using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainApplication : Form
    {
        private RoomForm roomForm;

        public MainApplication()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm();
            roomForm.Show();
        }
    }
}
