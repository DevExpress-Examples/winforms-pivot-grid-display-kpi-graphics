using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsFormsApp_RegularDataSourceKPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Specifies that unbound expressions for data fields are calculated against summary values.
            pivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = 
                DataFieldUnboundExpressionMode.UseSummaryValues;

            // Creates a new unbound "Status" field to show KPI values.
            PivotGridField unboundField = pivotGridControl1.Fields.Add("Status", PivotArea.DataArea);

            // Sets a column's unbound type and specifies an unbound expression.
            unboundField.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            unboundField.UnboundExpression = 
                string.Format("(Iif([{0}]<100000,-1,Iif([{0}]<150000,0,1)))", 
                fieldExtendedPrice1.ExpressionFieldName);

            // Sets the Data Header Area within which the "Status" Field can be positioned.
            unboundField.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;

            // Specifies a graphic set used to indicate KPI values.
            unboundField.KPIGraphic = PivotKPIGraphic.Faces;

        }
    }
}
