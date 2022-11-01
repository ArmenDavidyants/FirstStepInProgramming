int[,] FillingArray2(int countRow, int countColumn)
{
   
    System.Random numberSintezator = new Random();

    int i = 0; int j = 0;

    int [,] outArray = new int[countRow,countColumn];

    while(i<countRow)
    {
        j=0;
        while(j<countColumn)
         {
            outArray[i,j]=numberSintezator.Next(0,100);
             j++;
         }
     i++;
       
    }
     return outArray;

}


void PrintArray2(int[,] inputArray)
{
    int i = 0; int j=0;
    while(i<inputArray.GetLength(0))
    {
        j=0;
       while(j<inputArray.GetLength(1))
       {
        Console.Write(inputArray[i,j] + " ");
        j++;
       }
        Console.WriteLine();
        i++;
    }
}




int  CalcDiagTwoDimArr( int[,] inputArray)
{
    int outSumDiag= 0;
    int i = 0; 
   
    while(i<inputArray.GetLength(0))
    {
        
       outSumDiag+=inputArray[i,i];
       i++; 
    
    }
    return outSumDiag;
    }


int [,] twoDimArray=FillingArray2(5,5);


PrintArray2(twoDimArray);

int sum =CalcDiagTwoDimArr(twoDimArray);
Console.WriteLine(sum);
