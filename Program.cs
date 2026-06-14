using System;

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
    }
}
