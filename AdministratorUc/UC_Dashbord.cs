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
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from  users where userRole='Administrator'";
            ds = fn.GetData(query);
            Setlabel(ds, Admin_lbl);
            query = "select count(userRole) from  users where userRole='Pharmacist'";
            ds = fn.GetData(query);
            Setlabel(ds, pharm_lbl);
        }
        private void Setlabel(DataSet ds,Label lbl)
        {
            if(ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashbord_Load(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
