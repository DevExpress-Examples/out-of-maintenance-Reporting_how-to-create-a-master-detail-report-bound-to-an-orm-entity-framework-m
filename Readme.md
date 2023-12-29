<!-- default file list -->
*Files to look at*:

* **[HomeController.cs](./CS/E5059/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5059/Controllers/HomeController.vb))**
* [CategoryProductsReport.cs](./CS/E5059/Reports/CategoryProductsReport.cs) (VB: [CategoryProductsReport.vb](./VB/E5059/Reports/CategoryProductsReport.vb))
* [_DocumentViewerPartial.cshtml](./CS/E5059/Views/Home/_DocumentViewerPartial.cshtml)
* [Index.cshtml](./CS/E5059/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to create a master-detail report bound to an ORM (Entity Framework) model in MVC applications


<p>This example demonstrates how to create a master-detail report bound to Object Relational Model in ASP.NET MVC applications.</p><p>This example uses the Entity Framework ORM model to provide a report with data, but you can use any object model instead.</p><p>Bind your XtraReport to your model master class by using the approach suggested in the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5194/BindingSource"><u>Providing Data to a Web Report => Design-Time Data Binding Using BindingSource</u></a> help topic. After your report is bound to the master class you can easily insert a detail report band by using the context menu in the report designer, as shown below:<br />
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-master-detail-report-bound-to-an-orm-entity-framework-model-in-mvc-applicati-e5059/14.2.3+/media/0bbb7d38-57bd-4c62-a7c9-9b4fe5f53d65.png"></p><p><strong>FAQ:</strong></p><p><strong>- Why does the </strong><strong><i>"Data binding directly to a store query (DbSet, DbQuery, DbSqlQuery) is not supported. Instead populate a DbSet with data, for example by calling Load on the DbSet, and then bind to local data."</i></strong><strong> exception occur?<br />
</strong>This example uses <strong>Entity Framework 4</strong> so you can easily bind the report to the query result. However note that <strong>starting with Entity Framework 4.1</strong> you can not bind components to queries, so you need to convert your query to the List and then bind your report to this List. Use the following code for this purpose:</p>

```cs
report.DataSource = (from category in DataContext.Categories
                        select category).ToList();

```

<p> </p>

```vb
report.DataSource = _
    (From category In DataContext.Categories _
     Select category).ToList()

```

<p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E5023">How to bind a report displayed in the DocumentViewer extension to the model's data</a></p>

<br/>


