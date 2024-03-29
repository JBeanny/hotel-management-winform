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
    public partial class ReservationForm : Form
    {
        ReservationDetailForm reservationDetailForm = null;
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservationDetailForm = new ReservationDetailForm();
            reservationDetailForm.Show();
        }
    }
}
