namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);
        }
    }
}
