int negativSum = 0;
int positivSum = 0;
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

// Метод подсчета количества (-) и (+) чисел
void CanculateTask(int [] outArray) 
{
 int i = 0;
 while(i<12)
 {  
 if(outArray[i]>0)
 {
    positivSum++;
 }
 else
 {
    negativSum++;
 }
 i++;
 }
}

//Вывод количества (-) и (+) чисел
void PrintResult()
{
 Console.WriteLine(negativSum);
 Console.WriteLine(positivSum);
}   

// Метод решения задачи 31
void VarianteNaive()
{
int [] buferArray = FillingArray();
CanculateTask(buferArray);
PrintResult();


}  
VarianteNaive();