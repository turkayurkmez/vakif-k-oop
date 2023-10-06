namespace ChainOfResponsibilty
{


    //1. Zinciri gönderilecek isteği tanımla:
    public class Reservation
    {
        public string City { get; set; }

    }


    //2. Bu zincirinin her halkasının tanımı:
    public abstract class Responsible
    {

        public Responsible? Next { get; set; }

        public Responsible(Responsible? next)
        {
            Next = next;
        }

        public abstract void Execute(Reservation reservation);


    }

    public class LondonMeeting : Responsible
    {
        public LondonMeeting(Responsible? next) : base(next)
        {
        }

        public override void Execute(Reservation reservation)
        {
            if (reservation.City == "London")
            {
                Console.WriteLine($"{reservation.City} rezervasyonu yapıldı! Sorumlu obje: {GetType().Name}");
            }
            else
            {
                if (Next != null)
                {
                    Next.Execute(reservation);
                }
            }
        }
    }

    public class ParisMeeting : Responsible
    {
        public ParisMeeting(Responsible? next) : base(next)
        {
        }

        public override void Execute(Reservation reservation)
        {
            if (reservation.City == "Paris")
            {
                Console.WriteLine($"{reservation.City} rezervasyonu yapıldı! Sorumlu obje: {GetType().Name}");
            }
            else
            {
                if (Next != null)
                {
                    Next.Execute(reservation);
                }
            }
        }
    }

    public class IstanbulMeeting : Responsible
    {
        public IstanbulMeeting(Responsible? next) : base(next)
        {
        }

        public override void Execute(Reservation reservation)
        {
            if (reservation.City == "İstanbul")
            {
                Console.WriteLine($"{reservation.City} rezervasyonu yapıldı! Sorumlu obje: {GetType().Name}");
            }
            else
            {
                if (Next != null)
                {
                    Next.Execute(reservation);
                }
            }
        }
    }


    public class ReservationComponent
    {

        public void ExecuteReservation(Reservation reservation)
        {
            IstanbulMeeting istanbulMeeting = new IstanbulMeeting(null);
            ParisMeeting parisMeeting = new ParisMeeting(istanbulMeeting);
            LondonMeeting londonMeeting = new LondonMeeting(parisMeeting);


            londonMeeting.Execute(reservation);
        }

    }


}
