using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WatchCustomer WC = new WatchCustomer();
            WC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WatchEmployee WE = new WatchEmployee();
            WE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WatchCalendar WCa = new WatchCalendar();
            WCa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WatchCar WCr = new WatchCar();
            WCr.Show();
        }

    }
}
