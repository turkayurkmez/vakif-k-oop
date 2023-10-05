namespace FactoryMethod
{
    public class Document
    {
        public string FilePath { get; set; }
        public string Title { get; set; }

        public Document(string filePath, string title)
        {
            FilePath = filePath;
            Title = title;
        }
    }

    public class Word : Document
    {
        public Word(string filePath, string title) : base(filePath, title)
        {
        }
    }

    public class Excel : Document
    {
        public Excel(string filePath, string title) : base(filePath, title)
        {
        }
    }

    public class PowerPoint : Document
    {
        public PowerPoint(string filePath, string title) : base(filePath, title)
        {
        }
    }


    public static class DocumentFactory
    {
        public static Document CreteDocument(string type, string filePath, string title)
        {
            switch (type)
            {
                case "word":
                    return new Word(filePath, title);
                case "excel":
                    return new Excel(filePath, title);
                default:
                    return null;

            }
        }
    }
}
