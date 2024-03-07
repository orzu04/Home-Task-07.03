namespace Task2;

public class Personal
{

     decimal _balancce;
   public Personal(decimal balance)
   {
  _balancce = balance;

   }


   public void ToString(decimal gezoshtan)
   {

      System.Console.WriteLine($"Personal account balance: {_balancce+gezoshtan}");
   }

}
