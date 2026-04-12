using System;
					
public class Program
{
	// 부모
	public class Enemy
	{
		public string name;
		public int hp;
		
		public Enemy(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
		}
		
		public virtual void Attack()
		{
			Console.WriteLine($"{name}이 공격");
		}
		
		public void TakeDamage(int damage)
		{
			hp -= damage;
			if (hp < 0) hp = 0;
			Console.WriteLine($"{name} HP: {hp}");
		}
	}
	
	// 자식
	public class Goblin : Enemy
	{
		public Goblin() : base("Goblin", 30) { }
		
		public override void Attack()
		{
			Console.WriteLine($"{name}이(가) 단검으로 찌른다!");
		}
	}

	// 자식
	public class Dragon : Enemy
	{
		public Dragon() : base("Dragon", 500) { }

		public override void Attack()
		{
			Console.WriteLine($"{name}이(가) 화염 브레스를 내뿜는다!");
		}
	}
	
	public static void Main()
	{
		Enemy[] enemies = { new Goblin(), new Dragon() };
		
		foreach (Enemy e in enemies)
		{
			e.Attack();
			e.TakeDamage(10);
		}
	}
}