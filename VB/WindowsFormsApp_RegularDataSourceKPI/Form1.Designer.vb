Namespace WindowsFormsApp_RegularDataSourceKPI

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New WindowsFormsApp_RegularDataSourceKPI.nwindDataSet()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter = New WindowsFormsApp_RegularDataSourceKPI.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldSalesPerson})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(383, 292)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            dataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = dataSourceColumnBinding1
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 178
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            dataSourceColumnBinding2.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding2
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.Caption = "Sales Person"
            dataSourceColumnBinding3.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = dataSourceColumnBinding3
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            ' 
            ' salesPersonTableAdapter
            ' 
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(383, 292)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private nwindDataSet As WindowsFormsApp_RegularDataSourceKPI.nwindDataSet

        Private salesPersonBindingSource As System.Windows.Forms.BindingSource

        Private salesPersonTableAdapter As WindowsFormsApp_RegularDataSourceKPI.nwindDataSetTableAdapters.SalesPersonTableAdapter

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
