using System;
					
public class Program
{
	public static void Main()
	{
		static void SayHello()
		{
			Console.WriteLine("안녕하세요!");
			Console.WriteLine("이관규입니다.");
		}
		
		SayHello();
		SayHello();
		
		static void Greet(string name)
		{
			Console.WriteLine("안녕하세요!");
			Console.WriteLine($"{name}입니다.");
		}
		
		Greet("이관규");
		Greet("유니티");
		
		static void PrintScore(string name, int score)
		{
			Console.WriteLine($"{name}: {score}점");
		}
		
		PrintScore("이관규", 100);
		PrintScore("유니티", 50);
		PrintScore("250", 100);
		
		static int Add(int a, int b)
		{
			Console.WriteLine($"Add! {a} + {b}");
			return a + b;
		}
		
		int result = Add(3, 5);
		Console.WriteLine(result);
		
		static double Average(int a, int b, int c)
		{
			return (a + b + c) / 3.0;
		}
		Console.WriteLine($"평균: {Average(80, 90, 70)}");
		
		static void PrintDouble(int n)
		{
			Console.WriteLine(n * 2);
		}
		PrintDouble(5);

		static int Double(int n)
		{
			return n*2;
		}
		Console.WriteLine(Double(10));
		
		static void PrintScoreWithDefault(string name, int score = 0)
		{
			Console.WriteLine($"{name}: {score}점");
		}
		
		PrintScoreWithDefault("이관규");
		PrintScoreWithDefault("유니티", 50);
		
		int a = 10;
		int b = 100;
		
		static void MethodA()
		{
			int x = 10;
			Console.WriteLine(x);
		}
		MethodA();
		
		static string GetGrade(int score)
		{
			if (score >= 90)
				return "A";
			else if (score >= 80)
				return "B";
			else if (score >= 70)
				return "C";
			else
				return "F";
		}
		
		Console.WriteLine(GetGrade(15));
		
		int[] scores = {80, 90, 70, 85, 60};
		static int Sum(int[] arr)
		{
			int total = 0;
			foreach (int n in arr)
			{
				total +=n;
				// total = total + n
			}
			return total;
		}
		static double Average2(int[] arr)
		{
			return Sum(arr) / (double)arr.Length;
		}
		static int Max(int[] arr)
		{
			int max = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > max)
					max = arr[i];
			}
			return max;
		}
		Console.WriteLine($"Sum: {Sum(scores)}");
		Console.WriteLine($"Average: {Average2(scores)}");
		Console.WriteLine($"Maximum: {Max(scores)}");
		
		static void CreateCharacter(string name, int hp, int speed)
		{
			Console.WriteLine($"이름: {name}, HP: {hp}, Speed: {speed}");
		}
		CreateCharacter("이관규", 100, 100);
		CreateCharacter(hp: 90, speed: 90, name: "유니티");
		
		static void PrintInfo(string name, int level = 1, bool isActive = true)
		{
			Console.WriteLine($"{name} / lv.{level} / 활성: {isActive}");
		}
		PrintInfo("이관규");
		PrintInfo("유니티", level: 10);
		PrintInfo("씨샵", isActive: false);
		
		static int Factorial(int n)
		{
			if (n <= 1)
				return 1;
			return n * Factorial(n-1);
		}
		Console.WriteLine(Factorial(5));
		
		static int Sum2(int n)
		{
			if (n <= 0)
				return 0;
			return n + Sum2(n-1);
		}
		Console.WriteLine(Sum2(10));
	}
}