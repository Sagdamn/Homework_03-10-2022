/*10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void FindSecondDigit()
{
    Console.WriteLine("Введите трёхзначное число:");
    string newNumber = Console.ReadLine();
    string numericAsSting = newNumber.ToString();
    int result = int.Parse (numericAsSting[1].ToString());
    Console.WriteLine($"Result number: {result}");
}

FindSecondDigit();