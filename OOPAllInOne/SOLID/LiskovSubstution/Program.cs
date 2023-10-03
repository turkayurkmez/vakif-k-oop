// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 *  Inheritance ilişkisi olan iki nesne arasında base ve derived nesneler birbirlerinin yerine kullanılabilir olmalı!
 *  
 *  Başka bir değişle;
 *  derived (türemiş) nesne base (ana) nesnenin davranışını DEĞİŞTİRMEMELİ
 */

Square square = new Square { EdgeLength = 10 };
Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };

Console.WriteLine($"Kare: {square.GetArea()}");
Console.WriteLine($"Dörtgen: {rectangle.GetArea()}");

var rect = Geometry.GetRectangle(5, 6);


Console.WriteLine($"Geometri sınıfının ürettiği: {rect.GetArea()}");
