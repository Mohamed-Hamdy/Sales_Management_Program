using Sales_Management_Program.EPL;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FRM_Reports: Form
    {
        
        public FRM_Reports()
        {
            InitializeComponent();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Report1 report = new Report1();
            report.show_preview();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Purchases_report r = new Purchases_report();
            r.show_preview();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Customers_report r = new Customers_report();
            r.show_preview();

        }

        
    }
}
