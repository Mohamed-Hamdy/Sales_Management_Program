using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FRM_HOME : Form
    {
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        public FRM_HOME()
        {
            InitializeComponent();
            // Number of categories in Database 
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text = list_cat.Count.ToString();

            // Number of Suppliers in Database 
            List<TB_Suppliers> list_Supp = db.TB_Suppliers.ToList();
            lb_supp.Text = list_Supp.Count.ToString();

            // Number of Sales Processes in Database 
            List<TB_Sales> list_Sales = db.TB_Sales.ToList();
            lb_sales.Text = list_Sales.Count.ToString();

            // Number of Customers in Database 
            List<TB_Customers> list_Customers = db.TB_Customers.ToList();
            lb_customers.Text = list_Customers.Count.ToString();

            // Number of Purchases in Database 
            List<TB_Purchases> list_Pur = db.TB_Purchases.ToList();
            lb_purchases.Text = list_Pur.Count.ToString();

        }

        private void addCAT_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();
        }

        private void AddSUPP_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();

        }

        private void ADDPURCHASES_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_Purchases_ADD frm_add = new FFRM_Purchases_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();

        }

        private void ADDCUSTOMERS_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM__Customers_ADD frm_add = new FFRM__Customers_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();

        }

        private void ADDSALES_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_Sells_ADD frm_add = new FFRM_Sells_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();

        }
    }
}
