namespace Constructors
{
    public class Report
    {
        public string Title { get; set; }
        public string Format { get; set; }
        public string Path { get; set; }

        public Report() : this(path: string.Empty)
        {

        }

        public Report(string path) : this(path, title: "No Title")
        {
            //Path = path;
            //initializeDefaults();
        }

        public Report(string path, string title)
        {
            Path = path;
            Title = title;
            Format = "PDF";
            initializeDefaults();
        }

        private void initializeDefaults()
        {
            Console.WriteLine("Varsayılan rapor ayarları yapılıyor...");
            Console.WriteLine($"Başlık:{Title}, Adres: {Path}");
        }
    }
}
