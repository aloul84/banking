

/*class Program2
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
     //----------------account create-----------------------------
       Console.WriteLine("Enter Accont id:");
       int ID = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Account Name:");
       string NAME=Console.ReadLine();
       
       Console.WriteLine("EnterAccount Type:");
       string TYPE = Console.ReadLine();
       string [] AccountType = new string [3] {"ILS","USD","JOD"};

          if  (! AccountType.Contains(TYPE))
            {
              Console.WriteLine("Input Valid Value: ILS or USD or JOD");
               
            } 

       Console.WriteLine("Account Created");
       Console.WriteLine($"Account Informations Is: "+"id:"+ID +"  Name:"+NAME + "  Type:"+TYPE);
 
    }
}
*/