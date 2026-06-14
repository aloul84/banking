


public class Account
{
    public int id {get;set;}
public string name {get;set;}
public string type {get;set;}

public Account (int ID, string NAME,string TYPE)
    {
        id = ID;
        name=NAME;
        type=TYPE;
    }
   string [] AccountType = new string [3] {"ILS","USD","JOD"};
}
