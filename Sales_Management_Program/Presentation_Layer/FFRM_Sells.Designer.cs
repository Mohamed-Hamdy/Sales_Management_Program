
namespace Sales_Management_Program.Presentation_Layer
{
    partial class FFRM_Sells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_Sells));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAT_Cover = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCAT_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sales_Management_SystemDataSet4 = new Sales_Management_Program.Sales_Management_SystemDataSet4();
            this.tBSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_SalesTableAdapter = new Sales_Management_Program.Sales_Management_SystemDataSet4TableAdapters.TB_SalesTableAdapter();
            this.colSell_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_QT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_TPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.pn_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_Management_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSalesBindingSource)).BeginInit();
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
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Controls.Add(this.panel2);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(884, 685);
            this.pn_cat.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBSalesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView5;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(884, 589);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSell_Name,
            this.colSell_Cus,
            this.colSell_Price,
            this.colSell_QT,
            this.colSell_TPrice,
            this.colSell_Date});
            this.gridView5.GridControl = this.gridControl1;
            this.gridView5.Name = "gridView5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.simpleButton6);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 96);
            this.panel2.TabIndex = 20;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.Location = new System.Drawing.Point(814, 28);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(58, 49);
            this.simpleButton6.TabIndex = 11;
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(531, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 38);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(337, 24);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 56);
            this.simpleButton4.TabIndex = 9;
            this.simpleButton4.Text = "تحديث";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(195, 25);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(136, 56);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "حذف";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(42, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 57);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "اضافه";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sales_Management_SystemDataSet4
            // 
            this.sales_Management_SystemDataSet4.DataSetName = "Sales_Management_SystemDataSet4";
            this.sales_Management_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBSalesBindingSource
            // 
            this.tBSalesBindingSource.DataMember = "TB_Sales";
            this.tBSalesBindingSource.DataSource = this.sales_Management_SystemDataSet4;
            // 
            // tB_SalesTableAdapter
            // 
            this.tB_SalesTableAdapter.ClearBeforeFill = true;
            // 
            // colSell_Name
            // 
            this.colSell_Name.Caption = "اسم الماده";
            this.colSell_Name.FieldName = "Sell_Name";
            this.colSell_Name.Name = "colSell_Name";
            this.colSell_Name.Visible = true;
            this.colSell_Name.VisibleIndex = 0;
            // 
            // colSell_Cus
            // 
            this.colSell_Cus.Caption = "اسم العميل";
            this.colSell_Cus.FieldName = "Sell_Cus";
            this.colSell_Cus.Name = "colSell_Cus";
            this.colSell_Cus.Visible = true;
            this.colSell_Cus.VisibleIndex = 1;
            // 
            // colSell_Price
            // 
            this.colSell_Price.Caption = "سعر الماده";
            this.colSell_Price.FieldName = "Sell_Price";
            this.colSell_Price.Name = "colSell_Price";
            this.colSell_Price.Visible = true;
            this.colSell_Price.VisibleIndex = 2;
            // 
            // colSell_QT
            // 
            this.colSell_QT.Caption = "الكمية";
            this.colSell_QT.FieldName = "Sell_QT";
            this.colSell_QT.Name = "colSell_QT";
            this.colSell_QT.Visible = true;
            this.colSell_QT.VisibleIndex = 3;
            // 
            // colSell_TPrice
            // 
            this.colSell_TPrice.Caption = "السعر الكلى ";
            this.colSell_TPrice.FieldName = "Sell_TPrice";
            this.colSell_TPrice.Name = "colSell_TPrice";
            this.colSell_TPrice.Visible = true;
            this.colSell_TPrice.VisibleIndex = 4;
            // 
            // colSell_Date
            // 
            this.colSell_Date.Caption = "التاريخ";
            this.colSell_Date.FieldName = "Sell_Date";
            this.colSell_Date.Name = "colSell_Date";
            this.colSell_Date.Visible = true;
            this.colSell_Date.VisibleIndex = 5;
            // 
            // FFRM_Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 685);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFRM_Sells";
            this.Text = "FRM_CAT";
            this.Load += new System.EventHandler(this.FRM_CAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.pn_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_Management_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSalesBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.TextBox textBox2;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private Sales_Management_SystemDataSet4 sales_Management_SystemDataSet4;
        private System.Windows.Forms.BindingSource tBSalesBindingSource;
        private Sales_Management_SystemDataSet4TableAdapters.TB_SalesTableAdapter tB_SalesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Cus;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_QT;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_TPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Date;
    }
}