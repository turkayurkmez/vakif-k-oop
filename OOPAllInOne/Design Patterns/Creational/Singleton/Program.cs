// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
/*
 * PROBLEM:
 * 
 *    Bir nesnenin uygulama boyunca sadece ve sadece bir adet olmasını istiyorsunuz. Bunu nasıl sağlarsınız?
 *    
 *    
 *    
 */
Logger logger = Logger.CreateLogger();
logger.LogLevel = 5;
logger.LogInfo();

Logger logger1 = Logger.CreateLogger();
Console.WriteLine(logger1.LogLevel);
logger1.LogInfo();