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

// Метод решения задачи 37 наивный
int [] CanculateTask(int [] inputArray) 

{
 int [] resultArray = new int[inputArray.Length/2+1];
int i = 0;

while(i<resultArray.Length)
{
    i++;
    resultArray[i]=inputArray[i]*inputArray[inputArray.Length-1-i];
}

 return resultArray;
}

int [] bufferArray=FillingArray();
PrintArray(bufferArray);
int [] resultArray = CanculateTask(bufferArray);
PrintArray(resultArray);
