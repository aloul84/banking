using System.Collections;

public class Card
{

  private int cardId;
  private string cardName;


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





}