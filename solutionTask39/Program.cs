
// Метод заполнения массива случайными числами 
int[] FillingArray(int arrayLenght)
{
   int[] outArray =  new int[arrayLenght];
   int i = 0;
    System.Random numberSintezator = new Random();
    while(i<arrayLenght)
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


int[] ReversNewArray(int[]array)
{

int lenght = array.Length;
int[] newArray= new int[lenght];
for(int i=0;i<lenght;i++)
{

    newArray[lenght-1-i]=array[i];
}
return newArray;
}




int[]testArray=FillingArray(12);
PrintArray(testArray);
int[] reversArray=ReversNewArray(testArray);
PrintArray(reversArray);

