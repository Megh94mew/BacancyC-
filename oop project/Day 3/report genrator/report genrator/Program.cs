using System;

#region Abstract Base Class
public abstract class ReportGenerator
{
    public abstract void GenerateReport();

    public void LogReport()
    {
        Console.WriteLine("Report generation started...");
    }
}
#endregion

#region PDF Report 
public class PDFReport : ReportGenerator
{
    public override void GenerateReport()
    {
        Console.WriteLine("Generating PDF Report...");
    }
}
#endregion

#region Excel Report 
public class ExcelReport : ReportGenerator
{
    public override void GenerateReport()
    {
        Console.WriteLine("Generating Excel Report...");
    }
}
#endregion

class Program
{
    static void Main()
    {
        ReportGenerator pdf = new PDFReport();
        ReportGenerator excel = new ExcelReport();

        pdf.LogReport();
        pdf.GenerateReport();

        Console.WriteLine();

        excel.LogReport();
        excel.GenerateReport();
    }
}