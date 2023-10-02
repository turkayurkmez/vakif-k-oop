namespace AbstractANDInteerface
{
    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet)
        {
        }
    }


    public interface IKiyafet { }
    public abstract class Kiyafet { }

    public class UstGiyim { }

    public class Kazak : UstGiyim
    {

    }
    public class KirmiziKazak : Kazak
    {

    }
}
