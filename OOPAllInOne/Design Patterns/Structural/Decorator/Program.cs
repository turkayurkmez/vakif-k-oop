// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Hali hazırda belleklte varolan bir nesneye yeni bir işlev (ya da özellik) kazandırmak istiyorsunuz. Varolan nesneye dokunmadan bunu nasıl yapabilirsiniz.
 *   
 *   
 */

//Stream memorySteam = new MemoryStream();
//Stream fileStream = new FileStream("", FileMode.OpenOrCreate);
//Stream networkStream = new NetworkStream(null);


//var gzipStream = new GZipStream(memorySteam, CompressionLevel.Optimal);
////var cryptoStream = new CryptoStream()
MailMessage mailMessage = new MailMessage();
SignedMail signedMail = new SignedMail(mailMessage) { SignedBy = "Türkay Ürkmez" };
CryptoMail cryptoMail = new CryptoMail(signedMail);

cryptoMail.Send();


