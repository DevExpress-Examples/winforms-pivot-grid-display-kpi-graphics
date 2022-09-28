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
            ' Binds the pivot grid to data.
            salesPersonTableAdapter.Fill(nwindDataSet.SalesPerson)
            ' Specifies that unbound expressions for data fields are calculated against summary values.
            pivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DataFieldUnboundExpressionMode.UseSummaryValues
            ' Creates a new unbound "Status" field to show KPI values.
            Dim unboundField As PivotGridField = pivotGridControl1.Fields.Add("Status", PivotArea.DataArea)
            ' Sets a column's unbound type and specifies an unbound expression.
            unboundField.UnboundType = DevExpress.Data.UnboundColumnType.Integer
            unboundField.UnboundExpression = String.Format("(Iif([{0}]<100000,-1,Iif([{0}]<150000,0,1)))", fieldExtendedPrice1.ExpressionFieldName)
            ' Sets the Data Header Area within which the "Status" Field can be positioned.
            unboundField.AllowedAreas = PivotGridAllowedAreas.DataArea
            ' Specifies a graphic set used to indicate KPI values.
            unboundField.KPIGraphic = PivotKPIGraphic.Faces
        End Sub
    End Class
End Namespace
