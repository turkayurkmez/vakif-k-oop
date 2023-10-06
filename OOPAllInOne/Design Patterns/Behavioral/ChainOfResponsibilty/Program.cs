// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilty;

Console.WriteLine("Hello, World!");
/*
 * 
 * Bir operasyon, birkaç farklı nesne tarafından icra edilmektedir ve bu nesneler içerisindeki işlemler arka arkaya çalışmalıdır. Böyle bir düzeni nesneler arasında nasıl kurgularsınız?
 * 
 * Örnek
 * 
 *  Bir http request sunucuya ulaştığında
 *     1. Authenticate
 *     2. Authorize
 *     3. Logging
 *     4. Cache
 *     5. Respone üretilecek
 *     
 *  Senaryo:
 *    Bir otel rezervasyon uygulaması yazıyorsunuz. Tüm Avrupa müşteriniz. DB çok büyük rezervasyon sistemini gelen isteğe göre nasıl yürütürsünüz. 
 */




Reservation reservation = new Reservation() { City = "London" };
ReservationComponent reservationComponent = new ReservationComponent();
reservationComponent.ExecuteReservation(reservation);

