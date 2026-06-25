public class Account
{
    public int id { get; set; }
    public string name { get; set; }
    public string type { get; set; }

    public Account(int ID, string NAME, string TYPE)
    {
        id = ID;
        name = NAME;
        type = TYPE;
    }

    public override string ToString()
    {
        return $"[Account] ID: {id}, Name: {name}, Type: {type}";
    }
}
