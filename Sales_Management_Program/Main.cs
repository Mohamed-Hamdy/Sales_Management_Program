﻿using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Sales_Management_Program
{
    public partial class Main : Form
    {

        Presentation_Layer.FRM_HOME frm_home = new Presentation_Layer.FRM_HOME();
        Presentation_Layer.FRM_CAT frm_cat = new Presentation_Layer.FRM_CAT();
        Presentation_Layer.FRM_SUPP frm_supp = new Presentation_Layer.FRM_SUPP();
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();

        public Main()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void navbarminmax_btn_Click(object sender, EventArgs e)
        {
            if (navbar_pn.Width >= 250)
            {
                navbar_pn.Width = 70;
                panel8.Visible = false;

            }
            else
            {
                navbar_pn.Width = 250;
                panel8.Visible = true;
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_home.pn_home);
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_home.pn_home);

        }

        private void items_brn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_cat.recatpanel());
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
        
        }


        private void SUPP_btn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_supp.recatpanel());
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
            

        }
    }
}