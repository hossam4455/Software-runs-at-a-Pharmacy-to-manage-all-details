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
    public partial class UC_ViewSupplier : UserControl
    {
        function fn = new function();
        string query;
        public UC_ViewSupplier()
        {
            InitializeComponent();
        }

        private void ViewSupplier_Load(object sender, EventArgs e)
        {
            query = "select * from suppliers";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_sre_user_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                query = "select * from suppliers where name like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                query = "select * from suppliers where mobile like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                query = "select * from suppliers where city like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                query = "select * from suppliers where country like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            ViewSupplier_Load(this, null);
        }
        string name = "";
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {

                query = "delete from suppliers Where name='" +name +"'";
                fn.setData(query, "User Record Deleated");
                ViewSupplier_Load(this, null);

            }
        }

       
    }
}
