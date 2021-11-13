using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class Customers_report: DevExpress.XtraReports.UI.XtraReport
    {
        public Customers_report ()
        {
            InitializeComponent();
        }
        public void show_preview()
        {
            Customers_report r = new Customers_report();
            r.ShowPreview();
        }
        public void show_Designer()
        {
            Customers_report r = new Customers_report();
            r.ShowDesigner();
        }
        

    }
}
