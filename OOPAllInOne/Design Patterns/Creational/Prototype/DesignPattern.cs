using System.Text.Json;

namespace Prototype
{
    public class Color : ICloneable
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public Color()
        {
            Thread.Sleep(3000);
            Red = 0;
            Green = 0;
            Blue = 0;
            Console.WriteLine(this);

        }
        public override string ToString()
        {
            return $"{DateTime.Now}:  {Red} - {Green} - {Blue}";
        }


        public object Clone(bool deep)
        {
            if (!deep)
            {
                return Clone();
            }
            var serialized = JsonSerializer.Serialize<Color>(this);
            return JsonSerializer.Deserialize<Color>(serialized);

        }
        public object Clone()
        {
            /*
             * Memberwise clone, sadece primitive tiplerin değerlerini kopyalar (R, G ve B). Fakat kompleks tip ve fonksiyon dönüşlerini almaz. Buna ihtiyacınız varsa; Serialize ederek deep clone tekniği kullanabilirsiniz. 
             */
            return MemberwiseClone();
        }
    }
}
