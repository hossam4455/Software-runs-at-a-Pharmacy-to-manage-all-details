using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdministratorUc
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            String role = txtUser_role.Text;
            String name = txt_name.Text;
            String dob = txt_DOB.Text;
            Int64 mobile = Int64.Parse(txt_Mobile.Text);
            String email = txt_email.Text;
            String username = txt_user_name.Text;
            String pass = txt_password.Text;
            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "', '" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sgin Up Succrssful.");
            }
            catch (Exception)
            {
                MessageBox.Show("Username Allready Exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {

            txtUser_role.SelectedIndex = -1;
            txt_name.Clear();
            txt_user_name.Clear();
            txt_password.Clear();
            txt_email.Clear();
            txt_Mobile.Clear();
            txt_DOB.ResetText();


        }

        private void txt_user_name_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txt_user_name.Text + "'";
            DataSet ds = fn.GetData(query);

            if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"D:\Hazem\PMS\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"D:\Hazem\PMS\Pharmacy Management System in C#\no.png";
            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }

}

    


