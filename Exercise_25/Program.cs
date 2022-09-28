// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Type a number A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Type a number B: ");
int b = int.Parse(Console.ReadLine()!);
if (b < 0)
   Console.Write("The number B could not be negative");
else
{
   int power = Power(a, b);
   Console.Write($"{a} to the power of {b} is {power}");
}

int Power(int a, int b)
{ 
   int result = 1;
   for(int i = 1; i<= b; i++)
   {
     result = result * a;
   }
   return result;
}
