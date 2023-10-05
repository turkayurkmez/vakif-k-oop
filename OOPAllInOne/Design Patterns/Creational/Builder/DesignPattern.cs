namespace Builder
{
    public class Report
    {
        /*
		 * Raporun başlığı
		 * Çekilecek veri
		 * Grafiklerin oluşturulması
		 * Raporu hazırlayanlar
		 * Ekler
		 * * 
		 */
        public string Title { get; set; }
        public string Data { get; set; }
        public string GraphType { get; set; }
        public string Owners { get; set; }

        public override string ToString()
        {
            return $"{Title} isimli raporun verisi: {Data}, grafik tipi {GraphType} ve imzası: {Owners}";
        }

    }

    public interface IReportBuilder
    {
        void GetData();
        void CreateGraphics();

        void CreateSigns();

        Report Report { get; }

    }

    public abstract class FromDbReportBuilder : IReportBuilder
    {
        public Report Report { get; protected set; }

        public abstract void CreateGraphics();

        public abstract void CreateSigns();

        public abstract void GetData();

    }

    public class PerformanceReportBuilder : FromDbReportBuilder
    {
        public PerformanceReportBuilder()
        {
            Report = new Report();

        }

        public override void CreateGraphics()
        {
            Report.GraphType = "Bar grafiği";
            Console.WriteLine("Bar grafiği çizildi");
        }

        public override void CreateSigns()
        {
            Report.Owners = "Türkay Ürkmez";
            Console.WriteLine("Departman yöneticilerinin isimleri çekildi.");
        }

        public override void GetData()
        {
            Report.Data = "Oğuzhan Arslan, tam performans gösterdi...";
            Console.WriteLine("db'den veriler çekildi...");

        }
    }

    public class ReportCreator
    {
        public IReportBuilder ReportBuilder { get; set; }

        public Report BuildReport()
        {
            ReportBuilder.GetData();
            ReportBuilder.CreateGraphics();
            ReportBuilder.CreateSigns();
            return ReportBuilder.Report;
        }

    }


}
