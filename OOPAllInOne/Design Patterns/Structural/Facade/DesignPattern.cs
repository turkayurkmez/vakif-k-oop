namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }

    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }

    public class OrderLine
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        List<OrderLine> orderLines { get; set; } = new List<OrderLine>();
    }

    public class OrderService
    {
        public int CreateOrder(Customer customer, DateTime dateTime)
        {
            Console.WriteLine($"{customer.Name}, {dateTime} tarihinde sipariş verdi");
            return new Random().Next(1, 1000);
        }
    }

    public class OrderLineService
    {
        public void CreateOrderLines(int orderId, List<OrderLine> orderLines)
        {
            Console.WriteLine($"------------{orderId} nolu siparişte satın alınan ürünler -----------------");
            orderLines.ForEach(ol => Console.WriteLine($"{ol.ProductId} id'li üründen {ol.Quantity} adet alındı"));
        }


    }

    public class ProductService
    {
        public void UpdateStock(List<OrderLine> orderLines)
        {
            orderLines.ForEach(ol => Console.WriteLine($"{ol.ProductId} ürün stoğundan {ol.Quantity} adet düşüldü"));
        }
    }

    public class OrderProcess
    {
        OrderService orderService = new OrderService();
        OrderLineService orderLineService = new OrderLineService();
        ProductService productService = new ProductService();

        public void CreateOrder(Customer customer, List<OrderLine> orderLines)
        {
            var orderId = orderService.CreateOrder(customer, DateTime.Now);
            orderLineService.CreateOrderLines(orderId, orderLines);
            productService.UpdateStock(orderLines);
        }
    }

}
