using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace BTL
{
    public partial class search_add_pattern : Form
    {
        public search_add_pattern()
        {
            InitializeComponent();
          
        }

        private void search_add_pattern_Load(object sender, EventArgs e)
        {

        }

        public trannfer tra = new trannfer();
        public static string so;

        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        private string q = "select * from thong_tin_benh_nhan where SoTheCanCuoc =";
        private void search_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                q = q + "'" + tb_cmnd.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = q;

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                
                adp.Fill(dt);
                
            }
            q = "select * from thong_tin_benh_nhan where SoTheCanCuoc =";
            
            this.Hide();
            so = tb_cmnd.Text;
            new Show_Info_Pattern().Show();
        }

   
        private void back(object sender, EventArgs e)
        {
            this.Hide();
            new Option().Show();
        }

        private void add(object sender, EventArgs e)
        {
            this.Hide();
            new AddPattern().Show();
        }

        private void show_all(object sender, EventArgs e)
        {
            this.Hide();
            new ShowAll().Show();
        }
    }
}
