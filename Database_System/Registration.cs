using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_System
{
    public partial class Registration : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if(tb_pw.Text!=tb_pw2.Text)
            {
                MessageBox.Show("Password do not match!");
            }
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-STRMOBV\\MSSQLSERVER01; Initial Catalog = MASAT_db; Integrated Security=True");
            //com = new SqlCommand();
                con.Open();
                SqlCommand com = new SqlCommand("UserAdd", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@username", tb_user.Text.Trim());
                com.Parameters.AddWithValue("@password", tb_pw.Text.Trim());
               // com.Parameters.AddWithValue("@password", tb_pw2.Text.Trim());
                com.ExecuteNonQuery();
            //con.Close();

            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
        }
 
    }
}
