using System;

namespace Exer10._2
{
    public class MyCopyableClass
    {
        public string SimpleProperty { get; set; } = "Default";

        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass myCopyableClass = new MyCopyableClass();
            myCopyableClass.SimpleProperty = "NotDefault";

            var myCopyCopy = myCopyableClass.GetCopy();
            myCopyCopy.SimpleProperty = "NotNotDefault";

            Console.WriteLine(myCopyCopy.GetType());
            Console.WriteLine(myCopyCopy.SimpleProperty);
            Console.WriteLine(myCopyableClass.SimpleProperty);

        }
    }
}
