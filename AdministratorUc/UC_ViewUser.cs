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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        string query;
        string User2=" ";
       
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { User2 = value; }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }


       
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                query = "select * from users where username like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                query = "select * from users where name like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                query = "select * from users where mobile like '" + txt_sre_user.Text + "%'";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }






        }
       

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        string user_name;
       
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                user_name = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
               
            }
            catch
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                if (User2 != user_name)
                {
                    query = "delete from users Where username='" + user_name + "'";
                    fn.setData(query, "User Record Deleated");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




                    }

        }
    }
}
