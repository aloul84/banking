
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Logins user = new Logins(id, name);

        Console.WriteLine("User Created:");
        Console.WriteLine(name);



        Account account1 = new Account() ;
        account1.SetName("Rami");
        account1.SetId(2040);
        account1.SetType("ILS");
        Console.WriteLine(account1.GetName());
        Console.WriteLine(account1.GetId());
        Console.WriteLine(account1.Gettype());

        Account account2 = new Account();
        account2.SetName("Moath");
        account2.SetId(3045);
        account2.SetType("JOD");
        Console.WriteLine(account2.GetName());
        Console.WriteLine(account2.GetId());
        Console.WriteLine(account2.Gettype());



    }
}
