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
using System.Configuration;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class FFRM_Login: Form
    {

        // init
        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Users tb_users = new TB_Users();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Main Main = new Main();
        public FFRM_Login()
        {
            InitializeComponent();
        }
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // check add or edit = ""

         


            if (edt_username.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "برجاء ادخال اسم المستخدم او الايميل ";
                dialog.Show();
            }
            else
            {
                // check add or edit 
                if (id == 0)
                {
                    // Login 
                    tb_users = db.TB_Users.Where(x => x.User_Name == edt_username.Text && x.User_Password == edt_password.Text).FirstOrDefault();
                    if(tb_users != null){
                        tb_users.User_State = "True";
                        db.Entry(tb_users).State = System.Data.Entity.EntityState.Modified;
                        Main.lb_username.Text = tb_users.User_Name;
                        Main.lb_roll.Text = tb_users.User_Roll;
                        Main.Enabled = true;
                        db.SaveChanges();
                        Main.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong Please Make Sure your Data is Correct");
                    }

                }
            }

        }

        private void edt_sv_TextChanged(object sender, EventArgs e)
        {

        }

        private void FFRM_Login_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.FFRM_USERS_ADD frm_add = new FFRM_USERS_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "تسجيل حساب";
            frm_add.edt_Roll.Visible = false;
            frm_add.label1.Visible = false;
            frm_add.Show();
        }
    }
}
