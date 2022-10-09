/*15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Для уточнения информации по выходным дням введите число от 1 до 7:");
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "1")
Console.WriteLine("нет, понедельник - рабочий день");

else if (dayOfWeek == "2")
Console.WriteLine("нет, вторник - рабочий день");

else if (dayOfWeek == "3")
Console.WriteLine("нет, среда - рабочий день");

else if (dayOfWeek == "4")
Console.WriteLine("нет, четверг - рабочий день");

else if (dayOfWeek == "5")
Console.WriteLine("нет, пятница - рабочий день");

else if (dayOfWeek == "6")
Console.WriteLine("да, суббота - выходной день");

else if (dayOfWeek == "7")
Console.WriteLine("да, воскресенье - выходной день");

else 
Console.WriteLine("Вы ввели некорректное число, необходимо ввести число от 1 до 7");