<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApp_RegularDataSourceKPI/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApp_RegularDataSourceKPI/Form1.vb))
<!-- default file list end -->
# How to display KPI graphics in PivotGridControl bound to a regular data source


<p>The following example shows how to display KPI graphics in <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraPivotGridPivotGridControltopic">PivotGridControl</a> bound to a regular data source.</p>
<p>The <strong>PivotGridControl</strong> is bound to the "Sales Person" view in the Northwind database. To display KPI graphics, we create an unbound field whose values correspond to images contained within a KPI graphic set.</p>
<p>In this example, the unbound field values depend on the "Extended Price" field values: if the "Extended Price" field value is less than 100000, the unbound field value is "-1", if the "Extended Price" field value is less than 150000, the unbound field value is "0". In other cases, the unbound field value is "1".</p>
<p>The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridOptionsData_DataFieldUnboundExpressionModetopic">DataFieldUnboundExpressionMode</a> property is set to <strong>DataFieldUnboundExpressionMode.UseSummaryValues</strong> to calculate unbound expressions for data fields against summary values. The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_KPIGraphictopic">KPIGraphic</a>  property specifies a graphic set used to visualize unbound field values.</p>

<br/>


