// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

/*
 * Problem: Bir inheritance akışı, eğer hatalı tasarlanırsa; gelecekteki olası geliştirmeleri kısıtlar. Bu kısıtın önüne nasıl geçersiniz?
 * 
 * Senaryo:
 *   Bir rapor üretim uygulaması geliştiriyorsunuz. Rapor formatı şu an için iki (PDF, Excel) olmasına rağmen; gelecekte çeşitlenebilir.
 */

var pdfFormat = new PDFFormat();
var excelFormat = new ExcelFormat();


var salesReport = new SalesReport();
salesReport.ReportFormat = pdfFormat;




