using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        public static string AccNumber;
        private void Home_Load_1(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Changepin Pin = new Changepin();
            Pin.Show();
            this.Hide();    
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }
    }
}
