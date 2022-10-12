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
    public partial class UC_UpdateMedicine : UserControl
    {
       function fn = new function();
        String query;
        DataSet ds;
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_MedicID.Text!="")
            {
                query = "select * from medic where mid ='" + txt_MedicID.Text + "'";
               ds = fn.GetData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    txt_medic_name.Text = ds.Tables[0].Rows[0][2].ToString();
                    txt_medic_number.Text= ds.Tables[0].Rows[0][3].ToString(); ;
                    txt_Mdate .Text= ds.Tables[0].Rows[0][4].ToString();
                    txt_Edate.Text= ds.Tables[0].Rows[0][5].ToString();
                    txt_qun.Text= ds.Tables[0].Rows[0][6].ToString();
                    txt_price.Text= ds.Tables[0].Rows[0][7].ToString();
                    txt_Add.Text = "0";
                }
                else
                {
                    MessageBox.Show("No Medicine whit ID : " + txt_MedicID.Text + " exits", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                clearAll();
            }
        }
        public void clearAll()
        {
            txt_MedicID.Clear();
            txt_medic_name.Clear();
            txt_medic_number.Clear();
            txt_price.Clear();
            txt_qun.Clear();
            txt_Edate.ResetText();
            txt_Mdate.ResetText();
            if (txt_Add.Text != "0")
            {
                txt_Add.Text = "0";
            }
            else
            {
                txt_Add.Text = "0";
            }



        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 total_qun;
        private void btn_update_Click(object sender, EventArgs e)
        {
            String MID = txt_MedicID.Text;
            String name = txt_medic_name.Text;
            String number = txt_medic_number.Text;
            String edate = txt_Edate.Text;
            String mdate = txt_Mdate.Text;
            Int64 price = Int64.Parse(txt_price.Text);
            Int64 qun = Int64.Parse(txt_qun.Text);
            Int64 ADDqun = Int64.Parse(txt_Add.Text);
            total_qun = qun + ADDqun;
            query = "update medic set mname= '" + name + "',mnumber= '" + number + "',mDate= '" + mdate + "',eDate= '" + edate + "',quantity= '" + total_qun + "',PerUnit= '" +price + "' where mid= '" + MID + "'";
            fn.setData(query, " Update Successful !");
        }
    }
}
