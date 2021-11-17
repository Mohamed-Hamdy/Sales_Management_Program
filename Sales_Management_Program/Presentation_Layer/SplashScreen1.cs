using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sales_Management_Program.Presentation_Layer
{
    public partial class SplashScreen1 : SplashScreen
    {
        Business_Layer.Methods methods = new Business_Layer.Methods();
        TB_Users tb_users = new TB_Users();
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Main Main = new Main();
        Presentation_Layer.FFRM_Login login_form = new FFRM_Login();
        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © Mohamed El Laithy";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tb_users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();
            if(tb_users != null)
            {
                Main.lb_username.Text = tb_users.User_Name;
                Main.lb_roll.Text = tb_users.User_Roll;
                Main.Show();
            }
            else
            {
                login_form.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }
    }
}