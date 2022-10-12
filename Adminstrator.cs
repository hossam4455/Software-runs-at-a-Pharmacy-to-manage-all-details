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
    public partial class Adminstrator : Form
    {
        string User="";
        public Adminstrator()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return User.ToString(); }
        }
        public Adminstrator(string user)
        {
           
            InitializeComponent();
            lbl_user.Text = user;
            User = user;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login fm = new login();
            fm.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }
      

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            uC_AddSupplier1.Visible = false;
            uC_AddSupplier1.Visible = false;
            btn_Dashboard.PerformClick();
          
        }
          private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void uC_Dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            uC_AddSupplier1.Visible = true;
            uC_AddSupplier1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_ViewSupplier1.Visible = true;
            uC_ViewSupplier1.BringToFront();
        }
    }
}
