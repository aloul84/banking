using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("      RECORDS MANAGEMENT SYSTEM        ");
        Console.WriteLine("========================================");

        // 1. Logins
        Console.WriteLine("\n--- Create Login ---");
        int loginId = ReadInt("Enter Login ID: ");
        string loginName = ReadString("Enter Login Name: ");
        Logins user = new Logins(loginId, loginName);

        // 2. Account
        Console.WriteLine("\n--- Create Account ---");
        int accId = ReadInt("Enter Account ID: ");
        string accName = ReadString("Enter Account Name: ");
        string accType = ReadString("Enter Account Type: ");
        Account account = new Account(accId, accName, accType);

        // 3. Employee
        Console.WriteLine("\n--- Create Employee ---");
        int empId = ReadInt("Enter Employee ID: ");
        string empName = ReadString("Enter Employee Name: ");
        Employee employee = new Employee(empId, empName);

        // 4. Attend
        Console.WriteLine("\n--- Create Attendance Record ---");
        int attId = ReadInt("Enter Attendance ID: ");
        int attTime = ReadInt("Enter Time Long (minutes): ");
        Attend attend = new Attend(attId, attTime);

        // 5. Card
        Console.WriteLine("\n--- Create Card ---");
        string cardOwner = ReadString("Enter Card Owner Name: ");
        Card card = new Card(cardOwner);

        // Beautiful Output
        Console.WriteLine("\n" + new string('=', 40));
        Console.WriteLine("          SUMMARY OF CREATED OBJECTS      ");
        Console.WriteLine(new string('=', 40));

        PrintResult(user.ToString());
        PrintResult(account.ToString());
        PrintResult(employee.ToString());
        PrintResult(attend.ToString());
        PrintResult(card.ToString());

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("         Operation Completed.           ");
        Console.WriteLine(new string('=', 40));
    }

    static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void PrintResult(string info)
    {
        Console.WriteLine($" >> {info}");
    }
}
