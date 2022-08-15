// метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
 string inputline=Console.ReadLine();

 //x=34; y=-30 ->4
 string coordXline=inputline.Substring(0,inputline.IndexOf(";"));
 coordXline=coordXline.Substring(coordXline.IndexOf("=")+1);

string coordYline=inputline.Substring(inputline.IndexOf(";")+1);
 coordYline=coordYline.Substring(coordYline.IndexOf("=")+1);

 //Console.WriteLine(coordX+" "+coordY);

 int coordX=int.Parse(coordXline);
 int coordY=int.Parse(coordYline);

 int[,] arrayOut=new int[1,2];

 arrayOut[0,0]=coordX;
 arrayOut[0,1]=coordY;

return arrayOut ;
}
//печатает номер четверти
void printeQUTER(int[,] arrayPoint)
{
if(arrayPoint[0,0]>0&&arrayPoint[0,1]>0)
Console.WriteLine("1 Четверть");

if(arrayPoint[0,0]<0&&arrayPoint[0,1]>0)
Console.WriteLine("2 Четверть");

if(arrayPoint[0,0]<0&&arrayPoint[0,1]<0)
Console.WriteLine("3 Четверть");

if(arrayPoint[0,0]>0&&arrayPoint[0,1]<0)
Console.WriteLine("4 Четверть");

}

int [,]arrayPoint=readPoint();

printeQUTER(arrayPoint);