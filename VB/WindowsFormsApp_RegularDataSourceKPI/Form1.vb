Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsFormsApp_RegularDataSourceKPI

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Binds the Pivot Grid to data.
            salesPersonTableAdapter.Fill(nwindDataSet.SalesPerson)
            ' Creates a new "Status" field to show KPI values.
            Dim KPIField As PivotGridField = pivotGridControl1.Fields.Add()
            KPIField.Area = PivotArea.DataArea
            KPIField.Caption = "Status"
            ' Sets a column's data binding and specifies an expression.
            KPIField.DataBinding = New ExpressionDataBinding(String.Format("(Iif(Sum([{0}])<100000,-1,Iif(Sum([{0}])<150000,0,1)))", fieldExtendedPrice.ExpressionFieldName))
            ' Sets the Data Header Area within which the "Status" Field can be positioned.
            KPIField.AllowedAreas = PivotGridAllowedAreas.DataArea
            ' Specifies a graphic set used to indicate KPI values.
            KPIField.KPIGraphic = PivotKPIGraphic.Faces
        End Sub
    End Class
End Namespace
