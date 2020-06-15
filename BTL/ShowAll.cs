using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace BTL
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }


        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        private string q = "select * from thong_tin_benh_nhan";

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            new search_add_pattern().Show();
        }

        private void sort(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                q = q + " order by HoTen desc";
                cmd.Connection = con;
                cmd.CommandText = q;

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);
                data.DataSource = dt;
                con.Close();
            }
            q = "select * from thong_tin_benh_nhan";
        }

        private void ShowAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'benh_vienDataSet1.thong_tin_benh_nhan' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection(db);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = q;

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);
                data.DataSource = dt;
                con.Close();
            }

        }
    }
}
