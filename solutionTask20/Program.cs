int coordXpointA;
int coordYpointA;
int coordXpointB;
int coordYpointB;
double lenghtAB;

//считывает координаты точек A B
void readDataOfPoint()
{
Console.WriteLine("Введите координаты Х точки А");
 coordXpointA= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
 coordYpointA= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Х точки B");
 coordXpointB= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
 coordYpointB= int.Parse(Console.ReadLine());

}

// вычисляет расстояние между точками A B
void conculateLenghtAB()
{
 lenghtAB = Math.Sqrt(Math.Pow((coordXpointA-coordXpointB),2)+Math.Pow((coordYpointA-coordYpointB),2));
}

readDataOfPoint();
conculateLenghtAB();
Console.WriteLine(lenghtAB);