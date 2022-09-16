
// Метод заполнения массива случайными числами 
int[] FillingArray()
{
   int[] outArray =  new int[12];
   int i = 0;
    System.Random numberSintezator = new Random();
    while(i<12)
    {
        outArray[i]= numberSintezator.Next(100,1000);
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
int  CanculateTask(int [] inputArray) 

{
int sumNumber=0; 
int i = 0;

while(i<inputArray.Length)
{
  if(inputArray[i]%2==0)
  {
    sumNumber++;
  } 
  i++;
}

 return sumNumber;
}

int [] bufferArray=FillingArray();
PrintArray(bufferArray);
int amountOfnumbers=CanculateTask(bufferArray);
Console.WriteLine(amountOfnumbers);



