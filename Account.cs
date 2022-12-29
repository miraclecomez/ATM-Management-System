using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Griya Dircomp\Documents\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button7_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "" || PinTb.Text == "") ;
            {
                MessageBox.Show("Mising Information");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + AddressTb.Text + "','" + PhoneTb.Text + "'," + PinTb.Text + ","+bal+")";
                    Sqlcomand cmd = new Sqlcomand(query,Con);
                    
                    MessageBox.Show("Account Created Succesfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
