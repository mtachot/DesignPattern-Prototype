using PrototypePattern.Classes;
using PrototypePattern.Classes.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();

            Shape clonedShape = ShapeCache.getShape("1");
            Console.WriteLine(String.Format("Shape : {0}", clonedShape.getType()));

            clonedShape = ShapeCache.getShape("2");
            Console.WriteLine(String.Format("Shape : {0}", clonedShape.getType()));

            clonedShape = ShapeCache.getShape("3");
            Console.WriteLine(String.Format("Shape : {0}", clonedShape.getType()));

            Console.ReadLine();
        }
    }
}
