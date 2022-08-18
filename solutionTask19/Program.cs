//Полиндром
int inputNumber = int.Parse(Console.ReadLine());
int digit1=0;
int digit2=0;
int digit3=0;
int digit4=0;
int digit5=0;
void digit()
{
 digit1=inputNumber/10000;
 digit2=(inputNumber/1000)%10;
 digit3=(inputNumber/100)%10;
 digit4=(inputNumber/10)%10;
 digit5=inputNumber%10;
}


digit();
if(digit1==digit5&&digit2==digit4)
{
    Console.WriteLine("Полиндром");
}
else
{
   Console.WriteLine("Не полиндром");
}