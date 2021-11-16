using Sales_Management_Program.EPL;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FFRM_Users: Form
    {
        Business_Layer.Methods methods = new Business_Layer.Methods();
        private Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        TB_Users tb_users= new TB_Users();
        int id;

        Presentation_Layer.FRM_HOME frm_home = new Presentation_Layer.FRM_HOME();

        public FFRM_Users()
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
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet5.TB_Users' table. You can move, or remove it, as needed.
            this.tB_UsersTableAdapter.Fill(this.sales_Management_SystemDataSet5.TB_Users);
        }

        // Add Button Function
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_USERS_ADD frm_users = new FFRM_USERS_ADD();
            frm_users.id = 0;
            frm_users.simpleButton2.Text = "اضافه";
            frm_users.Show();

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
                    tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_users).State = EntityState.Deleted;
                    db.SaveChanges();
                    dialog.txt_caption.Text = "تم حذف المستخدم المحدد ";
                    dialog.Show();
                    Update_data();

                }
            }
            catch
            {
                dialog.txt_caption.Text = "لا يوجد مستخدمين لحذفهم";
                dialog.Width = this.Width;
                dialog.Show();
                Update_data();
            }


        }
        // Edit Button Function
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_USERS_ADD fRM_add = new FFRM_USERS_ADD();
            id = Convert.ToInt32(gridView5.GetFocusedRowCellValue("ID"));
            tb_users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
            
            fRM_add.edt_name.Text = tb_users.User_Name;
            fRM_add.edt_password.Text = tb_users.User_Password;
            fRM_add.edt_Roll.Text = tb_users.User_Roll;
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
            gridControl1.DataSource = db.TB_Users.ToList();
        }
        // Search Button Function
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var _search = textBox2.Text;
            gridControl1.DataSource = db.TB_Users.Where(x => x.User_Name.Contains(_search)).ToList(); 

        }
    }
}
