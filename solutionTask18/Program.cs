﻿void printAnswer(int number)
{
    if(number==1) Console.WriteLine("Допустимо значение х>0 и y>0");
    if(number==2) Console.WriteLine("Допустимо значение х<0 и y>0");
    if(number==3) Console.WriteLine("Допустимо значение х<0 и y<0");
    if(number==4) Console.WriteLine("Допустимо значение х>0 и y<0");


}

string? inputline = Console.ReadLine(); 
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    
 printAnswer(inputNumber);   
}