using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class Purchases_report: DevExpress.XtraReports.UI.XtraReport
    {
        public Purchases_report()
        {
            InitializeComponent();
        }
        public void show_preview()
        {
            Purchases_report r = new Purchases_report();
            r.ShowPreview();
        }
        public void show_Designer()
        {
            Purchases_report r = new Purchases_report();
            r.ShowDesigner();
        }
        

    }
}
