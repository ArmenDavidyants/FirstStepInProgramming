// Метод заполнения массива случайными числами 
int[] FillingArray()
{
   int[] outArray =  new int[12];
   int i = 0;
    System.Random numberSintezator = new Random();
    while(i<12)
    {
        outArray[i]= numberSintezator.Next(10,1000);
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




// Метод решения задачи 38 наивный
int  CanculateTask(int [] inputArray) 

{
int maxNumber=0; 
int minNumber =int.MaxValue ;
int i=0;
while(i<inputArray.Length)
{
  if(inputArray[i]>maxNumber)
  {
    maxNumber=inputArray[i];
  }
  if(inputArray[i]<minNumber)
  {
    minNumber=inputArray[i];
  }
  
  
  i++;
}

 return (maxNumber-minNumber);
}

int [] bufferArray=FillingArray();
PrintArray(bufferArray);
int sumNumber=CanculateTask(bufferArray);
Console.WriteLine(sumNumber);

