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

            // Creates a new unbound "Status" field to show KPI values.
            PivotGridField unboundField = pivotGridControl1.Fields.Add();
            unboundField.Area = PivotArea.DataArea;

            // Sets a column's unbound type and specifies an unbound expression.
            unboundField.DataBinding = new ExpressionDataBinding(
                string.Format("(Iif(Sum([{0}])<100000,-1,Iif(Sum([{0}])<150000,0,1)))", 
                fieldExtendedPrice.ExpressionFieldName));

            // Sets the Data Header Area within which the "Status" Field can be positioned.
            unboundField.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;

            // Specifies a graphic set used to indicate KPI values.
            unboundField.KPIGraphic = PivotKPIGraphic.Faces;

        }
    }
}
