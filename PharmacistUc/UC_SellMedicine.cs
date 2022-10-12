using DGVPrinterHelper;
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
    public partial class UC_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_SellMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname from medic where quantity >'0' and  CONVERT(DATE, eDate, 103) >=  CAST(GETDATE() As Date)";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_MedicID_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname  from medic where mname like '" + txt_Search.Text + "%' and quantity >'0'";
             ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_SellMedicine_Load(this, null);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_nounits.Clear();
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            txt_name.Text = name;
            query = "select mid,eDate,PerUnit  from medic where mname ='" + name + "' ";
            ds = fn.GetData(query);
            txt_id.Text = ds.Tables[0].Rows[0][0].ToString();
            txt_Edate.Text= ds.Tables[0].Rows[0][1].ToString();
            txt_peruint.Text= ds.Tables[0].Rows[0][2].ToString();
        }

        private void txt_nounits_TextChanged(object sender, EventArgs e)
        {
            if(txt_nounits.Text!="")
            {
                Int64 price = Int64.Parse(txt_peruint.Text);
                Int64 number = Int64.Parse(txt_nounits.Text);
                Int64 total = price * number;
                txt_TotalPrice.Text = total.ToString();
            }
            else
            {
                txt_TotalPrice.Clear();
            }
        }

        protected int n, total = 0;
        protected Int64 qun, N_qun;

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_id.Text!="")
            {
                query = "select quantity from medic where mid ='" + txt_id.Text + "' ";
                ds = fn.GetData(query);
                qun = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                N_qun = qun - Int64.Parse(txt_nounits.Text);
                if(N_qun>=0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txt_id.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txt_name.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txt_Edate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txt_peruint.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txt_nounits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txt_TotalPrice.Text;
                    total += int.Parse(txt_TotalPrice.Text);
                    total_lbl.Text = $"Total Price : {total} $";
                    query = " update medic set  quantity = '" + N_qun + "' where mid = '" + txt_id.Text + "'";
                    fn.setData(query,"Medicine Add !");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock Only "+qun+" Left","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                UC_SellMedicine_Load(this, null);
                clearAll();
               
               
            }
            else
            {
                MessageBox.Show("Select Medicine Frist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int amount;
        string Id;
        protected Int64 NU_qun;
         

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                Id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NU_qun = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = string.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer= total_lbl.Text ;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);
            total = 0;
            total_lbl.Text = $"Total Price : {total} $";
            guna2DataGridView1.DataSource = 0;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid ='" + Id + "' ";
                    ds = fn.GetData(query);
                    qun = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    N_qun = qun + NU_qun;
                    query = " update medic set  quantity = '" + N_qun + "' where mid = '" + Id + "'";
                    fn.setData(query, "Medicine Removed from Cart. !");
                    total -= amount;
                    total_lbl.Text = $"Total Price : {total} $";

                }
                UC_SellMedicine_Load(this, null);
            }
        }

        public void clearAll()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_peruint.Clear();
            txt_TotalPrice.Clear();
            txt_nounits.Clear();
            txt_Edate.ResetText();

        }
    }
}
