using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL
{
    public partial class AddPattern : Form
    {
        public AddPattern()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string db = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=benh_vien;Integrated Security=True";
        private string q = "insert into thong_tin_benh_nhan values(@msbn, @hvt, @tuoi, @sex, @address, @sdt, @thecancuoc)";

        private void add_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
                SqlCommand cmd = new SqlCommand(q, con);
                string msbn = "BN" + new Random().Next(100, 10000);
                cmd.Parameters.AddWithValue("@msbn", msbn);
                cmd.Parameters.AddWithValue("@hvt", tb_ht.Text);
                cmd.Parameters.AddWithValue("@tuoi", Convert.ToInt32(tb_age.Text));
                cmd.Parameters.AddWithValue("@sex", tb_sex.Text);
                cmd.Parameters.AddWithValue("@address", tb_address.Text);
                cmd.Parameters.AddWithValue("@sdt", tb_num.Text);
                cmd.Parameters.AddWithValue("@thecancuoc", tb_cmt.Text);

                //cmd.ExecuteNonQuery();
                con.Open();
                cmd.ExecuteNonQuery();
                // Check Error
               
                MessageBox.Show("Add Success!");
                

           
        }

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            new search_add_pattern().Show();
        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
