// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");
/*
 * Bir kaynaktan gelen verinin formatı ile uygulamanızın beklediği format aynı değilse, ikisini nasıl konuşturursunuz?
 * 
 * Metafor:
 *    Bir Web Service (Web API) db'den veriyi çekmekte ve IOS uygulamanın kullanacağı bir formata dönüştürür. 
 *    Data -> JSON 
 *    
 * Senaryo:
 * Bir uygulama; belirtilen veri kaynağından veri okuma işlemi yapacaktır. Birbirleriyle ilişkisi olmayan bu iki kaynaktan veriyi adaptör aracılığı ile alabilirsiniz.
 * 
 * 
 *    
 */
DataParser dataParser = new DataParser();
XMLProvider xmlProvider = new XMLProvider();
DbProvider dbProvider = new DbProvider();


dataParser.GetProducts(xmlProvider).ForEach(p => Console.WriteLine(p.FromProvider));
dataParser.GetProducts(dbProvider).ForEach(p => Console.WriteLine(p.FromProvider));