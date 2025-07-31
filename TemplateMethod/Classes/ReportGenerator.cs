using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    public abstract class ReportGenerator
    {
        protected StringBuilder _data = new();
        public void GenerateReport()
        {
            PrepareData(); FormatData(); SaveToFile();
        }
        protected abstract void PrepareData();
        protected abstract void FormatData();
        protected abstract void SaveToFile();
    }
}
