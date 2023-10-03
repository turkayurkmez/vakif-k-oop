namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateNewProduct(string name, decimal price)
        {
            string connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";

            string commandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price) ";

            var parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            var affectedRows = new DBHelper(connectionString).ExecuteCommand(commandText, parameters);

            return affectedRows;

        }

        public void SendMessageToProvider(string message)
        {
            //E-posta ile kayıt bildirimi yapıldı.
        }
    }
}
