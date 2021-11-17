using DevExpress.XtraEditors;
using Sales_Management_Program.Presentation_Layer;
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
        Presentation_Layer.FFRM__Purchases frm_pur = new Presentation_Layer.FFRM__Purchases();
        Presentation_Layer.FRM__Customers frm_cus = new Presentation_Layer.FRM__Customers();
        Presentation_Layer.FFRM_Sells frm_sells = new Presentation_Layer.FFRM_Sells();
        Presentation_Layer.FRM_Reports frm_reports = new Presentation_Layer.FRM_Reports();
        Presentation_Layer.FFRM_Users frm_users = new Presentation_Layer.FFRM_Users();
        Presentation_Layer.FFRM_Setting frm_settings = new Presentation_Layer.FFRM_Setting();
        TB_Users tb_users = new TB_Users();

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


        private void Main_Load(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_home.pn_home);
            if (lb_roll.Text == "User")
            {
                users_btn.Enabled = false;
            }
            

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

        private void purchases_btn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_pur.recatpanel());
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_pur.gridControl1.DataSource = db.TB_Purchases.ToList();

        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_cus.recatpanel());
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_cus.gridControl1.DataSource = db.TB_Customers.ToList();

        }

        private void Sells_btn_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_sells.recatpanel());
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_sells.gridControl1.DataSource = db.TB_Sales.ToList();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_reports.pn_cat);
            //Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            //frm_sells.gridControl1.DataSource = db.TB_Sales.ToList();
        }

        private void navbarminmax_Click(object sender, EventArgs e)
        {
            if (navbar_pn.Width >= 250)
            {
                navbar_pn.Width = 70;
                panel8.Visible = false;
                
                main_btn.Text = String.Empty;
                main_btn.Width = 70;
                main_btn.ImageOptions.Location =  ImageLocation.MiddleCenter;
                
                items_brn.Text = String.Empty;
                items_brn.Width = 70;
                items_brn.ImageOptions.Location = ImageLocation.MiddleCenter;

                SUPP_btn.Text = String.Empty;
                SUPP_btn.Width = 70;
                SUPP_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

                purchases_btn.Text = String.Empty;
                purchases_btn.Width = 70;
                purchases_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

                Customers_btn.Text = String.Empty;
                Customers_btn.Width = 70;
                Customers_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

                Sells_btn.Text = String.Empty;
                Sells_btn.Width = 70;
                Sells_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

                btn_reports.Text = String.Empty;
                btn_reports.Width = 70;
                btn_reports.ImageOptions.Location = ImageLocation.MiddleCenter;

                users_btn.Text = String.Empty;
                users_btn.Width = 70;
                users_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

                Setting_btn.Text = String.Empty;
                Setting_btn.Width = 70;
                Setting_btn.ImageOptions.Location = ImageLocation.MiddleCenter;

            }
            else
            {
                navbar_pn.Width = 250;
                panel8.Visible = true;

                main_btn.Text = "الرئيسية";
                main_btn.Width = 250;
                main_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                items_brn.Text = "الاصناف";
                items_brn.Width = 250;
                items_brn.ImageOptions.Location = ImageLocation.MiddleRight;

                SUPP_btn.Text = "الموردين";
                SUPP_btn.Width = 250;
                SUPP_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                purchases_btn.Text = "المشتريات";
                purchases_btn.Width = 250;
                purchases_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                Customers_btn.Text = "العملاء";
                Customers_btn.Width = 250;
                Customers_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                Sells_btn.Text = "المبيعات";
                Sells_btn.Width = 250;
                Sells_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                btn_reports.Text = "التقارير";
                btn_reports.Width = 250;
                btn_reports.ImageOptions.Location = ImageLocation.MiddleRight;

                users_btn.Text = "المستخدمين";
                users_btn.Width = 250;
                users_btn.ImageOptions.Location = ImageLocation.MiddleRight;

                Setting_btn.Text = "الاعدادات";
                Setting_btn.Width = 250;
                Setting_btn.ImageOptions.Location = ImageLocation.MiddleRight;


            }

        }

        private void users_btn_Click(object sender, EventArgs e)
        {

            pn_content.Controls.Clear();
            pn_content.Controls.Add(frm_users.pn_cat);
            Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
            frm_users.gridControl1.DataSource = db.TB_Users.ToList();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {

            Presentation_Layer.FFRM_Setting frm_add = new FFRM_Setting();
            frm_add.simpleButton2.Text = "حفظ";
            frm_add.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_Login login = new FFRM_Login();
            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            //tb_users = db.TB_Users.Where(x => x.User_Name == tb_users.User_Name && x.User_Password == tb_users.User_Password).FirstOrDefault();
            tb_users.User_State = "False";
            db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Enabled = false;
            login.Show();
            this.Hide();     
        }
    }
}
