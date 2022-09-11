//Пробую решить задачу дни недели
Console.WriteLine("Введите номер дня недели ");
int numDey = Convert.ToInt32(Console.ReadLine());
if (numDey == 1 || (numDey == 2) || (numDey == 3) || (numDey == 4) || (numDey == 5))
{
    Console.WriteLine("рабочий");
}
else if (numDey == 6 || (numDey == 7))
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("нет такого");
}