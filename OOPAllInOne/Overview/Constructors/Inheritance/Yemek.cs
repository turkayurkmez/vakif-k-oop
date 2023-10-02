namespace Inheritance
{
    public class Yemek
    {
        public int Sure { get; set; }

        public string YemekSekli { get; set; }

        public List<string> Malzemeler { get; set; }

        public double Fiyat { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek {Sure} dakikada pişti");
        }
        public virtual void SunumYap()
        {
            Console.WriteLine($" {GetType().Name}, Yanında pilav ile sunuldu");
        }

    }

    public class Corba : Yemek
    {
        public bool SogukMu { get; set; }
        public bool LimonVarMi { get; set; }



    }

    public class SehriyeCorbasi : Corba
    {
        public SehriyeCorbasi()
        {
            Sure = 20;
        }
        public string SehriyeTuru { get; set; }
    }

    public class SebzeYemegi : Yemek
    {

    }

    public class Bezelye : SebzeYemegi
    {
        public Bezelye()
        {
            Sure = 40;
        }
        public bool HavucVarMi { get; set; }
    }

    public class EtYemegi : Yemek
    {
        public string EtTuru { get; set; }
    }


    public class Kofte : EtYemegi
    {
        public Kofte()
        {
            Sure = 15;
        }
    }

    public class Baklava : Yemek
    {
        public override void SunumYap()
        {
            Console.WriteLine($" {GetType().Name}, Yanında dondurma ile sunuldu");
        }
    }

}
