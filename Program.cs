class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***********************");
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Logins user = new Logins(id, name);

        Console.WriteLine("User Created:"+name);
        Console.WriteLine("User Created:");
        Console.WriteLine(name);
       //account create
       Console.WriteLine("Enter Accont id:");
       int ID = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Account Name:");
       string NAME=Console.ReadLine();
       Console.WriteLine("EnterAccount Type:");
       string TYPE = Console.ReadLine();
       Console.WriteLine("Account Created");



      Console.WriteLine("Hello, World!");

      Card cardemp1 = new Card("sami");

      cardemp1.printCard();
 
    }
}
