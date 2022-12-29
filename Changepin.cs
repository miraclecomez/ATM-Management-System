using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM
{
    public partial class Changepin : Form
    {
        public Changepin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Changepin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Griya Dircomp\Documents\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void button7_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "") ;
            {
                MessageBox.Show("Enter and Confirm The New Pin");
            } 
            else if(Pin2Tb.Text !=Pin2Tb.Text)
            {
                MessageBox.Show("Pin and Pin2 are Different");
            }
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN" + Pin1Tb.Text + "Where Accnum='" + Acc + "'";
                    Sqlcomand cmd = new Sqlcomand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Succesfully Update");
                    Con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
