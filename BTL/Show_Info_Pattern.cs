using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace BTL
{
    public partial class Show_Info_Pattern : Form
    {
        public Show_Info_Pattern()
        {
            InitializeComponent();
        }

        private void click_back(object sender, EventArgs e)
        {
            this.Hide();
            new search_add_pattern().Show();
        }

        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        private string q = "select * from thong_tin_benh_nhan where SoTheCanCuoc = ";
        private void Show_Info_Pattern_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(db);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                
                q = q + "'" + search_add_pattern.so + "'";
                cmd.Connection = con;
                cmd.CommandText = q;

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
