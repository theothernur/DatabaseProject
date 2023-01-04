
namespace Database_System
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sign = new System.Windows.Forms.Button();
            this.hoodiesLimitedEditionOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASAT_dbDataSet3 = new Database_System.MASAT_dbDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mASAT_dbDataSet1 = new Database_System.MASAT_dbDataSet1();
            this.lastYearOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastYearOrdersTableAdapter = new Database_System.MASAT_dbDataSet1TableAdapters.LastYearOrdersTableAdapter();
            this.hoodiesLimitedEditionOrdersTableAdapter = new Database_System.MASAT_dbDataSet3TableAdapters.HoodiesLimitedEditionOrdersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mASAT_dbDataSet4 = new Database_System.MASAT_dbDataSet4();
            this.hoodiesLimitedEditionOrdersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoodiesLimitedEditionOrdersTableAdapter1 = new Database_System.MASAT_dbDataSet4TableAdapters.HoodiesLimitedEditionOrdersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoodiesLimitedEditionOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastYearOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoodiesLimitedEditionOrdersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_sign);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 299);
            this.panel1.TabIndex = 13;
            // 
            // btn_sign
            // 
            this.btn_sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sign.FlatAppearance.BorderSize = 0;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.ForeColor = System.Drawing.Color.White;
            this.btn_sign.Location = new System.Drawing.Point(367, 30);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 7;
            this.btn_sign.Text = "Back";
            this.btn_sign.UseVisualStyleBackColor = false;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // hoodiesLimitedEditionOrdersBindingSource
            // 
            this.hoodiesLimitedEditionOrdersBindingSource.DataMember = "HoodiesLimitedEditionOrders";
            this.hoodiesLimitedEditionOrdersBindingSource.DataSource = this.mASAT_dbDataSet3;
            // 
            // mASAT_dbDataSet3
            // 
            this.mASAT_dbDataSet3.DataSetName = "MASAT_dbDataSet3";
            this.mASAT_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Orders for Hoodie (Limited Edition)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Task 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 124);
            this.panel2.TabIndex = 12;
            // 
            // mASAT_dbDataSet1
            // 
            this.mASAT_dbDataSet1.DataSetName = "MASAT_dbDataSet1";
            this.mASAT_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastYearOrdersBindingSource
            // 
            this.lastYearOrdersBindingSource.DataMember = "LastYearOrders";
            this.lastYearOrdersBindingSource.DataSource = this.mASAT_dbDataSet1;
            // 
            // lastYearOrdersTableAdapter
            // 
            this.lastYearOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // hoodiesLimitedEditionOrdersTableAdapter
            // 
            this.hoodiesLimitedEditionOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoodiesLimitedEditionOrdersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(49, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // mASAT_dbDataSet4
            // 
            this.mASAT_dbDataSet4.DataSetName = "MASAT_dbDataSet4";
            this.mASAT_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoodiesLimitedEditionOrdersBindingSource1
            // 
            this.hoodiesLimitedEditionOrdersBindingSource1.DataMember = "HoodiesLimitedEditionOrders";
            this.hoodiesLimitedEditionOrdersBindingSource1.DataSource = this.mASAT_dbDataSet4;
            // 
            // hoodiesLimitedEditionOrdersTableAdapter1
            // 
            this.hoodiesLimitedEditionOrdersTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "name1";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Task2";
            this.Text = "Task2";
            this.Load += new System.EventHandler(this.Task2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoodiesLimitedEditionOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastYearOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASAT_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoodiesLimitedEditionOrdersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MASAT_dbDataSet1 mASAT_dbDataSet1;
        private System.Windows.Forms.BindingSource lastYearOrdersBindingSource;
        private MASAT_dbDataSet1TableAdapters.LastYearOrdersTableAdapter lastYearOrdersTableAdapter;
        private MASAT_dbDataSet3 mASAT_dbDataSet3;
        private System.Windows.Forms.BindingSource hoodiesLimitedEditionOrdersBindingSource;
        private MASAT_dbDataSet3TableAdapters.HoodiesLimitedEditionOrdersTableAdapter hoodiesLimitedEditionOrdersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MASAT_dbDataSet4 mASAT_dbDataSet4;
        private System.Windows.Forms.BindingSource hoodiesLimitedEditionOrdersBindingSource1;
        private MASAT_dbDataSet4TableAdapters.HoodiesLimitedEditionOrdersTableAdapter hoodiesLimitedEditionOrdersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}