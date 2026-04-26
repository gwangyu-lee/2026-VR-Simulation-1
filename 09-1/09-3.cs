using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("HP 입력: ");
		int hp = int.Parse(Console.ReadLine());
		
		if (hp < 50)
		{
			hp += 20;
		}
		Console.WriteLine(hp);
		
		Console.Write("이름 입력: ");
		string name = Console.ReadLine();
		Console.WriteLine($"안녕하세요, {name}님!");
	}
}