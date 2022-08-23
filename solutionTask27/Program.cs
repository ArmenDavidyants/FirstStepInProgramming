int inputNumber = int.Parse(Console.ReadLine());
int sum =0;
int Conculate()
{
  while (inputNumber>0)  
{
    sum=sum+inputNumber%10;
    inputNumber=inputNumber/10;
    
}
return sum;
}

Conculate();
Console.WriteLine(sum);
