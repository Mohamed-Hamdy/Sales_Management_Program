
namespace Sales_Management_Program.Presentation_Layer
{
    partial class FFRM_USERS_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_USERS_ADD));
            this.pnadd_cont = new System.Windows.Forms.Panel();
            this.edt_Roll = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnadd_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnadd_cont
            // 
            this.pnadd_cont.Controls.Add(this.edt_Roll);
            this.pnadd_cont.Controls.Add(this.label5);
            this.pnadd_cont.Controls.Add(this.edt_password);
            this.pnadd_cont.Controls.Add(this.label2);
            this.pnadd_cont.Controls.Add(this.label1);
            this.pnadd_cont.Controls.Add(this.simpleButton2);
            this.pnadd_cont.Controls.Add(this.pic_cover);
            this.pnadd_cont.Controls.Add(this.edt_name);
            this.pnadd_cont.Controls.Add(this.label4);
            this.pnadd_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnadd_cont.Location = new System.Drawing.Point(0, 0);
            this.pnadd_cont.Name = "pnadd_cont";
            this.pnadd_cont.Size = new System.Drawing.Size(859, 511);
            this.pnadd_cont.TabIndex = 0;
            // 
            // edt_Roll
            // 
            this.edt_Roll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_Roll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.edt_Roll.FormattingEnabled = true;
            this.edt_Roll.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.edt_Roll.Location = new System.Drawing.Point(386, 328);
            this.edt_Roll.Name = "edt_Roll";
            this.edt_Roll.Size = new System.Drawing.Size(271, 33);
            this.edt_Roll.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(245, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 49);
            this.label5.TabIndex = 25;
            this.label5.Text = "  صفحه اضافه مستخدم ";
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(386, 257);
            this.edt_password.Name = "edt_password";
            this.edt_password.PasswordChar = '*';
            this.edt_password.Size = new System.Drawing.Size(271, 38);
            this.edt_password.TabIndex = 23;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(721, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "الرقم السري";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(749, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "الصلاحية";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(0, 441);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(859, 70);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "اضافة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(12, 153);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(332, 269);
            this.pic_cover.TabIndex = 17;
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(386, 187);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(271, 38);
            this.edt_name.TabIndex = 16;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(710, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "اسم المستخدم";
            // 
            // FFRM_USERS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 511);
            this.Controls.Add(this.pnadd_cont);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFRM_USERS_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFRM_CAT_ADD_Load);
            this.pnadd_cont.ResumeLayout(false);
            this.pnadd_cont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnadd_cont;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox edt_Roll;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.Label label1;
    }
}