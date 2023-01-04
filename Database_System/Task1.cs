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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mASAT_dbDataSet.Ist_Students' table. You can move, or remove it, as needed.
            this.ist_StudentsTableAdapter.Fill(this.mASAT_dbDataSet.Ist_Students);

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
        }
    }
}
