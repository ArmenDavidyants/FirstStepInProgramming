
//Метод заполнения двумерного массива
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



//Метод печати двумерного массива
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

ConsoleColor[] col =  new ConsoleColor[]
{
    ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,
    ConsoleColor.DarkGray,ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,
    ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow
};
//Метод печати цветного двумерного массива
void PrintColorArray2(int[,] inputArray)
{
    int i = 0; int j=0;
   
    while(i<inputArray.GetLength(0))
    {
        j=0;
       while(j<inputArray.GetLength(1))
       {
        Console.ForegroundColor=col[new System.Random().Next(0,16)];
        Console.Write(inputArray[i,j] + " ");
        Console.ResetColor();
        j++;
       }
        Console.WriteLine();
        i++;
    }
    
}


int [,] twoDimArray=FillingArray2(5,8);
PrintArray2(twoDimArray);
Console.WriteLine();
PrintColorArray2(twoDimArray);