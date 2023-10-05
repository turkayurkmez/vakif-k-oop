// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");

var word = DocumentFactory.CreteDocument("word", "C:\\my.docx", "Romanım");
var excel = DocumentFactory.CreteDocument("excel", "", "");


CultureMap cultureMap = new CultureMap();
Console.WriteLine("----------- Kültür Turizmi -------------");
cultureMap.RecomendedVisitPoints.ForEach(visit => Console.WriteLine(visit.Name));

ReligionMap religionMap = new ReligionMap();
Console.WriteLine("----------- İnanç Turizmi -------------");

religionMap.RecomendedVisitPoints.ForEach(visit => Console.WriteLine(visit.Name));

