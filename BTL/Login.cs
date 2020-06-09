using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            if (tb1_user.Text == "Tên Đăng Nhập")
            {
                tb1_user.Text = "";
                tb1_user.ForeColor = Color.Black;
            }

        }

        private void textBox1_TextChanged()
        {

        }

        private void mouse_leave(object sender, EventArgs e)
        {
            if (tb1_user.Text == "")
            {
                tb1_user.Text = "Tên Đăng Nhập";
                tb1_user.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private void click_login(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "select * from Users where username=" + "'" + tb1_user.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                Console.WriteLine("connect success");
                da = new SqlDataAdapter(cmd);
                rd = cmd.ExecuteReader();
               
            }
        }

        private void mouse_enter_pas(object sender, EventArgs e)
        {
            if (tb2_pass.Text == "Mật Khẩu")
            {
                tb2_pass.Text = "";
                tb2_pass.ForeColor = Color.Black;
            }
        }

        private void mouse_leave_pas(object sender, EventArgs e)
        {
            if (tb2_pass.Text == "")
            {
                tb2_pass.Text = "Mật Khẩu";
                tb2_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
