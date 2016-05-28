namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            originator.Show();

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Off";
            originator.Show();

            originator.SetMemento(caretaker.Memento);
            originator.Show();
        }
    }
}
