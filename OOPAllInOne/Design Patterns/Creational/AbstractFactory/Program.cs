// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

//RegionalReligionMap map = new RegionalReligionMap();
//Console.WriteLine("Harita türü: " + map.MapStyle);
//map.GetRecomendedVisitPoints().ForEach(p => Console.WriteLine(p.Name));

Map<SatelliteCultureMap> map = new Map<SatelliteCultureMap>();
map.Show();