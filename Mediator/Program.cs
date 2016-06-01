namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(concreteMediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(concreteMediator);

            concreteMediator.Colleague1 = colleague1;
            concreteMediator.Colleague2 = colleague2;

            colleague1.Send("吃过饭了吗？");
            colleague2.Send("没有呢，你打算请客？");
        }
    }
}
