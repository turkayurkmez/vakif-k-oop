using System.Collections;

namespace Iterator
{
    public class News
    {
        public string Title { get; set; }
    }

    public class Iterator<T> : IEnumerable<T>
    {

        private List<T> collection = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Current { get; private set; }
        private int position = 0;
        public void Add(T item)
        {
            collection.Add(item);
            Current = collection[collection.Count - 1];
            //position = collection.Count - 1;
        }

        public T Next()
        {
            if (position < collection.Count - 1)
            {
                position++;

            }
            else
            {
                position = 0;
            }


            Current = collection[position];
            return Current;

        }

        public T First()
        {
            Current = collection[0];
            return Current;
        }

        public T Last()
        {
            Current = collection[collection.Count - 1];
            return Current;
        }

    }
}
