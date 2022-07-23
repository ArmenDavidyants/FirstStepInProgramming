string? inputline = Console.ReadLine(); 
if (inputline != null)
{
int inputNumber = int.Parse(inputline);
int startNumber = 1;

 string? outLine = " 0 ";
 while (startNumber<inputNumber)
  {
     outLine = startNumber*(-1)+ outLine+ startNumber+", ";
     startNumber++;
  }
//outLine=outLine+inputNumber;
Console.WriteLine(outLine);

}
