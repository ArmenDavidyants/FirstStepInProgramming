// Метод заполнения массива случайными числами 
int[] FillingArray()
{
   int[] outArray =  new int[123];
   int i = 0;
    System.Random numberSintezator = new Random();
    while(i<123)
    {
        outArray[i]= numberSintezator.Next(-1000,1000);
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

// Метод решения задачи 35 наивный
int  CanculateTask(int [] inputArray,int downBorder, int upBorder) 

{
 int resaultCount = 0;
 int i =0;
 while(i<inputArray.Length)
 {
   if(inputArray[i]>= downBorder && inputArray[i]<=upBorder)
   {
    Console.WriteLine(inputArray[i]);
    resaultCount++;
    
   }
   i++;

 }
 return resaultCount;
 }

int [] bufferArray=FillingArray();
PrintArray(bufferArray);
Console.Write(CanculateTask(bufferArray,10,99));