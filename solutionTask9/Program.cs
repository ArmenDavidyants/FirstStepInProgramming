System.Random numberSintezator = new Random( );

//Метод решения задачи вариант1
void variant1(System.Random numberSintezator)
{
//вариант 1
int number = numberSintezator.Next(10 , 100);

Console.Write(number );


int firstNumber = number/10;
int secondNumber = number%10;

if(firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
}


//Метод решения задачи вариант2
void variant2()
{
// вариант 2
int numberKirilla = new Random().Next(10, 100);
Console.Write("The random number is: ");
Console.WriteLine(numberKirilla);
string stringNum = numberKirilla.ToString();
Console.Write("The biggest digit is : ");
if (stringNum[0] > stringNum[1])
{
Console.WriteLine(stringNum[0]);
} 
else 
{
Console.WriteLine(stringNum[1]);
}
}

//Метод решения задачи вариант3
void variant3(System.Random numberSintezator)



{
// Вариант 3
char [] digits= numberSintezator.Next(10,100).ToString().ToCharArray();

Console.WriteLine(digits);
int firstNumber= ((int)(digits[0]))-48;
int secondNumber= ((int)(digits[1]))-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);
}


variant1(numberSintezator);

variant2();

variant3(numberSintezator);
