namespace AbstractFactory
{
    /*
     * PROBLEM:
     * 
     *     Factory sınıflarını oluşturacak Fabrikalara ihtgiyacınız varsa bunu nasıl sağlarsınız?
     */


    public class Map<T> where T : IMapCreator, new()
    {
        private T mapCreator;
        public Map()
        {
            this.mapCreator = new T();
        }
        public void Show()
        {
            Console.WriteLine($"Oluşturulan haritanın stili: {mapCreator.MapStyle}, seçilen harita: {mapCreator.GetMapBase().GetType().Name}");
            mapCreator.GetRecomendedVisitPoints().ForEach(vp => Console.WriteLine(vp.Name));
        }
    }


    #region Abstract Factory Implementation

    //1. Fabrikayı üretecek olan fabrika (süper fabrika) nelerden oluşacak:
    public interface IMapCreator
    {
        string MapStyle { get; set; }
        List<IRecomendedVisitPoint> GetRecomendedVisitPoints();
        MapBase GetMapBase();

    }
    // Süper fabrika somutlaştırıldı:
    public class SatelliteCultureMap : IMapCreator
    {
        private CultureMap _map = new CultureMap();
        public string MapStyle { get; set; } = "Satellite";

        public MapBase GetMapBase()
        {
            return _map;
        }


        public List<IRecomendedVisitPoint> GetRecomendedVisitPoints()
        {
            return _map.RecomendedVisitPoints;
        }
    }

    public class RegionalReligionMap : IMapCreator
    {
        private ReligionMap _map = new ReligionMap();
        public string MapStyle { get; set; } = "Regional";

        public MapBase GetMapBase()
        {
            return _map;
        }

        public List<IRecomendedVisitPoint> GetRecomendedVisitPoints()
        {
            return _map.RecomendedVisitPoints;
        }
    }



    #endregion

    #region Factory Implemention
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

    #endregion
}
