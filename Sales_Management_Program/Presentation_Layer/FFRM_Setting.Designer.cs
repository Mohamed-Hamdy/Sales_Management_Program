
namespace Sales_Management_Program.Presentation_Layer
{
    partial class FFRM_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_Setting));
            this.pn_cont = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_sv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_cont.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cont
            // 
            this.pn_cont.Controls.Add(this.simpleButton2);
            this.pn_cont.Controls.Add(this.edt_sv);
            this.pn_cont.Controls.Add(this.label4);
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 0);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(664, 561);
            this.pn_cont.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(488, 479);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 70);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "حفظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // edt_sv
            // 
            this.edt_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.edt_sv.Location = new System.Drawing.Point(99, 218);
            this.edt_sv.Name = "edt_sv";
            this.edt_sv.Size = new System.Drawing.Size(359, 31);
            this.edt_sv.TabIndex = 16;
            this.edt_sv.Text = "DESKTOP-OA5Q44B\\SQLEXPRESS";
            this.edt_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sv.TextChanged += new System.EventHandler(this.edt_sv_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(519, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "السيرفر";
            // 
            // FFRM_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 561);
            this.Controls.Add(this.pn_cont);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFRM_Setting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pn_cont.ResumeLayout(false);
            this.pn_cont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cont;
        public System.Windows.Forms.TextBox edt_sv;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}