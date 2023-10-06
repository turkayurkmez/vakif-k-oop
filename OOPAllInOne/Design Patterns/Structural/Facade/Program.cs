// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Birçok nesnenin karmaşık bir iş için kullanıldığını düşünün. Sürekli icra edilen bu iş, hatasız çalışabilmesi için nasıl basitleştirirsiniz?
 *   
 * Senaryo:
 *   Bir e-icaret platformunda, satış işlemleri birden fazla adımdan oluşmaktadır. Her adımı başka bir obje üstlenir. Bu karmaşık işi, nasıl basite indirgersiniz.
 *
 */


Customer customer = new Customer { Name = "Türkay" };
var orderLines = new List<OrderLine>() {
    new() { ProductId=1, Quantity=3},
    new() { ProductId=2, Quantity=4},
};
OrderProcess orderProcess = new OrderProcess();
orderProcess.CreateOrder(customer, orderLines);