namespace WindowsFormsApp_RegularDataSourceKPI
{
    partial class Form1
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet = new WindowsFormsApp_RegularDataSourceKPI.nwindDataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new WindowsFormsApp_RegularDataSourceKPI.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName1,
            this.fieldExtendedPrice1,
            this.fieldSalesPerson1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(383, 292);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            this.fieldCategoryName1.Width = 178;
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 292);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
    }
}

