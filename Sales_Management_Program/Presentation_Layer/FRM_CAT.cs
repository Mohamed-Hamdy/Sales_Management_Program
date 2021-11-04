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
    public partial class FRM_CAT : Form
    {
        Business_Layer.Methods methods = new Business_Layer.Methods();
        private Sales_Management_SystemEntities1 db;
        TB_CAT tb_cat = new TB_CAT();
        int id;

        Presentation_Layer.FRM_HOME frm_home = new Presentation_Layer.FRM_HOME();

        public FRM_CAT()
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
            // TODO: This line of code loads data into the 'sales_Management_SystemDataSet.TB_CAT' table. You can move, or remove it, as needed.

            //gridControl1.Controls.Clear();

            //           Presentation_Layer.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();


            //frm_add.id = 0;
            //frm_add.btn_add.Text = "اضافه";
            //frm_add.Show();
            /*
            String query = "select * from TB_CAT";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            con.Close();
            */

            this.tB_CATTableAdapter.Fill(this.sales_Management_SystemDataSet.TB_CAT);

            //Present panel5.Controls.Clear();
            //panel5.Controls.Add(frm_home.repanel());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافه";
            frm_add.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("عمليه حذف", "هل انت متأكد من هذه العمليه", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_cat).State = EntityState.Deleted;
                    db.SaveChanges();
                    Update_data();

                }
            }
            catch 
            {
                dialog.txt_caption.Text = "لا يوجد صنف لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
                Update_data();
            }
            

        }
        private void Update_data()
        {
            db = new Sales_Management_SystemEntities1();
            gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_CAT_ADD fRM_add = new FFRM_CAT_ADD();

            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault();
            fRM_add.edt_name.Text = tb_cat.CAT_Name.ToString();
            methods.by = tb_cat.CAT_Cover;
            fRM_add.pic_cover.Image = Image.FromStream(methods.convert_image());
            fRM_add.id = id;
            fRM_add.btn_add.Text = "تعديل";
            frm_home.Show();


        }
    }
}
