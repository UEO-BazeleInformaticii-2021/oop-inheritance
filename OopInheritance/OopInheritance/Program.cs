using System;

namespace OopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile("Paycheck", "Excel 2019");
            PdfFile pdfFileNonEditable = new PdfFile("Book Abc", false);
            PdfFile pdfFileEditable = new PdfFile("Declaratie pe proprie raspundere", true);
            File genericFile = new File("test", "txt");

            File[] files = new File[]
            {
                excelFile,
                pdfFileNonEditable,
                pdfFileEditable,
                genericFile
            };

            foreach (File file in files)
            {
                file.Open();
            }

            excelFile.PerformCalculation("A2 = B2 + C2");

            pdfFileNonEditable.AttemptEdit();
            pdfFileEditable.AttemptEdit();
        }
    }
}
