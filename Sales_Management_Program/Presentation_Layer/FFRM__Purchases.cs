using Sales_Management_Program.EPL;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FFRM__Purchases : Form
    {
        Business_Layer.Methods methods = new Business_Layer.Methods();
        private Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        TB_Purchases tb_pur= new TB_Purchases();
        int id;

        Presentation_Layer.FRM_HOME frm_home = new Presentation_Layer.FRM_HOME();

        public FFRM__Purchases()
        {
            InitializeComponent();

            Sales_Management_SystemEntities1 dbcontext = new Sales_Management_SystemEntities1();
            dbcontext.TB_CAT.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbcontext.TB_CAT.Local.ToBindingList();
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
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet2.TB_Purchases' table. You can move, or remove it, as needed.
            this.tB_PurchasesTableAdapter.Fill(this.sales_Management_SystemDataSet2.TB_Purchases);
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet.TB_CAT' table. You can move, or remove it, as needed.
            //gridControl1.Controls.Clear();
            //Presentation_Layer.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            //frm_add.id = 0;
            //frm_add.btn_add.Text = "اضافه";
            //frm_add.Show();
            //this.tB_CATTableAdapter.Fill(this.sales_Management_SystemDataSet.TB_CAT);
            //pn_cat.Controls.Clear();
            //pn_cat.Controls.Add(frm_add.pnadd_cont);
        }

        // Add Button Function
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_Purchases_ADD frm_add = new FFRM_Purchases_ADD();
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
                id = Convert.ToInt32(gridView5.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("عمليه حذف", "هل انت متأكد من هذه العمليه", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    tb_pur = db.TB_Purchases.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_pur).State = EntityState.Deleted;
                    db.SaveChanges();
                    dialog.txt_caption.Text = "تم حذف العنصر المحدد ";
                    dialog.Show();
                    Update_data();

                }
            }
            catch
            {
                dialog.txt_caption.Text = "لا يوجد مشتريات لحذفها";
                dialog.Width = this.Width;
                dialog.Show();
                Update_data();
            }


        }
        // Edit Button Function
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_Purchases_ADD fRM_add = new FFRM_Purchases_ADD();
            id = Convert.ToInt32(gridView5.GetFocusedRowCellValue("ID"));
            tb_pur = db.TB_Purchases.Where(x => x.ID == id).FirstOrDefault();
            
            fRM_add.edt_name.Text = tb_pur.Pur_Name;
            fRM_add.edt_Type.Text = tb_pur.Pur_Type;
            
            fRM_add.comboBox1.Text = tb_pur.Pur_Cat;
            fRM_add.comboBox2.Text = tb_pur.Pur_Supp;
            fRM_add.edt_Det.Text = tb_pur.Pur_Det;
            
            fRM_add.edt_buy.Text = tb_pur.Pur_Buy.ToString();
            fRM_add.edt_sell.Text = tb_pur.Pur_Sell.ToString();
            fRM_add.edt_qt.Text = tb_pur.Pur_Qt.ToString();
            
            fRM_add.edt_tbuy.Text = tb_pur.Pur_Tbuy.ToString();
            fRM_add.edt_tsell.Text = tb_pur.Pur_Tsell.ToString();
            fRM_add.edt_trev.Text = tb_pur.Pur_TRev.ToString();

            
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
            gridControl1.DataSource = db.TB_Purchases.ToList();
        }
        // Search Button Function
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var _search = textBox2.Text;
            gridControl1.DataSource = db.TB_Purchases.Where(x => x.Pur_Name.Contains(_search)).ToList(); 

        }
    }
}
