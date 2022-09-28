// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Clear();
Console.Write("Type a number: ");
string number = Console.ReadLine();
int sumOfNumber = SumOfNumber(number);
Console.Write($"The sum of digits of the number {number} = {sumOfNumber}");

int SumOfNumber(string number)
{
    int result = 0;
    
    for(int i=0;i<number.Length;i++)
    {
        result = result + int.Parse(number[i].ToString());            
    }

    return result;
}
