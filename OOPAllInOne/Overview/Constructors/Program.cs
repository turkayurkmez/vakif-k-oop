// See https://aka.ms/new-console-template for more information
using Constructors;

Console.WriteLine("Hello, World!");

Report report = new Report("C:\\document.xlsx");
report.Title = "2023 Maaliyet Raporu";



Report report1 = new Report(path: "C:\\", title: "Çalışan Performansı 2023");
Report report2 = new Report("...") { Title = "Aylık rapor", Format = "PDF" };
Report report3 = new Report() { Format = ".docx", Title = "Sample", Path = "E:\\" };
