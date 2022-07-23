string? inputline = Console.ReadLine(); 
if (inputline != null)
{
int inputNumber = int.Parse(inputline);
int outputNumber = inputNumber%10;
Console.WriteLine(outputNumber);

// char[] m = inputline.ToArray();   
//  Console.WriteLine(m[2]);  
   
}
