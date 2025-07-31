using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    public class InventoryReportGenerator : ReportGenerator
    {
        private readonly string _filePath = @"C:\InventoryReport.txt";
        protected override void PrepareData()
        {
            _data.AppendLine("---Товары на складе---");
        }

        protected override void FormatData()
        {
            _data.AppendLine("1. Формат данных - тестовый");
        }

        protected override void SaveToFile()
        {
            File.WriteAllText(_filePath, _data.ToString());
        }
    }
}
