using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("---학생 평균 계산 프로그램---");
		Console.Write("학생은 몇 명인가요?(숫자만 입력하세요)");
		int length = int.Parse(Console.ReadLine());
		int[] scores = new int[length];
		
		for (int i = 0; i < length; i++)
		{
			Console.Write($"{i + 1}번 학생 점수: ");
			scores[i] = int.Parse(Console.ReadLine());
		}
		
		int total = 0;
		foreach (int score in scores)
		{
			total += score;
		}
		
		double average = total / (double)scores.Length;
		Console.WriteLine($"평균: {average}점");
	}
}