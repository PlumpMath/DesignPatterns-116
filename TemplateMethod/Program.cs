namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm algorithma = new ConcreteAlgorithmA();
            algorithma.TemplateMethod();

            Algorithm algorithmb = new ConcreteAlgorithmB();
            algorithmb.TemplateMethod();
        }
    }
}
