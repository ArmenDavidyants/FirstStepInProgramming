int coordXpointA;
int coordYpointA;
int coordXpointB;
int coordYpointB;
int coordZpointA;
int coordZpointB;
double lenghtAB;
Console.WriteLine("Введите координаты Х точки А");
 coordXpointA= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
 coordYpointA= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки A");
 coordZpointA= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X точки B");
 coordXpointB= int.Parse(Console.ReadLine());

 Console.WriteLine("Введите координаты Y точки B");
 coordYpointB= int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки B");
 coordZpointB= int.Parse(Console.ReadLine());

lenghtAB = Math.Sqrt(Math.Pow((coordXpointA-coordXpointB),2)+Math.Pow((coordYpointA-coordYpointB),2)+Math.Pow((coordZpointA-coordZpointB),2));



Console.WriteLine(lenghtAB);

