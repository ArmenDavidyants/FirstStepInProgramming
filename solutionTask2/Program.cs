string? firstNumber = Console.ReadLine();
string? secondNumer = Console.ReadLine(); 

if (firstNumber != null && secondNumer  != null)

{
  int maxNumber = int.Parse(firstNumber);
  int minNumber = int.Parse(secondNumer);
  if(maxNumber == minNumber)
  {
    Console.WriteLine("Равны"); 
  }
  else
  {
    if (maxNumber > minNumber)
   {
    
     Console.WriteLine(maxNumber);
     Console.WriteLine("max");
     Console.WriteLine(minNumber);
     Console.WriteLine("min");
   }
   else
   {
    Console.WriteLine(maxNumber);
    Console.WriteLine("min");
    Console.WriteLine(minNumber);
    Console.WriteLine("max");
  }

}
}
