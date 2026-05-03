using System;

public class Player
{
	public string name;
	public int hp;
	
	public Player(string name, int hp)
	{
		this.name = name;
		this.hp = hp;
	}
}

public class Monster
{
	public string name;
	public int hp;
	
	public Monster(string name, int hp)
	{
		this.name = name;
		this.hp = hp;
	}
}
					
public class Program
{
	public static void Main()
	{
		// RANDOM
		// Random random = new Random();
		// int damage = random.Next(0, 2);
		// Console.WriteLine(damage);
		
		static Monster CreateRandomMonster(Random random)
		{
			int value = random.Next(0, 3);
			if (value == 0)
				return new Monster("슬라임", 300);
			else if (value == 1)
				return new Monster("고블린", 400);
			else
				return new Monster("리본돼지", 500);
		}
		
		
		
		Console.Write("이름을 입력하세요: ");
		string playerName = Console.ReadLine();
		Player player = new Player(playerName, 100);
		
		Random random = new Random();
		Monster monster = CreateRandomMonster(random);
		
		Console.WriteLine($"{monster.name} 등장! HP: {monster.hp}");
		
		while (player.hp > 0 && monster.hp > 0)
		{
			Console.WriteLine("---");
			Console.WriteLine("1. 공격");
			Console.WriteLine("2. 물약");
			Console.WriteLine("0. 종료");
			Console.Write("선택: ");
			
			string choice = Console.ReadLine();
			if (choice == "0")
			{
				Console.WriteLine("게임 종료");
				break;
			}
			
			if (choice == "1")
			{
				int playerDamage = random.Next(10, 16);
				monster.hp -= playerDamage;
				Console.WriteLine($"{player.name}의 공격! {playerDamage}!!");
				Console.WriteLine($"{monster.name} HP: {monster.hp}");
				if (monster.hp > 0)
				{
					int monsterDamage = random.Next(50, 110);
					player.hp -= monsterDamage;
					if (player.hp < 0)
						player.hp = 0;
					Console.WriteLine($"{monster.name}의 공격! {monsterDamage}!!");
					Console.WriteLine($"{player.name} HP: {player.hp}");
				}
			}
			
			if (choice == "2")
			{
				player.hp += 40;
				Console.WriteLine("물약을 먹는다!");
				Console.WriteLine($"{player.name} HP: {player.hp}");
			}
		}
		
		Console.WriteLine();
		if (player.hp <= 0)
			Console.WriteLine("패배!");
		else if (monster.hp <= 0)
			Console.WriteLine("승리!");

	}
}