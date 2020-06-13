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
        string q = "select * from Users where username = 'abc'";

        private void testdb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'benh_vienDataSet.Users' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection(db);
         
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = q;

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                Console.WriteLine(dt.Rows[0]["password"]);
          
        }
    }
}
