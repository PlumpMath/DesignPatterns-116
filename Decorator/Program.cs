using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Espresso beverage1 = new Espresso();
            Mocha mocha = new Mocha(beverage1);
            Soy soy = new Soy(mocha);
            Whip whip = new Whip(soy);

            Console.WriteLine(whip.GetDescription()+"  "+whip.Cost());
        }
    }
}
