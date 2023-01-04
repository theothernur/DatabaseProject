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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mASAT_dbDataSet4.HoodiesLimitedEditionOrders' table. You can move, or remove it, as needed.
            this.hoodiesLimitedEditionOrdersTableAdapter1.Fill(this.mASAT_dbDataSet4.HoodiesLimitedEditionOrders);
            // TODO: This line of code loads data into the 'mASAT_dbDataSet3.HoodiesLimitedEditionOrders' table. You can move, or remove it, as needed.
            //this.hoodiesLimitedEditionOrdersTableAdapter.Fill(this.mASAT_dbDataSet3.HoodiesLimitedEditionOrders);
            // TODO: This line of code loads data into the 'mASAT_dbDataSet1.LastYearOrders' table. You can move, or remove it, as needed.
            //this.lastYearOrdersTableAdapter.Fill(this.mASAT_dbDataSet1.LastYearOrders);

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
        }
    }
}
