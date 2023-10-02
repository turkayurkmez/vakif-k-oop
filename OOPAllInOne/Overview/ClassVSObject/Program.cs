// See https://aka.ms/new-console-template for more information
using ClassVSObject;

Console.WriteLine("Hello, World!");

Person developer = new Person();

developer.Name = "Türkay";

Person developer2 = developer;
developer2.Name = "Ersin";

Console.WriteLine(developer.Name);
