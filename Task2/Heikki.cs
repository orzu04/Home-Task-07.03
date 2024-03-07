namespace Task2;

public class Heikki
{

   decimal _balancce;
   public Heikki(decimal balance)
   {
  _balancce = balance;

   }


   public void ToString(decimal gezoshtan)
   {

      System.Console.WriteLine($"Heikki's account balance: {_balancce-gezoshtan}");
   }

}
