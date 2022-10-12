using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.PharmacistUc
{
    public partial class UC_Valid_check : UserControl
    {
        function fn = new function();
        string query;
        public UC_Valid_check()
        {
            InitializeComponent();
        }

        private void UC_Valid_check_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                query = "select * from medic where CONVERT(DATE, eDate, 103) >=  CAST(GETDATE() As Date)";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                lbl_txt.Text = "Vaild Medicine";
                lbl_txt.ForeColor = Color.Green;

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                query = "select * from medic where CONVERT(DATE, eDate, 103) <=  CAST(GETDATE() As Date)";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                lbl_txt.Text = "Expierd Medicine";
                lbl_txt.ForeColor = Color.Red;
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                query = "select * from medic";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                lbl_txt.Text = " ";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Valid_check_Load(this, null);
        }
    }
}
