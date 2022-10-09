/*13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void FindThirdDigit()
{
    int newNumber = (new Random()).Next(1, 100000);
    Console.WriteLine($"Исходное число: {newNumber}");
    string numericAsSting = newNumber.ToString();

if (newNumber > 99)
{
    int result = int.Parse (numericAsSting[2].ToString());
    Console.WriteLine($"Третья цифра числа: {result}");
}

else 
    Console.WriteLine($"Третьей цифры числа не существует");
}

FindThirdDigit();