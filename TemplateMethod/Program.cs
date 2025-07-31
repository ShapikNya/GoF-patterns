using TemplateMethod.Classes;

Console.WriteLine("Создание отчёта по продажам");
SalesReportGenerator salesReport = new();
salesReport.GenerateReport();

Console.WriteLine("Создание отчёта по складу");
InventoryReportGenerator inventoryReport = new();
inventoryReport.GenerateReport();