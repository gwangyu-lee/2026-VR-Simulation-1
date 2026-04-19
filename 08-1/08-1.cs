using System;
					
public class Program
{
	public class Player
	{
		public string name;
		public int hp;
		
		public void PrintStatus()
		{
			Console.WriteLine($"{name} / HP: {hp}");
		}
	}
	
	public class Character
	{
		public string name;
		protected int hp;
		
		public void PrintStatus()
		{
			Console.WriteLine($"{name} / HP: {hp}");
		}
	}
	
	public class Warrior : Character
	{
		public int attackPower;
	}
	
	public static void Main()
	{
		int hp = 100;
		int damage = 25;
		
		hp -= damage;
		hp -= damage;
		hp -= damage;
		Console.WriteLine(hp); // hp: 75
		
		bool hasPotion = true;
		
		if (hp < 50 && hasPotion)
		{
			Console.WriteLine("포션 사용 가능");
		}
		
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine(i);
		}
		
		int[] scores = {80, 90, 70};
		foreach (int score in scores)
		{
			Console.WriteLine(score);
		}
		
		for (int i = 0; i < 10; i++)
		{
			if (i == 3)
				continue;
			if (i == 7)
				break;
			Console.WriteLine(i);
		}
		
		static void PrintHp(int hp)
		{
			Console.WriteLine($"HP: {hp}");
		}
		PrintHp(100);
		PrintHp(20);
		
		static int Add(int a, int b)
		{
			return a + b;
		}
		int result = Add(3, 5);
		Console.WriteLine(result);
		
		Player gwangyu = new Player();
		gwangyu.name = "Gwangyu";
		gwangyu.hp = 100;
		gwangyu.PrintStatus();
		
		Player induk = new Player();
		induk.name = "Induk";
		induk.hp = 300;
		induk.PrintStatus();
		
		Warrior warrior = new Warrior();
		warrior.name = "Gwangyu";
		warrior.attackPower = 30;
		warrior.PrintStatus();
	}
}