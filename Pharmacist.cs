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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicine1.Visible = false;
            uC_UpdateMedicine1.Visible = false;
            uC_SellMedicine1.Visible = false;
            uC_Valid_check1.Visible = false;
            btn_Dashboard.PerformClick();

        }

        private void btn_AddMedic_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();
        }

        private void btn_ViewMedic_Click(object sender, EventArgs e)
        {
            uC_ViewMedicine1.Visible = true;
            uC_ViewMedicine1.BringToFront();
        }

        private void btn_ModifyMedic_Click(object sender, EventArgs e)
        {
            uC_UpdateMedicine1.Visible = true;
            uC_UpdateMedicine1.BringToFront();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            uC_SellMedicine1.Visible = true;
            uC_SellMedicine1.BringToFront();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            uC_Valid_check1.Visible = true;
            uC_Valid_check1.BringToFront();
        }
    }
}
