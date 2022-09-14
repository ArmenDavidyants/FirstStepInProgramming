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



// Метод инвертирует элементы массива
int [] CanculateTask(int [] inputArray) 

{
 int [] outputArray = new int[12];  
 int i = 0;
 while(i<12)
 {
    outputArray[i]=inputArray[i]*(-1);
    i++;
 }
 return outputArray;
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

int [] bufferArray=FillingArray();
PrintArray(bufferArray);
int[] resultArray=CanculateTask(bufferArray);
PrintArray(resultArray);
