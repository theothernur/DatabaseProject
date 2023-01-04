
namespace Database_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_user.Location = new System.Drawing.Point(297, 100);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(139, 20);
            this.tb_user.TabIndex = 0;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(297, 139);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(139, 20);
            this.tb_pw.TabIndex = 1;
            this.tb_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(215, 103);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(55, 13);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Username";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(217, 142);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(53, 13);
            this.lb_pw.TabIndex = 3;
            this.lb_pw.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(361, 197);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sign
            // 
            this.btn_sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sign.FlatAppearance.BorderSize = 0;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.ForeColor = System.Drawing.Color.White;
            this.btn_sign.Location = new System.Drawing.Point(218, 197);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 5;
            this.btn_sign.Text = "Sign Up";
            this.btn_sign.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_sign);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.tb_pw);
            this.panel1.Controls.Add(this.lb_pw);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Location = new System.Drawing.Point(54, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 305);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 124);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Database_System.Properties.Resources.icon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(57, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "MASAT Database Login Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

