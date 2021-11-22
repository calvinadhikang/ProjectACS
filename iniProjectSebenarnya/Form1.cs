using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace iniProjectSebenarnya
{
    public partial class Form1 : Form
    {
        public static OracleConnection conn;
        static string system, user, pass;

        public Form1()
        {
            InitializeComponent();
        }

        public static Boolean login = false;

        static void connDB()
        {
            string sys = Form1.system;
            string id = Form1.user;
            string pw = Form1.pass;

            conn = new OracleConnection("Data Source = " + sys + "; User ID = " + id + "; password = " + pw);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                login = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Connect Database : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system = tbSystem.Text;
            user = tbUser.Text;
            pass = tbPassword.Text;

            connDB();

            if(login == true)
            {
                this.Hide();
                UserLogin f = new UserLogin();
                f.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = false;
        }
    }
}
