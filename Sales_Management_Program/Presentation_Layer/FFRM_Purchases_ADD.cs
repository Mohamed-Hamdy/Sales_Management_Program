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
    public partial class FFRM_Purchases_ADD: Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Purchases tb_pur = new TB_Purchases();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        FFRM__Purchases frm_pur = new FFRM__Purchases();
        double buy, sell, qt, tbuy, tsell, trev;
        
        public FFRM_Purchases_ADD()
        {
            InitializeComponent();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // check add or edit = ""
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "برجاء ادخال البيانات كامله لعملية الشراء";
                dialog.Show();
            }
            else
            {
                // check add or edit 
                if (id == 0)
                {
                    // Add
                    
                    tb_pur.Pur_Name = edt_name.Text;
                    tb_pur.Pur_Type = edt_Type.Text;
                    tb_pur.Pur_Cat =  comboBox1.Text;
                    tb_pur.Pur_Supp =  comboBox2.Text;
                    tb_pur.Pur_Det = edt_Det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    db.TB_Purchases.Add(tb_pur);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اجراء اضافه عمليه شراء بنجاح  ";
                    toast.Show();
                    this.Close();

                }
                else
                {
                    // edit
                    tb_pur.ID = this.id;
                    tb_pur.Pur_Name = edt_name.Text;
                    tb_pur.Pur_Type = edt_Type.Text;
                    tb_pur.Pur_Cat = comboBox1.Text;
                    tb_pur.Pur_Supp = comboBox2.Text;
                    tb_pur.Pur_Det = edt_Det.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(textEdit1.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                    //frm_pur.gridControl1.DataSource = db.TB_Purchases.ToList();
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اجراء تعديل لعمليه الشراء بنجاح ";
                    toast.Show();
                    this.Close();

                    /*
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edt_name.Text;

                    tb_supp.Supp_Image = methods.convert_byte();
                    // tb_supp.ID = this.id;
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل المورد ";
                    toast.Show();
                    //db = new Sales_Management_SystemEntities1();
                    //frm_supp.gridControl1.DataSource = db.TB_Suppliers.ToList();
                    this.Close();
                    */
                }
            }


        }

        

        private void FFRM_Purchases_ADD_Activated(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            comboBox2.DataSource = db.TB_Suppliers.Select(x => x.Supp_Name).ToList();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentation_Layer.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentation_Layer.FFRM_SUPP_ADD frm_add = new FFRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();
        }
        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }
        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }
        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_call();
        }
        private void pro_call()
        {
            int val1; 
            int val2;
            bool result1 = int.TryParse(edt_sell.Text, out val1);
            bool result2 = int.TryParse(edt_buy.Text, out val2);
            if (result1)
            {
                sell = Convert.ToDouble(val1);
            }
            else
            {
                Console.WriteLine("This is C# 1");
            }
            if (result2)
            {
                buy = Convert.ToDouble(val2);
            }
            else
            {
                Console.WriteLine("This is C# 2");
            }

            
            qt = Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            edt_tsell.Text = tsell.ToString();
            edt_tbuy.Text = tbuy.ToString();
            edt_trev.Text = trev.ToString();



        }

    }
}

