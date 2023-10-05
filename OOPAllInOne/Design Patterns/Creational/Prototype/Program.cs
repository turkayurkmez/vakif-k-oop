// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine(DateTime.Now);
var cities = new string[] { "Eskişehir", "İzmir", "Bilecik", "Kütahya", "Bursa" };
var cloneOfCities = cities.Clone();

/*
 * Bir nesneniz var.
 *  Bu nesnenin constuctor ile  bellekte oluşturulması, bir biçimde çok zaman alıyor. Fakat aynı sınıftan onlarca instance'a ihtiyacınız var. Bu zaman maaliyetinden nasıl kurtulursunuz?
 *  
 */

Color black = new Color();
Color red = (Color)black.Clone();
red.Red = 255;
Console.WriteLine(red);
Color yellow = (Color)red.Clone();
yellow.Green = 255;
Console.WriteLine(yellow);


Color white = (Color)yellow.Clone();
white.Blue = 255;
Console.WriteLine(white);






