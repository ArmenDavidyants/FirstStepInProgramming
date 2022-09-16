// Метод заполнения массива случайными числами от -9 до 9
int[] FillingArray()
{
   int[] outArray =  new int[12];
   int i = 0;
    System.Random numberSintezator = new Random();
    while(i<12)
    {
        outArray[i]= numberSintezator.Next(-9,10);
        i++;

    }
    return outArray;
}


//метод печатает массив
void PrintArray(int[] inputArray)
{
    int i = 0;
    while(i<inputArray.Length-1)
    {
        Console.Write(inputArray[i]+", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

// Метод решения задачи 33 наивный
bool  CanculateTask(int [] inputArray,int searchNumber) 

{
 bool  resaultSearch = false;
 int i =0;
 while(i<12)
 {
   if(inputArray[i]== searchNumber)
   {
    resaultSearch=true;
    break;
   }
   i++;

 }
 return resaultSearch;
 }

 int [] bufferArray=FillingArray();
PrintArray(bufferArray);
Console.WriteLine("Введите число ");
int searchNumber=int.Parse(Console.ReadLine());

Console.Write(CanculateTask(bufferArray,searchNumber));