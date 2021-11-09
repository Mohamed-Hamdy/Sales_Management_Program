
namespace Sales_Management_Program.EPL
{
    partial class Dialog
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_caption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_caption
            // 
            this.txt_caption.BackColor = System.Drawing.Color.White;
            this.txt_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_caption.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_caption.Location = new System.Drawing.Point(0, 0);
            this.txt_caption.Name = "txt_caption";
            this.txt_caption.Size = new System.Drawing.Size(450, 100);
            this.txt_caption.TabIndex = 8;
            this.txt_caption.Text = "الرسالة";
            this.txt_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_caption.Click += new System.EventHandler(this.txt_caption_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 100);
            this.Controls.Add(this.txt_caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label txt_caption;
    }
}