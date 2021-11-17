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
    public partial class FFRM_Setting: Form
    {

        // init
        public FFRM_Setting()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var qt = "\"";
            var sv = edt_sv.Text;
            var constr1 = "metadata=res://*/Sales_Management_SystemM.csdl|res://*/Sales_Management_SystemM.ssdl|res://*/Sales_Management_SystemM.msl;provider=System.Data.SqlClient;provider connection string=" + qt + ";data source=" + sv+";initial catalog=Sales_Management_System;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
            //var constr1 = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=" + qt + ";data source=" + sv + ";initial catalog=Sales_Management_System;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Sales_Management_SystemEntities1"].ConnectionString = constr1;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var str2 = config.ConnectionStrings.ConnectionStrings["Sales_Management_SystemEntities1"].ConnectionString;
            MessageBox.Show(str2);
            Application.Restart();
        }

        private void edt_sv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
