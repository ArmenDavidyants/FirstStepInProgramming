// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
		// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
		// M = 4; N = 8. -> ""4, 6, 7, 8""
		Console.WriteLine("Введите числло M: ");
		string? m1=Console.ReadLine();
		Console.WriteLine("Введите число N: ");
		string? n1=Console.ReadLine();
        
        int m=int.Parse(m1);
		int n=int.Parse(n1);

		void PrintInterval(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			for(int i = start; i <= end; i++)
			{
				Console.Write($"{i} ");
			}
		}
		PrintInterval(m, n);
		
		Console.WriteLine();
