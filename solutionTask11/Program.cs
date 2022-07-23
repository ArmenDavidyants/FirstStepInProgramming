//Решение Артема
int number = new Random().Next(100,1000);
Console.WriteLine("Число "+number);
int numberSecondDigit = number/100;
int numberThird = number%10;
Console.WriteLine("Число после удаления второго "+numberSecondDigit+numberThird);

//Решение Кирила
void middleDigitCutter()
{
    int number = new Random().Next(100,1000);
    Console.Write("The number is: " );
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.WriteLine("The modified num is: ");
    Console.Write(stringNum[0]);
    Console.WriteLine(stringNum[2]);
}

void middleDigitCutter2()
{
  int number = new Random().Next(100,1000);
  Console.Write("The number is: "); 
  Console.WriteLine(number);
  int num1 = number/100;
  int num2 = number%10;
  Console.WriteLine(num1*10 + num2);
}
middleDigitCutter();
middleDigitCutter2();
