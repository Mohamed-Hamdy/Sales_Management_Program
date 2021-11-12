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
    public partial class FFRM__Customers_ADD: Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Customers tb_cust = new TB_Customers();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Presentation_Layer.FRM__Customers frm_cust = new Presentation_Layer.FRM__Customers();

        public FFRM__Customers_ADD()
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
                    tb_cust.Cust_Name = edt_name.Text;
                    tb_cust.Cust_Phone = edt_phone.Text;
                    tb_cust.Cust_Email = edt_email.Text;
                    tb_cust.Cust_Address = edt_address.Text;
                    tb_cust.Cust_Image = methods.convert_byte();
                    tb_cust.ID = id;
                    db.TB_Customers.Add(tb_cust);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه عميل جديد";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
                else
                {
                    // edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_cust.Cust_Name = edt_name.Text;
                    tb_cust.Cust_Phone = edt_phone.Text;
                    tb_cust.Cust_Email = edt_email.Text;
                    tb_cust.Cust_Address = edt_address.Text;
                    tb_cust.Cust_Image = methods.convert_byte();
                    tb_cust.ID = this.id;
                    db.Entry(tb_cust).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل العميل المحدد ";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();

                }
            }


        }
    }
}
