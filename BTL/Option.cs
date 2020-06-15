using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void bt_ttbn(object sender, EventArgs e)
        {
            this.Hide();
            new search_add_pattern().Show();

        }

        private void bt_lpk(object sender, EventArgs e)
        {

        }

        private void bt_hd(object sender, EventArgs e)
        {

        }

        private void bt_dv(object sender, EventArgs e)
        {

        }

        private void bt_qldspk(object sender, EventArgs e)
        {

        }
    }
}
