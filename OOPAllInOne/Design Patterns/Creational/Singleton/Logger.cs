namespace Singleton
{
    public class Logger
    {
        public int LogLevel { get; set; }
        public void LogInfo() => Console.WriteLine($"{LogLevel} seviyesinde loga yazılıdı");


        private static Logger instance;
        public static Logger CreateLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;

        }
        private Logger()
        {


        }

    }
    public interface ILogger
    {
        void LogInfo();
    }


    //public static class StaticLogger : ILogger
    //{
    //    public static void LogInfo() => Console.WriteLine("Loglandı");
    //}
}
