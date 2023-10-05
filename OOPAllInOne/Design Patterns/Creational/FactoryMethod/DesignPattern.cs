namespace FactoryMethod
{
    /*
     *  PROBLEM:
     *  
     *  Bir nesne (X) belirli bir başka nesne olmadan(Y), faaliyet gösterememektedir. İhtiyacınız, x instance'ini
     *  aldığınız anda y instance'inin da bellekte oluşması. Bu ihtiyacınızı nasıl karşılarsınız?
     *  
     *  Oluşturma mantığını istemciye göstermeden nesne oluşturmayı nasıl sağlarız?
     *  
     *  Senaryo:
     *    Bir turistin, bir bölgedeki ziyaret noktalarını ilgi alanına göre seçebileceği bir harita uygulaması yazıyorsunuz. 
     *    Kültür turizmi ise: Müzeler, Sergi alanları vs.
     *    Eğlence ise: Kafe, Bar vs...
     *    İnanç: Camii, Mezarlık ve Türbe
     *  
     *  
     *  
     */
    //Müze, Kafe, Camiii
    //Bu bir Product nesnesidir. 
    //1. Fabrikanızın üreteceği Product'ı belirleyin (Ziyaret noktası): Interface olmalı
    public interface IRecomendedVisitPoint
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        string APIUrl { get; set; }
        string Icon { get; set; }
        string Name { get; set; }
    }

    public interface ICulturalVisitPoint : IRecomendedVisitPoint
    {
        bool IsAvailable { get; set; }
    }

    //2. Concrete sınıfları oluşturun
    public class Museum : ICulturalVisitPoint
    {
        public bool IsAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string APIUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Icon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
    }

    public class Exhibition : ICulturalVisitPoint
    {
        public bool IsAvailable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string APIUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Icon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
    }

    public class Mosquee : IRecomendedVisitPoint
    {
        public string Name { get; set; }
        public double Latitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Longitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string APIUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Icon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    //3. Oluşturucuyu belirleyin:
    //Bu haritayı bellekte oluştururken hangi ziyaret noktalarını göstereceğim?
    public abstract class MapBase
    {
        public List<IRecomendedVisitPoint> RecomendedVisitPoints { get; set; }
        public MapBase()
        {

            RecomendedVisitPoints = new List<IRecomendedVisitPoint>();
            createVisitPoints();
        }
        //Factory method: Bu metodun görevi: Harita (X) oluştuğu anda hangi (Product)'un oluşacağını belirlemek
        protected abstract void createVisitPoints();
    }

    //4. Oluşturucuyu concrete sınıflara dönüştürün:

    public class CultureMap : MapBase
    {
        protected override void createVisitPoints()
        {
            RecomendedVisitPoints.Add(new Museum { Name = "Topkapı Müzesi" });
            RecomendedVisitPoints.Add(new Museum { Name = "Yerebatan Sarnıcı" });


        }
    }

    public class ReligionMap : MapBase
    {
        protected override void createVisitPoints()
        {
            RecomendedVisitPoints.Add(new Mosquee { Name = "Sultanahmet" });
            RecomendedVisitPoints.Add(new Mosquee { Name = "Ayasofya" });

        }
    }
}
