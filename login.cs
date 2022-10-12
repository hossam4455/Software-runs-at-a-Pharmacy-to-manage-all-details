using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class login : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            text_user.Clear();
            text_password.Clear();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (text_user.Text == "Admin" && text_password.Text == "Admin")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username='" + text_user.Text + "' and pass='" + text_password.Text + "'";
                ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count != 0)

                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Adminstrator admin = new Adminstrator(text_user.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist phram = new Pharmacist();
                        phram.Show();
                        this.Hide();
                    }
                  
                }
                else
                {

                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
