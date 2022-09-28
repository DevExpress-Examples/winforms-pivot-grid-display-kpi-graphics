using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsFormsApp_RegularDataSourceKPI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Binds the Pivot Grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Creates a new "Status" field to show KPI values.
            PivotGridField KPIField = pivotGridControl1.Fields.Add();
            KPIField.Area = PivotArea.DataArea;
            KPIField.Caption = "Status";

            // Sets a column's data binding and specifies an expression.
            KPIField.DataBinding = new ExpressionDataBinding(
                string.Format("(Iif(Sum([{0}])<100000,-1,Iif(Sum([{0}])<150000,0,1)))", 
                fieldExtendedPrice.ExpressionFieldName));

            // Sets the Data Header Area within which the "Status" Field can be positioned.
            KPIField.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;

            // Specifies a graphic set used to indicate KPI values.
            KPIField.KPIGraphic = PivotKPIGraphic.Faces;
        }
    }
}
