// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency:
 * 
 *     ..hava.. olmadan ..insan. yaşamaz....
 *     tekerlek olmadan araba hareket etmez
 *     
 *     bilgisayar ram olmadan çalışmaz. Öyleyse bilgisayar dependent (bağlıdır) ram'a
 *     
 * Inversion:
 *   
 *    
 * 
 *
 */
MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
Telegram telegram = new Telegram();

Report report = new Report(whatsAppSender);
report.Send("");

Report report1 = new Report(telegram);
report1.Send("");

Report report2 = new Report(mailSender);
report2.Send("");