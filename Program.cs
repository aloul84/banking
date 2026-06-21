



class Program
{
    static void Main(string[] args)
    {
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

 //Employee  employees = [2];

List<Employee> employees = new List<Employee>();

Employee em1 = new Employee();
//Card card1 = new Card("card 1 ");
    
employees.Add(em1);  

Employee em2 = new Employee();
//Card card2 = new Card("card2 ");
    // em2.card = card2;
     employees.Add(em2);  

for (int i = 0; i < employees.Count; i++)
{
         employees[i].card.printCard();

}

 
    }
}
