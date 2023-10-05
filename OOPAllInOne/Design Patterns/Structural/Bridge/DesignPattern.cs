namespace Bridge
{
    public class Report
    {
        public string Title { get; set; }
        public Format ReportFormat { get; set; }

    }

    public class SalesReport : Report
    {

    }

    public class PerformansReport : Report
    {

    }


    public class Format
    {
        public string Type { get; set; }
    }



    public class PDFFormat : Format { }
    public class ExcelFormat : Format { }
    public class HtmlFormat : Format { }

}
