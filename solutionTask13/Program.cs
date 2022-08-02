//выводит третий элемент массива
string?inputline = Console.ReadLine(); 
char [] myArray=inputline.ToCharArray();

if(myArray.Length>=3)
{
  Console.WriteLine(myArray[2]);
}
else
{
Console.WriteLine("Третьей цифры нет");
}







