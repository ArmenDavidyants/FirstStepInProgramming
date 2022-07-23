// "нахождение второй цифры трехзначного числа"
string? inputline = Console.ReadLine(); 
int inputNumber = int.Parse(inputline);
int numberTwo=0;
if(inputNumber>999 || inputNumber<100)
{
    Console.WriteLine("ERROR");
}
else
{
numberTwo=inputNumber/10-(inputNumber/100*10);
}
Console.WriteLine("second number: "+numberTwo);



