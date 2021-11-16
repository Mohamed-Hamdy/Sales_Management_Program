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
    public partial class FFRM_USERS_ADD: Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Users tb_users = new TB_Users();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Presentation_Layer.FFRM_Users frm_users = new Presentation_Layer.FFRM_Users();

        public FFRM_USERS_ADD()
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
                    tb_users.User_Name = edt_name.Text;
                    tb_users.User_Password = edt_password.Text;
                    tb_users.User_Roll = edt_Roll.Text;
                    tb_users.User_State = "False";
                    
                    //tb_users. = methods.convert_byte();
                    db.TB_Users.Add(tb_users);
                    tb_users.ID = this.id;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه بيانات المستخدم جديد";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
                else
                {
                    // edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_users.User_Name = edt_name.Text;
                    tb_users.User_Password = edt_password.Text;
                    tb_users.User_Roll = edt_Roll.Text;
                    //tb_supp.Supp_Image = methods.convert_byte();
                    tb_users.User_State = "False";
                    tb_users.ID = this.id;
                    db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل بيانات المستخدم  ";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
            }


        }
    }
}
