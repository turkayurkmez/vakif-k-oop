namespace OpenClosed
{

    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold
    //}

    public interface ICardType
    {
        public double GetDiscountedPrice(double total);
    }

    public class Standard : ICardType
    {
        public double GetDiscountedPrice(double total)
        {
            return total * 0.95;
        }
    }

    public class Silver : ICardType
    {
        public double GetDiscountedPrice(double total)
        {
            return total * 0.90;

        }
    }


    public class Gold : ICardType
    {
        public double GetDiscountedPrice(double total)
        {
            return total * 0.85;

        }
    }

    public class Premium : ICardType
    {
        public double GetDiscountedPrice(double total)
        {
            return total * 0.80;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public ICardType Card { get; set; }
    }
    public class OrderManager
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double totalPrice)
        {
            return Customer.Card.GetDiscountedPrice(totalPrice);
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        return totalPrice * .95;
            //    case CardType.Silver:
            //        return totalPrice * .90;
            //    case CardType.Gold:
            //        return totalPrice * .85;
            //    default:
            //        return totalPrice;
            //}


        }
    }


}
