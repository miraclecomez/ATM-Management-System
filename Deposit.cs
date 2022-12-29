using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Griya Dircomp\Documents\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void button7_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text)<=0);
            {
                MessageBox.Show("Enter The Ammount to Deposit");
            }
            else
            {

                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance" + newbalance + "Where Accnum='" + Acc + "'";
                    Sqlcomand cmd = new Sqlcomand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succes Deposit");
                    Con.Close();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance =Convert.ToInt32 (dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
