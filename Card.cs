using System;
using System.Collections;

public class Card
{
    private int cardId;
    private string cardName;

    public Card(string cName)
    {
        Random rand = new Random();
        cardId = rand.Next(1, 55);
        cardName = cName;
    }

    public void printCard()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return $"[Card] Name: {cardName}, ID: {cardId}";
    }
}
