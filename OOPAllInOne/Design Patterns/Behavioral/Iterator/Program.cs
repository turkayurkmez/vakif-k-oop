// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bellekteki bir koleksiyonun tüm elemanlarını değil bir navigasyona göre (ileri, geri gibi) tek tek o o elemanını kullanmak istiyorsunuz. Bu tasarımı nasıl yaparsınız?
 */

Iterator<News> it = new Iterator<News>()
{
    new(){ Title="Galatasaray Avrupa Şampiyonu"},
    new(){ Title="2. El araba fiyatları düşüyor!!!"},
    new(){ Title="Güzel bir haber"},


};

var next = it.Next();
Console.WriteLine(next.Title);
Console.WriteLine(it.First().Title);
Console.WriteLine(it.Last().Title);

