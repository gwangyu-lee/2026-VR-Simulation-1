## 랜덤 숫자 배틀 게임

이번 시간에는 `Random`을 이용해
**결과가 매번 달라지는 간단한 콘솔 게임**을 만든다.

이전 수업처럼 상속 구조를 크게 만들지 않고,
`Player`, `Monster` 두 클래스만 사용해서 짧게 완성하는 것이 목표다.

---

## 오늘 목표

- `Random`을 사용할 수 있다
- 입력, 조건문, 반복문을 게임 흐름에 넣을 수 있다
- 클래스를 간단하게 만들어 사용할 수 있다

---

## 오늘 만들 게임

게임 흐름:

1. 이름을 입력한다
2. 랜덤 몬스터가 등장한다
3. 공격 또는 종료를 선택한다
4. 공격 데미지가 랜덤하게 결정된다
5. 누군가의 HP가 0이 되면 끝난다

예시:

```text
이름을 입력하세요: Gwangyu
고블린 등장! HP: 40

1. 공격
0. 종료
선택: 1

Gwangyu의 공격! 13 데미지!
고블린 HP: 27
고블린의 반격! 8 데미지!
Gwangyu HP: 92
```

---

## Random 기본

랜덤값을 만들려면 `Random` 객체를 만든다.

```csharp
Random random = new Random();
```

숫자를 뽑을 때는 `Next()`를 사용한다.

```csharp
int damage = random.Next(5, 11);
```

> `random.Next(5, 11)`은 `5` 이상 `11` 미만,
> 즉 `5`부터 `10` 사이 숫자 중 하나를 반환한다.

---

## 클래스 구조

이번 게임에서는 클래스 구조를 단순하게 가져간다.

| 클래스 | 역할 |
|--------|------|
| `Player` | 이름과 HP 저장 |
| `Monster` | 이름과 HP 저장 |
| `Program` | 게임 진행 |

---

## Player 클래스

```csharp
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
```

---

## Monster 클래스

```csharp
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
```

---

## 랜덤 몬스터 만들기

메서드 하나로 몬스터를 랜덤 생성한다.

```csharp
static Monster CreateRandomMonster(Random random)
{
    int value = random.Next(0, 2);

    if (value == 0)
        return new Monster("슬라임", 30);
    else
        return new Monster("고블린", 40);
}
```

---

## 공격 처리

플레이어와 몬스터의 공격 데미지를 랜덤하게 만든다.

```csharp
int playerDamage = random.Next(10, 16);   // 10~15
int monsterDamage = random.Next(5, 11);   // 5~10
```

HP를 깎을 때는 음수가 되지 않게 처리한다.

```csharp
monster.hp -= playerDamage;

if (monster.hp < 0)
    monster.hp = 0;
```

---

## 전체 예제

```csharp
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
    static Monster CreateRandomMonster(Random random)
    {
        int value = random.Next(0, 2);

        if (value == 0)
            return new Monster("슬라임", 30);
        else
            return new Monster("고블린", 40);
    }

    public static void Main()
    {
        Random random = new Random();

        Console.Write("이름을 입력하세요: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName, 100);
        Monster monster = CreateRandomMonster(random);

        Console.WriteLine($"{monster.name} 등장! HP: {monster.hp}");

        while (player.hp > 0 && monster.hp > 0)
        {
            Console.WriteLine();
            Console.WriteLine("1. 공격");
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

                if (monster.hp < 0)
                    monster.hp = 0;

                Console.WriteLine($"{player.name}의 공격! {playerDamage} 데미지!");
                Console.WriteLine($"{monster.name} HP: {monster.hp}");

                if (monster.hp > 0)
                {
                    int monsterDamage = random.Next(5, 11);
                    player.hp -= monsterDamage;

                    if (player.hp < 0)
                        player.hp = 0;

                    Console.WriteLine($"{monster.name}의 반격! {monsterDamage} 데미지!");
                    Console.WriteLine($"{player.name} HP: {player.hp}");
                }
            }
        }

        Console.WriteLine();

        if (player.hp <= 0)
            Console.WriteLine("패배했습니다.");
        else if (monster.hp <= 0)
            Console.WriteLine("승리했습니다!");
    }
}
```

---

## 이 코드에서 복습되는 문법

| 문법 | 예시 |
|------|------|
| 입력 | `Console.ReadLine()` |
| 클래스 | `Player`, `Monster` |
| 생성자 | `new Player(...)` |
| 조건문 | `if (choice == "1")` |
| 반복문 | `while (player.hp > 0 && monster.hp > 0)` |
| 랜덤값 | `random.Next(...)` |
