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
   
    public partial class UC_AddSupplier : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddSupplier()
        {
            InitializeComponent();
        }

        private void UC_AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            Int64 mobile = Int64.Parse(txt_Mobile.Text);
            String email = txt_email.Text;
            string country = txt_country.Text;
            String city = txt_city.Text;
            String addr = txt_addr.Text;
            try
            {
                query = "insert into suppliers (name,mobile,email,country,city,address) values ( '" + name + "'," + mobile + ",'" + email + "','" + country + "','" + city + "','" + addr + "')";
                fn.setData(query, "Save Succrssful.");
            }
            catch (Exception)
            {
                MessageBox.Show("Supplier Allready Exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {

           
            txt_name.Clear();
            txt_addr.Clear();
            txt_city.Clear();
            txt_email.Clear();
            txt_Mobile.Clear();
            txt_country.ResetText();


        }
    }
}
