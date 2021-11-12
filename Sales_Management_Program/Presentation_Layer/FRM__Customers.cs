using Sales_Management_Program.EPL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FRM__Customers: Form
    {
        Business_Layer.Methods methods = new Business_Layer.Methods();
        private Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        TB_Customers tb_cust = new TB_Customers();
        int id;

        Presentation_Layer.FRM_HOME frm_home = new Presentation_Layer.FRM_HOME();

        public FRM__Customers()
        {
            InitializeComponent();

            Sales_Management_SystemEntities1 dbcontext = new Sales_Management_SystemEntities1();
            dbcontext.TB_Suppliers.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbcontext.TB_Suppliers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Panel recatpanel()
        {
            return pn_cat;
        }

        private void FRM_CAT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet3.TB_Customers' table. You can move, or remove it, as needed.
            this.tB_CustomersTableAdapter.Fill(this.sales_Management_SystemDataSet3.TB_Customers);
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet1.TB_Suppliers' table. You can move, or remove it, as needed.
        }

        // Add Button Function
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM__Customers_ADD frm_add = new FFRM__Customers_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();

        }
        // Delete Button Function
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("عمليه حذف", "هل انت متأكد من هذه العمليه", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    tb_cust = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_cust).State = EntityState.Deleted;
                    db.SaveChanges();
                    dialog.txt_caption.Text = "تم حذف العميل المحدد";
                    dialog.Show();
                    Update_data();

                }
            }
            catch
            {
                dialog.txt_caption.Text = "لا يوجد عملاء لحذفهم";
                dialog.Width = this.Width;
                dialog.Show();
                Update_data();
            }


        }
        // Edit Button Function
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM__Customers_ADD fRM_add = new FFRM__Customers_ADD();
            //db = new Sales_Management_SystemEntities1();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            tb_cust = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
            
            fRM_add.edt_name.Text = tb_cust.Cust_Name.ToString();
            fRM_add.edt_phone.Text = tb_cust.Cust_Phone.ToString();
            fRM_add.edt_email.Text = tb_cust.Cust_Email.ToString();
            fRM_add.edt_address.Text = tb_cust.Cust_Address.ToString();

            methods.by = tb_cust.Cust_Image;
            fRM_add.pic_cover.Image = Image.FromStream(methods.convert_image());
            fRM_add.id = id;
            fRM_add.simpleButton2.Text = "تعديل";
            fRM_add.Show();

        }

        // Update Button Function
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Update_data();
        }
        private void Update_data()
        {
            db = new Sales_Management_SystemEntities1();
            gridControl1.DataSource = db.TB_Customers.ToList();
        }
        // Search Button Function
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var _search = textBox2.Text;
            gridControl1.DataSource = db.TB_Customers.Where(x => x.Cust_Name.Contains(_search)).ToList(); 

        }
    }
}
