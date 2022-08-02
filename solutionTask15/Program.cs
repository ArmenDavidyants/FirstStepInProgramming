// Выходные "Да" Будние "Нет"
string? inputline = Console.ReadLine(); 
int dayOfWeek=int.Parse(inputline);
if (dayOfWeek==6 || dayOfWeek==7)
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
