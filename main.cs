using System;

class Program {

public static double CalculateCharges(double hoursparked)
{
  double charges = 2.00;

  if (hoursparked<= 3)
  charges = 2.00;
  else if (hoursparked>3 && hoursparked<=19)
    charges = 2.00 + ((hoursparked-3) * 0.50);
  else
    charges = 10;
 
  return charges;
}
  public static void Main (string[] args) {

  double charge;
  string input = "y";
  int hrprk;
    
do
  {
  //get the hours parked for each customer
  Console.WriteLine("How many hours parked?");
  hrprk = Convert.ToInt32(Console.ReadLine());
  //Calculate parking charges
  charge = CalculateCharges(hrprk);

  Console.WriteLine("Total parking charges: $" + charge);

  Console.WriteLine("Are there anymore customers? Y/N?");
  input = Console.ReadLine();
  }
while (input == "y");

Console.WriteLine("Thank you! Have a great day!");



  }
}