// See https://aka.ms/new-console-template for more information
using AbstractANDInteerface;

Console.WriteLine("Hello, World!");
ExcelDocument excelDocument = new ExcelDocument();
PdfDocument pdfDocument = new PdfDocument();
WordDocument wordDocument = new WordDocument();

DocumentPrinter printer = new DocumentPrinter();
printer.Print(wordDocument);
