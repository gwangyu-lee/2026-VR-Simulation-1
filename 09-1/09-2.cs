using System;
					
public class Program
{
	
	public class Player
	{
		public string name;
		public int hp;
		
		public Player(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
		}
		
		public void PrintStatus()
		{
			Console.WriteLine($"{name} / HP: {hp}");
		}
	}
	
	public static void Main()
	{
		static int ReadInt(string prompt)
		{
			Console.Write(prompt);
			return int.Parse(Console.ReadLine());
		}
		
		static string ReadString(string prompt)
		{
			Console.Write(prompt);
			return Console.ReadLine();
		}
		
		// string name = ReadString("이름 입력: ");
		// int hp = ReadInt("HP 입력: ");
	
		Player player = new Player(ReadString("이름 입력: "), ReadInt("HP 입력: "));
		player.PrintStatus();
	}
}