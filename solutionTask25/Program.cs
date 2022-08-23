int numberA=0;
int numberB=0;
int numberC=0;

void Read ()
{


Console.Write("ВВедите число а: ");  numberA= int.Parse(Console.ReadLine());

Console.Write("ВВедите число b: ");  numberB= int.Parse(Console.ReadLine()); 
}


 
 int Conculate()
 {
numberC=(int)Math.Pow(numberA,numberB);

return numberC;
 }
 
Read();
Conculate();
Console.WriteLine(numberC);
 
 





