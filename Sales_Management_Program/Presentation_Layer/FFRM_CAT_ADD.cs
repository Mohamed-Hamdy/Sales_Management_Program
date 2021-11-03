﻿using System;
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
    public partial class FFRM_CAT_ADD : Form
    {

        // init


        Business_Layer.Methods methods = new Business_Layer.Methods();
        Toast toast = new Toast();
        Dialog dialog = new Dialog();
        TB_CAT tb_cat = new TB_CAT();
        public int id;
        Sales_Management_SystemEntities1 db = new Sales_Management_SystemEntities1();
        Presentation_Layer.FRM_CAT frm_cat = new Presentation_Layer.FRM_CAT();

        public FFRM_CAT_ADD()
        {
            InitializeComponent();
        }

        /*
        private void FFRM_CAT_ADD_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        */
        private void btn_add_Click(object sender, EventArgs e)
        {
            // check add or edit = ""
           if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
                
                
            }
            else
            {
                // check add or edit 
                if(id == 0)
                {
                    // Add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه عنصر جديد";
                    toast.Show();
                    db = new Sales_Management_SystemEntities1();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();

                    this.Close();

                }
                else
                {
                    // edit
                }
            }

           
        }

        private void FFRM_CAT_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
