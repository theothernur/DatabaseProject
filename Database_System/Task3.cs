using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_System
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
        }
    }
}
