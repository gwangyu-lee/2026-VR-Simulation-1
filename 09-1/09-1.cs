using System;
					
public class Program
{
	public static void Main()
	{
		// Console.WriteLine("이름을 입력하세요");
		// string name = Console.ReadLine();
		// Console.WriteLine($"이름: {name}");
		
		// string input = Console.ReadLine();
		// int hp = int.Parse(input);
		
		// 한줄로
		// int hp = 2 * int.Parse(Console.ReadLine());
		// Console.WriteLine($"입력 곱하기 2");
		// Console.WriteLine($"HP: {hp}");
		
		Console.Write("HP 입력: ");
		int hp = int.Parse(Console.ReadLine());
		if (hp <= 0)
		{
			Console.WriteLine("사망");
		}
		else if (hp < 50)
		{
			Console.WriteLine("위험");
		}
		else
		{
			Console.WriteLine("정상");
		}
		
		Console.Write("직업 입력 (Warrior / Mage): ");
		string job = Console.ReadLine();
		
		switch(job)
		{
			case "Warrior":
				Console.WriteLine("검 공격");
				break;
			case "Mage":
				Console.WriteLine("마법 공격");
				break;
			default:
				Console.WriteLine("알 수 없는 직업");
				break;
		}
		
		int[] scores = new int[3];
		for (int i = 0; i < 3; i++)
		{
			Console.Write($"점수 {i + 1} 입력:");
			scores[i] = int.Parse(Console.ReadLine());
		}
		foreach (int score in scores)
		{
			Console.WriteLine(score);
		}
		
		hp = -1;
		while (hp < 0 || hp > 100)
		{
			Console.Write("HP 입력 (0-100): ");
			hp = int.Parse(Console.ReadLine());
		}
		Console.WriteLine($"HP: {hp}");
	}
}