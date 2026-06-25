public class Attend
{
    public int Id { get; set; }
    public int TimeLong { get; set; }

    public Attend(int id, int timeLong)
    {
        Id = id;
        TimeLong = timeLong;
    }

    public override string ToString()
    {
        return $"[Attend] ID: {Id}, TimeLong: {TimeLong}";
    }
}
