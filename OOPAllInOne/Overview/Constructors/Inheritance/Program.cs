// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Kofte kofte = new Kofte();
SehriyeCorbasi sehriyeCorbasi = new SehriyeCorbasi();
Bezelye bezelye = new Bezelye();

Asci asci = new Asci();
asci.Pisir(kofte);
asci.Pisir(bezelye);
asci.Pisir(sehriyeCorbasi);



Yemek yemek = new Kofte();

Stream stream = new MemoryStream();


Kofte kofte1 = yemek as Kofte;

Baklava baklava = new Baklava();
asci.Pisir(baklava);
