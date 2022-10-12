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
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;
        public UC_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
          loadChart();
        }
        public void loadChart()
        {
            query = "select  count(mname) from medic where CONVERT(DATE, eDate, 103) >=  CAST(GETDATE() As Date)";
            ds = fn.GetData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chary", count);
            query = "select  count(mname) from medic where CONVERT(DATE, eDate, 103) <=  CAST(GETDATE() As Date)";
            ds = fn.GetData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chary", count);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            loadChart();
        }
    }
}
