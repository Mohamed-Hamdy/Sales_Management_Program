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
    public partial class FFRM_Sells_ADD: Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_Purchases tb_pur = new TB_Purchases();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        FFRM_Sells frm_sales = new FFRM_Sells();
        TB_Sales tb_sales = new TB_Sales();

        double qt_previuos, qt_new, qt_requirement , ToTal_price_var;
        
        public FFRM_Sells_ADD()
        {
            InitializeComponent();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            qt_previuos = Convert.ToDouble(edt_tqt.Text);
            qt_new = Convert.ToDouble(edt_qt.Text);
            qt_requirement = qt_previuos - qt_new ;
            // check add or edit = ""
            if (comboBox1.Text == "")
            {
                /*
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
                */
                
                toast.txt_caption.Text = "اسم الماده مطلوب";
                toast.Show();
                this.Close();
                Presentation_Layer.FFRM_Sells_ADD frm_add = new FFRM_Sells_ADD();
                frm_add.id = 0;
                frm_add.simpleButton2.Text = "اضافه";
                frm_add.Show();
                
            }
            else
            {
                // check add or edit 
                if (id == 0)
                {
                    if(qt_requirement > 0)
                    {
                        
                        tb_sales.Sell_Name = comboBox1.Text;
                        tb_sales.Sell_Cus = comboBox2.Text;

                        tb_sales.Sell_Price = Convert.ToDouble(edt_sell.Text);
                        tb_sales.Sell_QT = Convert.ToDouble(edt_qt.Text);

                        tb_sales.Sell_TPrice = (Convert.ToDouble(edt_qt.Text)) * Convert.ToDouble(edt_sell.Text);
                        

                        tb_sales.Sell_Date = DateTime.Now;
                        db.TB_Sales.Add(tb_sales);
                        tb_pur.Pur_Qt = qt_requirement;
                        db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        
                        toast.txt_caption.Text = "تم اجراء اضافه عمليه بيع بنجاح  ";
                        toast.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        NotEnouph_label.Visible = true;
                    }
                    // Add
                    

                }
                else
                {
                    // NO EDIT PROCESS IN SALES PAGE
                }
            }


        }



        private void FFRM_Purchases_ADD_Activated(object sender, EventArgs e)
        {
            var res1 = db.TB_Purchases.Select(x => x.Pur_Name).ToList();
            var res2 = db.TB_Customers.Select(x => x.Cust_Name).ToList();

            comboBox1.DataSource = res1;
            comboBox2.DataSource = res2;

            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();

            ACSC1.AddRange(res1.ToArray());
            ACSC2.AddRange(res2.ToArray());

            comboBox1.AutoCompleteCustomSource = ACSC1;
            comboBox2.AutoCompleteCustomSource = ACSC2;

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentation_Layer.FFRM_Purchases_ADD frm_add = new FFRM_Purchases_ADD();
            frm_add.id = 0;
            frm_add.simpleButton2.Text = "اضافه";
            frm_add.Show();
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentation_Layer.FFRM__Customers_ADD frm_add = new FFRM__Customers_ADD();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            edt_sell.Enabled = true;
        }

        private void pro_call()
        {
            /*
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
            */


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_Purchases.Where(x => x.Pur_Name == comboBox1.Text).FirstOrDefault();
            edt_tbuy.Text = tb_pur.Pur_Buy.ToString();
            edt_tsell.Text = tb_pur.Pur_Sell.ToString();
            edt_tqt.Text = tb_pur.Pur_Qt.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
            Total_price.Text = ((Convert.ToDouble(edt_qt.Text)) * Convert.ToDouble(edt_sell.Text)).ToString();

        }
    }
}

