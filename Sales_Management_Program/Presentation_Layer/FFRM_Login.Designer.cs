
namespace Sales_Management_Program.Presentation_Layer
{
    partial class FFRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_Login));
            this.pn_cont = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup_btn = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cont
            // 
            this.pn_cont.Controls.Add(this.Signup_btn);
            this.pn_cont.Controls.Add(this.simpleButton1);
            this.pn_cont.Controls.Add(this.pic_cover);
            this.pn_cont.Controls.Add(this.label2);
            this.pn_cont.Controls.Add(this.edt_password);
            this.pn_cont.Controls.Add(this.label1);
            this.pn_cont.Controls.Add(this.simpleButton2);
            this.pn_cont.Controls.Add(this.edt_username);
            this.pn_cont.Controls.Add(this.label4);
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 0);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(632, 631);
            this.pn_cont.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(590, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(39, 38);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(148, 103);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(306, 214);
            this.pic_cover.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(170, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 63);
            this.label2.TabIndex = 22;
            this.label2.Text = "تسجيل الدخول";
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.edt_password.Location = new System.Drawing.Point(74, 444);
            this.edt_password.Multiline = true;
            this.edt_password.Name = "edt_password";
            this.edt_password.PasswordChar = '*';
            this.edt_password.Size = new System.Drawing.Size(329, 40);
            this.edt_password.TabIndex = 21;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(491, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "كلمة السر";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(35, 558);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(267, 70);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "تسجيل الدخول";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // edt_username
            // 
            this.edt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.edt_username.Location = new System.Drawing.Point(74, 353);
            this.edt_username.Multiline = true;
            this.edt_username.Name = "edt_username";
            this.edt_username.Size = new System.Drawing.Size(329, 40);
            this.edt_username.TabIndex = 16;
            this.edt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_username.TextChanged += new System.EventHandler(this.edt_sv_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(455, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "اسم المستخدم";
            // 
            // Signup_btn
            // 
            this.Signup_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Signup_btn.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Signup_btn.Appearance.Options.UseFont = true;
            this.Signup_btn.Appearance.Options.UseForeColor = true;
            this.Signup_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.Signup_btn.Location = new System.Drawing.Point(331, 558);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(267, 70);
            this.Signup_btn.TabIndex = 24;
            this.Signup_btn.Text = "انشاء حساب";
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // FFRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 631);
            this.ControlBox = false;
            this.Controls.Add(this.pn_cont);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFRM_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFRM_Login_Load);
            this.pn_cont.ResumeLayout(false);
            this.pn_cont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cont;
        public System.Windows.Forms.TextBox edt_username;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton Signup_btn;
    }
}