using System;
using System.Collections.Generic;
namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var p = new CellPhone();

            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());
      

           List<IBlendable> fruits = new List<IBlendable>() { b, s, m, c, p };

            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit.GetType());
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
