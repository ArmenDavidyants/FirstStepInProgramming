Console.Clear();
Console.Write("Введите числ: ");

string inputLineNumber=Console.ReadLine()?? "";
int inputNumber=int.Parse(Console.ReadLine());
DateTime timePoint=DateTime.Now;
int VariantChar()
{
  // int numberLenght=0;  
  // char[] array=inputLineNumber.ToCharArray();
  // numberLenght=array.Length; 
 return inputLineNumber.ToCharArray().Length;   
}
int VariantSimple()
{
  int numberLenght=0;
  int digits=1;
  while(digits<inputNumber)
  {
    digits=digits*10;
    numberLenght++;
  }
  return numberLenght;
  
}
int VariantLog10()

  {
    return (int)Math.Log10(inputNumber)+1;
  }
  int result=0;
  timePoint=DateTime.Now;
  result=VariantChar();
Console.WriteLine(result);
 Console.WriteLine(DateTime.Now-timePoint);

 timePoint=DateTime.Now;
  result=VariantSimple();
Console.WriteLine(result);
 Console.WriteLine(DateTime.Now-timePoint); 
  
  timePoint=DateTime.Now;
  result=VariantLog10();
  Console.WriteLine(result);
  Console.WriteLine(DateTime.Now-timePoint);