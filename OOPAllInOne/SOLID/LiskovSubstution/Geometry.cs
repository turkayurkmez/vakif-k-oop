namespace LiskovSubstution
{

    public interface IAreaCalcutable
    {
        double GetArea();
    }
    public class Rectangle : IAreaCalcutable
    {
        //dörtgen iki değere ihtiyaç duyar
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea() => Width * Height;
    }

    //public class Square : Rectangle
    //{
    //    //kare ise 1!!!!
    //    public override double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
    //    public override double Height { get => base.Height; set { base.Width = value; base.Height = value; } }

    //}

    public class Square : IAreaCalcutable
    {
        public double EdgeLength { get; set; }

        public double GetArea()
        {
            return Math.Pow(EdgeLength, 2);
        }
    }


    public static class Geometry
    {
        public static IAreaCalcutable GetRectangle(int width, int height = 1)
        {
            //bir biçimde......
            if (height != 1 && height > 0)
            {
                return new Rectangle { Width = width, Height = height };
            }
            else
            {
                return new Square { EdgeLength = width };
            }
        }
    }

}
