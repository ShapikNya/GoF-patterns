using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    public class SalesReportGenerator : ReportGenerator
    {
        private readonly string _filePath = @"C:\InventoryReport.txt";
        protected override void PrepareData()
        {
            _data.AppendLine("---Отчёт по продажам---");
        }

        protected override void FormatData()
        {
            _data.AppendLine("1. Формат данных - стандартный");
        }

        protected override void SaveToFile ()
        {
            File.WriteAllText(_filePath, _data.ToString());
        }
    }
}
