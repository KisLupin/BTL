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

namespace BTL
{
    public partial class testdb : Form
    {
        public testdb()
        {
            InitializeComponent();
        }
        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        string q = "select * from Users";

        private void testdb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'benh_vienDataSet.Users' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection(db);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader rd = cmd.ExecuteReader();
                dataGridView1.DataSource = rd;
            }
            catch(SqlException ex)
            {
                
            }
            finally
            {
                con.Close();
            }
           

        }
    }
}
