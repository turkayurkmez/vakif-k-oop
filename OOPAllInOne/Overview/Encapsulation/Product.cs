namespace Encapsulation
{
    public class Product
    {
        private double price;
        public void SetPrice(double value)
        {
            price = value > 0 ? value : throw new ArgumentException($"fiyat negatif olamaz!");
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public int Stock { get; private set; }




    }
}
