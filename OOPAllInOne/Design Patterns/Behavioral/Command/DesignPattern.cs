namespace Command
{
    public interface ICommand
    {
        void Execute();
        int CommandId { get; set; }
    }




    public class ChangeCustomerEmailCommand : ICommand
    {
        public int CommandId { get; set; }

        public string NewEmail { get; set; }
        public int CustomerId { get; set; }

        public void Execute()
        {
            Console.WriteLine($"{NewEmail} adresi, güncellendi");
        }
    }

    public class ProductPriceChangeCommand : ICommand
    {
        public int CommandId { get; set; }

        public int ProductId { get; set; }
        public double NewPrice { get; set; }


        public void Execute()
        {
            Console.WriteLine($"{ProductId} id'li ürünün yeni fiyatı {NewPrice} olarak güncellendi");
        }
    }

    public class CommandInvoker
    {
        Queue<ICommand> commands = new Queue<ICommand>();
        public void AddCommand(ICommand command)
        {
            commands.Enqueue(command);
        }
        public void ExecuteCommand()
        {
            if (commands.Count == 0)
            {
                Console.WriteLine("Çalıştırılacak komut yok");
            }

            while (commands.Count > 0)
            {
                var command = commands.Dequeue();
                command.Execute();
            }
        }
    }
}
