using System;
using System.Collections.Generic; //list관련 코드 가져오기
					
public class Program
{
	public static void Main()
	{
		// Modulo
		Console.WriteLine(303%3);
		
		// 배열
		int[] scores = {80, 90, 70, 85, 60};
		// int 정수를 선언할건데
		// [] 배열로 할거고
		// 순서!
		
		Console.WriteLine(scores[0]);
		Console.WriteLine(scores[3]);
		Console.WriteLine(scores.Length);
		
		// 점문법 Dot Syntax
		// 인덕대.학과
		
		Console.WriteLine(scores[1]); // 여기까지는 90인데
		scores[1] = 10; // 이순간부터 10
		Console.WriteLine(scores[1]);
		
		List<int> scoresList = new List<int> {80, 90, 70};
		
		Console.WriteLine(scoresList.Count);
		scoresList.Add(85); // 80, 90, 70, 85
		Console.WriteLine(scoresList.Count);
		scoresList.Remove(80);
		Console.WriteLine($"리스트 길이: {scoresList.Count}");
		// 리스티 길이: 3
		
		// 반복문
		// for (초기화(변수선언); 조건; 증감(매 반복 후 실행))
		for (int i = 3; i < 5; i++)
		{
			Console.WriteLine(i);
		}

		// while
		
		int count = 0;
		while (count < 3)
		{
			// count++
			Console.WriteLine(count);
			// count++;
			// count++;
			count = count + 1;
		}
		
		// do-while
		int count1 = 30;
		do
		{
			Console.WriteLine($"do-while: {count1}");
			count1++;
		} while (count1<3);
		
		// foreach
		foreach (int score in scores)
		{
			Console.WriteLine(score);
		}
		
		// break, continue
		for (int i = 0; i < 10; i++)
		{
			if (i==5)
				break;
			Console.WriteLine(i);
		}
		
		for (int i = 0; i < 5; i++)
		{
			if (i==2)
				continue;
			Console.WriteLine(i);
		}
		
		for (int i = 0; i < scores.Length; i++)
		{
			Console.WriteLine($"scores[{i}] = {scores[i]}");
			// scores[0] = 80 ...
		}
		
		int sum = 0;
		foreach (int score in scores)
		{
			sum += score;
			// sum = sum + score;
		}
		Console.WriteLine($"합계: {sum}");
		Console.WriteLine($"평균: {sum/5}");
		
		foreach (int score in scores)
		{
			if (score>=80)
				Console.WriteLine($"{score} -> PASS!!");
			else
				Console.WriteLine($"{score} -> FAIL!!");
		}
		
		for (int x = 0; x < 3; x++)
		{
			for (int y = 0; y < 2; y++)
			{
				Console.WriteLine($"({x}, {y})");
				// 00 01 
			}
		}
		
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if (i == j)
					Console.Write("*");
				else
					Console.Write("-");
			}
			Console.WriteLine();
		}
		
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if( (i+j) % 2 == 0)
					Console.Write("#");
				else
					Console.Write(".");
			}
			Console.WriteLine();
		}
		
	}
}