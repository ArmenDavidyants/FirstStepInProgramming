﻿string? inputlineN = Console.ReadLine(); 
if (inputlineN != null)
{
    int numberN = int.Parse(inputlineN);

    string lineN="";
    string lineNN=string.Empty;
    int s=1;
    while(s<=numberN)
    {
        lineN=lineN+s+" ";
        lineNN=lineNN+s*s+" ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
//Вариант Кирила
// List<int> listGen(int number) {
// List<int> numbers = new List<int>();
// for(int i = 1; i <= number; i++){
// numbers.Add(i);
// }
// return numbers;
// }

// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
// int inputNumber = int.Parse(inputLine);
// List<int> nums = listGen(inputNumber);
// foreach (var i in nums) {
// Console.Write(i);
// Console.Write(" ");
// }
// Console.WriteLine();
// foreach (var i in nums) {
// Console.Write(Math.Pow(i, 2));
// Console.Write(" ");
// }
// }