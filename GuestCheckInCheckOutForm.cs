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
    public partial class GuestCheckInCheckOutForm : Form
    {
        public GuestCheckInCheckOutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.status.Text == "CHECK-IN")
            {
                this.status.Text = "CHECK-OUT";
            } else
            {
                this.status.Text = "CHECK-IN";
            }
        }
    }
}
