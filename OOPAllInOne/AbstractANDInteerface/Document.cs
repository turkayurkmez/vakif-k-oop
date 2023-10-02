namespace AbstractANDInteerface
{


    public abstract class Document
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Owner { get; set; }

        public void Copy(string from, string to) { }
        public void Move(string from, string to) { }

        public abstract void Save(string path);
        public abstract void Open(string path);
        //public abstract void Print();

    }

    public interface IPrintable
    {
        void Print();
    }

    public class PdfDocument : Document
    {
        public override void Open(string path)
        {

        }

        //public override void Print()
        //{
        //    Console.WriteLine("PDF Çıktısı alındı");
        //}

        public override void Save(string path)
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Excel Çıktısı alındı");
        }

        public override void Save(string path)
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open(string path)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Word Çıktısı alındı");

        }

        public override void Save(string path)
        {
            throw new NotImplementedException();
        }
    }


    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            //Strategy-> Proxy
            //log'unu yaz.
            //güvenlik uygula
            document.Print();
        }
    }






}
