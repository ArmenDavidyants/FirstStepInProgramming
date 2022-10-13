int sideA=0;
int sideB=0;
int sideC=0;

Readsides();
bool res = TestTreangle(sideA,sideB,sideC);
PrintAnswer(res);




void Readsides ()
{
Console.Write("Введите число 1: ");
 sideA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число 2: ");
 sideB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число 3: ");
 sideC = int.Parse(Console.ReadLine() ?? "");
}

bool TestTreangle(int num1,int num2,int num3)
{
   bool answer = ((num1 + num2 > num3) && (num2 + num3 > num1) && (num1 + num3 > num2)) ? true : false; 
return answer;
}

void PrintAnswer(bool answer)
{
if(answer)
{
  Console.WriteLine("Из этих можно собрать треугольник");
}
else
{
Console.WriteLine("Из этих нельзя собрать треугольник");
}
}





