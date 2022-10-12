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
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string query;
        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { user_nameS_lbl.Text= value; }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }
        string user1 = " ";
        string pass1 = " ";
        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query="select * from users where username ='"+user_nameS_lbl.Text+"'";
            DataSet ds = fn.GetData(query);
            txt_userRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_name.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_dob.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_mobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txt_email.Text = ds.Tables[0].Rows[0][5].ToString();
            txt_pass.Text = ds.Tables[0].Rows[0][7].ToString();
            txt_username.Text = ds.Tables[0].Rows[0][6].ToString();
            user1= txt_username.Text;
            pass1 = txt_pass.Text;

        }
        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string role = txt_userRole.Text;
            string name = txt_name.Text;
            string dob = txt_dob.Text;
            Int64 mobile = Int64.Parse(txt_mobile.Text);
            string email = txt_email.Text;
            string username = txt_username.Text;
            string pass = txt_pass.Text;
            
            query= "update users set userRole = '"+role+"',name= '"+name+"',dob= '"+dob+"',mobile= '"+mobile+"',email= '"+email+ "',username= '" + username + "',pass= '" + pass+ "' where username= '" + user1 + "'";
            fn.setData(query, " Update Successful !");
            if (user1 != username || pass1 != pass)
            {
                Application.Restart();
            }


        }

       
    }
}
