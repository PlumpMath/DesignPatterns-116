namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new StudentFactory();
            LeiFeng leiFeng =  factory.CreateLeiFeng();

            leiFeng.Wash();
            leiFeng.Sweep();
            leiFeng.Cook();
        }
    }
}
