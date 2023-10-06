namespace Strategy
{
    public class ClassRoom
    {
        public void SortStudents(ISortStrategy sortStrategy)
        {
            sortStrategy.Sort();
        }
    }

    public interface ISortStrategy
    {
        void Sort();
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Bubble Sort ile sıralandı");
        }
    }

    public class Quick : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Quick ile sıralandı");

        }
    }

    public class Heap : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Heap ile sıralandı");

        }
    }
}
