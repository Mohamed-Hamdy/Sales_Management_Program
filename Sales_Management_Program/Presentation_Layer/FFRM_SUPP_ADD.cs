using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales_Management_Program.EPL;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FFRM_SUPP_ADD: Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Suppliers tb_supp = new TB_Suppliers();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Presentation_Layer.FRM_SUPP frm_supp = new Presentation_Layer.FRM_SUPP();

        public FFRM_SUPP_ADD()
        {
            InitializeComponent();
        }

        

        private void FFRM_CAT_ADD_Load(object sender, EventArgs e)
        {

        }

        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // check add or edit = ""
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "برجاء ادخال البيانات كامله";
                dialog.Show();
            }
            else
            {
                // check add or edit 
                if (id == 0)
                {
                    // Add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    tb_supp.ID = id;
                    db.TB_Suppliers.Add(tb_supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه مورد جديد";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
                else
                {
                    // edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.convert_byte();
                    tb_supp.ID = this.id;
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل المورد ";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
            }


        }
    }
}
