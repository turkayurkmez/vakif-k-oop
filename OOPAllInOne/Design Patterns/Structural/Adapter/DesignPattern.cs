namespace Adapter
{

    public class Product
    {
        public string FromProvider { get; set; }
    }

    //1. Kaynakların ortak özelliğini bul ve bunu interface olarak yaz
    public interface IDataAdapter
    {
        List<Product> GetProducts();
    }

    //2. Adaptörleri concrete olarak oluştur.
    public class XMLProvider : IDataAdapter
    {
        public List<Product> GetProducts()
        {
            return new() { new Product { FromProvider = "XML'den veri çekildi" } };
        }
    }

    public class DbProvider : IDataAdapter
    {
        public List<Product> GetProducts()
        {
            return new() { new Product() { FromProvider = "Db'den veri çekildi" } };
        }
    }

    public class DataParser
    {
        public List<Product> GetProducts(IDataAdapter dataAdapter)
        {
            return dataAdapter.GetProducts();
        }
    }


}
