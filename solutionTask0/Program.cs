string? inputline = Console.ReadLine(); 
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    //int outNumber = inputNumber*inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine(outNumber);
}
