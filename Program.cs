using System;
public class Mathy
{
  public static void Main()
  {
    int num1, num2;
     
    Console.Write("Input the first number to multiply: ");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the second number to multiply: ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
     
    int result = num1 * num2;
    Console.WriteLine("Output: {0} x {1} = {2}", 
                        num1, num2, result);
  }
}