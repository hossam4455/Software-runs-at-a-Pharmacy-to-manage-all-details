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
    public partial class UC_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddMedicine()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_MedicID.Text !="" && txt_medic_name.Text != "" && txt_medic_number.Text != "" && txt_price.Text != "" && txt_qun.Text != "" )
            {
                String MID = txt_MedicID.Text;
                String name = txt_medic_name.Text;
                String number = txt_medic_number.Text;
                string  edate = txt_Edate.Text;
                string mdate = txt_Mdate.Text;
                Int64 price = Int64.Parse(txt_price.Text);
                Int64 qun = Int64.Parse(txt_qun.Text);
                try
                {
                    query = "insert into Medic (mid,mname,mnumber,mDate,eDate,quantity,PerUnit) values ('" + MID + "', '" + name + "','" + number + "','" + mdate + "','" + edate + "','" + qun + "','" + price + "')";
                    fn.setData(query, "Medicine Added Succrssful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Medicine Allready Exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter All Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearAll();
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
          


        }

        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
