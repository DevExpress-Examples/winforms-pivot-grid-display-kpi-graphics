Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsFormsApp_RegularDataSourceKPI
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Binds the pivot grid to data.
            Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

            ' Creates a new unbound "Status" field to show KPI values.
            Dim unboundField As PivotGridField = pivotGridControl1.Fields.Add("Status", _
                                                                              PivotArea.DataArea)
            ' Sets a column's unbound type and specifies an unbound expression.
            unboundField.DataBinding = New ExpressionDataBinding(
                String.Format("(Iif(Sum([{0}])<100000,-1,Iif(Sum([{0}])<150000,0,1)))",
                fieldExtendedPrice.ExpressionFieldName))

            ' Sets the Data Header Area within which the "Status" Field can be positioned.
            unboundField.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea

            ' Specifies a graphic set used to indicate KPI values.
            unboundField.KPIGraphic = PivotKPIGraphic.Faces

        End Sub
    End Class
End Namespace
