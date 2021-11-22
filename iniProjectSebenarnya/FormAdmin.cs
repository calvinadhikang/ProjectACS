using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniProjectSebenarnya
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserLogin f = new UserLogin();
            f.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            panelSupplier.Visible = false;
            panelKaryawan.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelSupplier.Visible = true;
            panelKaryawan.Visible = false;

            //ssadjaskldaskld
            //asdkjaskldjad
        }
    }
}
