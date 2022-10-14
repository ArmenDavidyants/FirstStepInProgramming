/// Возвращает точку пересечения по оси ОХ двух прямых.

float GetPointIntersectionOX(int k1, int b1, int k2, int b2)
    => (float)(b2 - b1) / 
       (k1 - k2);


/// Возвращает точку пересечения по оси ОY двух прямых по известной точке пересечения по оси ОХ.

float GetPointIntersectionOY(int k, int b, float x)
    => b + k * x;

Console.Write("Введите b1:");
var b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1:");
var k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2:");
var b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2:");
var k2 = int.Parse(Console.ReadLine());

var pointIntersectionOX = GetPointIntersectionOX(k1, b1, k2, b2);
var pointIntersectionOY = GetPointIntersectionOY(k1, b1, pointIntersectionOX);
Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({pointIntersectionOX}; {pointIntersectionOY})");
