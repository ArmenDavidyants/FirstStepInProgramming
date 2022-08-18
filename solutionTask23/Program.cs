// выводит куб чисел последовательности
string? inputlineN = Console.ReadLine(); 
if (inputlineN != null)
{
    int numberN = int.Parse(inputlineN);

    string lineN="";
    string lineNN=string.Empty;
    int s=1;
    while(s<=numberN)
    {
        lineN=lineN+s+" ";
        lineNN=lineNN+s*s*s+" ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
