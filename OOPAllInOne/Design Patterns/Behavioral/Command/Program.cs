// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Uygulamanızın yapacağı birçok iş birçok kaynak tarafından yönlendiriyorsa; kod tekrarına düşmemek ve tüm ortak işlevleri daha düzdenli icra etmek için nasıl bir düzen oluşturursunuz?
 */

CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.AddCommand(new ProductPriceChangeCommand() { NewPrice = 150, ProductId = 3 });
commandInvoker.AddCommand(new ChangeCustomerEmailCommand() { CustomerId = 2, NewEmail = "test@change.org" });

commandInvoker.ExecuteCommand();
commandInvoker.ExecuteCommand();


