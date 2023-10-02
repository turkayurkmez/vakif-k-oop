// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");



Product sunGlass = new Product();
double value = double.Parse(Console.ReadLine());
//if (value>0)
//{
//    sunGlass.Price = value;
//}

//sunGlass.Price = -100;
sunGlass.SetPrice(value);
sunGlass.Description = "Rayban güneş...";

