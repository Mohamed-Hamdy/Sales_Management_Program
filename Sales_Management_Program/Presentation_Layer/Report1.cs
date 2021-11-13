using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();
        }
        public void show_preview()
        {
            Report1 r = new Report1();
            r.ShowPreview();
        }
        public void show_Designer()
        {
            Report1 r = new Report1();
            r.ShowDesigner();
        }
        

    }
}
