// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
		// M = 1; N = 15 -> 120
		// M = 4; N = 8. -> 30
		Console.WriteLine("Введите числло M: ");
		string? m1=Console.ReadLine();
		Console.WriteLine("Введите число N: ");
		string? n1=Console.ReadLine();

		int m=int.Parse(m1);
		int n=int.Parse(n1);
		
		int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; //  арифметической прогрессии
		}
		
		Console.WriteLine(CalculateSumm(m,n));
