
namespace PMS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_sign = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Image = global::PMS.Properties.Resources.Close_all_jframe;
            this.btn_exit.Location = new System.Drawing.Point(384, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(91, 66);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // text_user
            // 
            this.text_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_user.DefaultText = "";
            this.text_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_user.DisabledState.Parent = this.text_user;
            this.text_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_user.FocusedState.Parent = this.text_user;
            this.text_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.ForeColor = System.Drawing.Color.Black;
            this.text_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_user.HoverState.Parent = this.text_user;
            this.text_user.Location = new System.Drawing.Point(59, 300);
            this.text_user.Margin = new System.Windows.Forms.Padding(5);
            this.text_user.Name = "text_user";
            this.text_user.PasswordChar = '\0';
            this.text_user.PlaceholderText = "";
            this.text_user.SelectedText = "";
            this.text_user.ShadowDecoration.Parent = this.text_user;
            this.text_user.Size = new System.Drawing.Size(344, 36);
            this.text_user.TabIndex = 8;
            this.text_user.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_password.DefaultText = "";
            this.text_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_password.DisabledState.Parent = this.text_password;
            this.text_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_password.FocusedState.Parent = this.text_password;
            this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.ForeColor = System.Drawing.Color.Black;
            this.text_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_password.HoverState.Parent = this.text_password;
            this.text_password.Location = new System.Drawing.Point(59, 387);
            this.text_password.Margin = new System.Windows.Forms.Padding(5);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.PlaceholderText = "";
            this.text_password.SelectedText = "";
            this.text_password.ShadowDecoration.Parent = this.text_password;
            this.text_password.Size = new System.Drawing.Size(344, 36);
            this.text_password.TabIndex = 9;
            this.text_password.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // btn_sign
            // 
            this.btn_sign.BorderRadius = 19;
            this.btn_sign.BorderThickness = 1;
            this.btn_sign.CheckedState.Parent = this.btn_sign;
            this.btn_sign.CustomImages.Parent = this.btn_sign;
            this.btn_sign.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.ForeColor = System.Drawing.Color.White;
            this.btn_sign.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_sign.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_sign.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sign.HoverState.Parent = this.btn_sign;
            this.btn_sign.Image = global::PMS.Properties.Resources.signin_100px;
            this.btn_sign.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_sign.Location = new System.Drawing.Point(59, 466);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.ShadowDecoration.Parent = this.btn_sign;
            this.btn_sign.Size = new System.Drawing.Size(146, 36);
            this.btn_sign.TabIndex = 10;
            this.btn_sign.Text = "Sign In";
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BorderRadius = 19;
            this.btn_reset.BorderThickness = 1;
            this.btn_reset.CheckedState.Parent = this.btn_reset;
            this.btn_reset.CustomImages.Parent = this.btn_reset;
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_reset.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_reset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset.HoverState.Parent = this.btn_reset;
            this.btn_reset.Image = global::PMS.Properties.Resources.reset_25px;
            this.btn_reset.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_reset.Location = new System.Drawing.Point(257, 466);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.ShadowDecoration.Parent = this.btn_reset;
            this.btn_reset.Size = new System.Drawing.Size(146, 36);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 251);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign In ";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox text_user;
        private Guna.UI2.WinForms.Guna2TextBox text_password;
        private Guna.UI2.WinForms.Guna2Button btn_sign;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

