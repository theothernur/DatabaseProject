using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Database_System
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string user = tb_user.Text;
            string password = tb_pw.Text;
            con = new SqlConnection("Data Source = DESKTOP-STRMOBV\\MSSQLSERVER01; Initial Catalog = MASAT_db; Integrated Security=True");
            com = new SqlCommand();

            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Login where username='" + tb_user.Text + "' And password='" + tb_pw.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                HomePage f2 = new HomePage();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

      
        }
    }
}
