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
    public partial class UC_ViewMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_sre_user_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                query = "select  from medic where mid like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                query = "select * from medic where mname like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                query = "select * from medic where mnumber like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
           
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewMedicine_Load(this, null);
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch
            {

            }
        }
        string name;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {

                query = "delete from medic Where mid ='" +name + "'";
                fn.setData(query, "User Record Deleated");
                UC_ViewMedicine_Load(this, null);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
