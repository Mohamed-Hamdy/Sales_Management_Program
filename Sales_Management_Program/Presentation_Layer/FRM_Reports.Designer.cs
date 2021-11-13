
namespace Sales_Management_Program.Presentation_Layer
{
    partial class FRM_Reports
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAT_Cover = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.flow_pn_cont = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_purchases = new DevExpress.XtraEditors.SimpleButton();
            this.btn_customers = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.pn_cat.SuspendLayout();
            this.flow_pn_cont.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // colCAT_Cover
            // 
            this.colCAT_Cover.FieldName = "CAT_Cover";
            this.colCAT_Cover.Name = "colCAT_Cover";
            this.colCAT_Cover.Visible = true;
            this.colCAT_Cover.VisibleIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCAT_Name
            // 
            this.colCAT_Name.FieldName = "CAT_Name";
            this.colCAT_Name.Name = "colCAT_Name";
            this.colCAT_Name.Visible = true;
            this.colCAT_Name.VisibleIndex = 1;
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.flow_pn_cont);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(884, 685);
            this.pn_cat.TabIndex = 0;
            // 
            // flow_pn_cont
            // 
            this.flow_pn_cont.Controls.Add(this.btn_sales);
            this.flow_pn_cont.Controls.Add(this.btn_purchases);
            this.flow_pn_cont.Controls.Add(this.btn_customers);
            this.flow_pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_pn_cont.Location = new System.Drawing.Point(0, 0);
            this.flow_pn_cont.Margin = new System.Windows.Forms.Padding(20);
            this.flow_pn_cont.Name = "flow_pn_cont";
            this.flow_pn_cont.Padding = new System.Windows.Forms.Padding(45, 20, 20, 20);
            this.flow_pn_cont.Size = new System.Drawing.Size(884, 685);
            this.flow_pn_cont.TabIndex = 0;
            // 
            // btn_sales
            // 
            this.btn_sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sales.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btn_sales.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_sales.Appearance.Options.UseFont = true;
            this.btn_sales.Appearance.Options.UseForeColor = true;
            this.btn_sales.Location = new System.Drawing.Point(65, 70);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(699, 150);
            this.btn_sales.TabIndex = 20;
            this.btn_sales.Text = "تقرير المبيعات";
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_purchases
            // 
            this.btn_purchases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_purchases.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btn_purchases.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_purchases.Appearance.Options.UseFont = true;
            this.btn_purchases.Appearance.Options.UseForeColor = true;
            this.btn_purchases.Location = new System.Drawing.Point(65, 260);
            this.btn_purchases.Margin = new System.Windows.Forms.Padding(20);
            this.btn_purchases.Name = "btn_purchases";
            this.btn_purchases.Size = new System.Drawing.Size(699, 150);
            this.btn_purchases.TabIndex = 22;
            this.btn_purchases.Text = "تقرير المشتريات";
            this.btn_purchases.Click += new System.EventHandler(this.btn_purchases_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_customers.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btn_customers.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_customers.Appearance.Options.UseFont = true;
            this.btn_customers.Appearance.Options.UseForeColor = true;
            this.btn_customers.Location = new System.Drawing.Point(65, 450);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(20);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(702, 150);
            this.btn_customers.TabIndex = 24;
            this.btn_customers.Text = "تقرير العملاء";
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // FRM_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 685);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Reports";
            this.Text = "FRM_CAT";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.pn_cat.ResumeLayout(false);
            this.flow_pn_cont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Cover;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCAT_Name;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.FlowLayoutPanel flow_pn_cont;
        public DevExpress.XtraEditors.SimpleButton btn_sales;
        public DevExpress.XtraEditors.SimpleButton btn_purchases;
        public DevExpress.XtraEditors.SimpleButton btn_customers;
    }
}