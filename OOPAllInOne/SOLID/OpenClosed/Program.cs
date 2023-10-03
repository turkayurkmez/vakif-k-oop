// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 *  Bir nesne .......gelişime....... Açık .......değişime...... Kapalı olmalı.
 *  
 *
 */
Customer customer = new Customer { Name = "Türkay", Card = new Premium() };
OrderManager orderManager = new OrderManager { Customer = customer };
Console.WriteLine(orderManager.GetDiscountedPrice(200));
