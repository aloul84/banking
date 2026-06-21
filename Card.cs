using System.Collections;
using System.Runtime.InteropServices;

public class Card
{

  private int cardId;
  private string cardName;

List<Card> cards = new List<Card>();

 public  Card(string cName)
    {
        Random rand = new Random();
        cardId = rand.Next(1, 55);
        cardName=cName;
    }
  
    public  void printCard()

    {

       

      Console.WriteLine("User name is...... " + cardName);
      Console.WriteLine("card id is......... " + cardId);

     


      }

    public void PrintAllCards(List<Card> cards)
{
    for (int i = 0; i < cards.Count; i++)
    {
        cards[i].printCard();
    }
}  


}