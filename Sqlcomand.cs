using System.Data.SqlClient;

namespace ATM
{
    internal class Sqlcomand
    {
        private string query;
        private SqlConnection con;

        public Sqlcomand()
        {
        }

        public Sqlcomand(string query, SqlConnection con)
        {
            this.query = query;
            this.con = con;
        }
    }
}