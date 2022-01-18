using System;

namespace OopInheritance
{
    public class ExcelFile : File
    {
        public ExcelFile(string name, string excelVersion) 
            : base(name, "xslx")
        {
            this.ExcelVersion = excelVersion;
        }

        public string ExcelVersion
        {
            get;
        }

        public void PerformCalculation(string formula)
        {
            Console.WriteLine($"Calculating formula '{formula}' on file '{this.Name}.{this.Extension}' open in {this.ExcelVersion}");
        }
    }
}
