## 08-1 C# 기초 복습

이번 시간은 `01-1`부터 `07-1`까지 배운 C# 기초 문법을 다시 정리하고,
하나의 작은 예제로 연결해보는 복습 시간이다.

> 목표는 새로운 문법을 배우는 것이 아니라,
> 지금까지 배운 내용을 **스스로 읽고, 고치고, 조합할 수 있는지** 확인하는 것이다.

---

## 지금까지 배운 내용 요약

| 주차 | 핵심 내용 |
|------|-----------|
| 01-1 | 토큰, 리터럴, 타입, 변수, 식별자 |
| 02-1 | 연산자, 상수, 스코프, 부동소수점 |
| 03-1 | 조건문, 논리 연산자, switch, 삼항 연산자 |
| 04-1 | 배열, 리스트, 문자열 보간, 반복문 |
| 05-1 | 메서드, 매개변수, 반환값, 오버로딩 |
| 06-1 | 클래스, 객체, 필드, 생성자, this, 접근 제한자 |
| 07-1 | 상속, base, virtual, override, protected, 다형성 |

---

## 변수와 타입 복습

변수는 값을 저장하는 이름 있는 공간이다.
변수에는 타입이 있으며, 타입에 따라 저장할 수 있는 값의 종류가 달라진다.

```csharp
int hp = 100;
float speed = 3.5f;
double accuracy = 0.95;
bool isAlive = true;
string playerName = "Gwangyu";
char grade = 'A';
```

| 타입 | 의미 | 예시 |
|------|------|------|
| `int` | 정수 | `100` |
| `float` | 소수 | `3.5f` |
| `double` | 더 정밀한 소수 | `0.95` |
| `bool` | 참/거짓 | `true`, `false` |
| `string` | 문자열 | `"Knight"` |
| `char` | 문자 하나 | `'A'` |

> Unity에서는 위치, 속도, 시간 같은 값에 `float`를 자주 사용한다.
> `float` 리터럴에는 `f`를 붙인다.

---

## 연산자 복습

연산자는 값을 계산하거나 비교할 때 사용한다.

```csharp
int hp = 100;
int damage = 25;

hp = hp - damage;
Console.WriteLine(hp);  // 75
```

**복합 대입 연산자**

```csharp
hp -= damage;  // hp = hp - damage
hp += 10;      // hp = hp + 10
hp *= 2;       // hp = hp * 2
```

**비교 연산자**

```csharp
bool isDead = hp <= 0;
bool isFullHp = hp == 100;
bool needsHeal = hp < 50;
```

| 연산자 | 의미 |
|--------|------|
| `+`, `-`, `*`, `/` | 산술 연산 |
| `=` | 대입 |
| `==`, `!=` | 같다, 다르다 |
| `>`, `<`, `>=`, `<=` | 크기 비교 |
| `&&` | AND |
| `||` | OR |
| `!` | NOT |

---

## 조건문 복습

조건문은 상황에 따라 다른 코드를 실행할 때 사용한다.

```csharp
int hp = 35;

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
```

> `if` 조건식의 결과는 반드시 `bool`이어야 한다.

**논리 연산자와 함께 사용**

```csharp
int hp = 30;
bool hasPotion = true;

if (hp < 50 && hasPotion)
{
    Console.WriteLine("포션 사용 가능");
}
```

**switch 문**

```csharp
string job = "Warrior";

switch (job)
{
    case "Warrior":
        Console.WriteLine("검 공격");
        break;
    case "Mage":
        Console.WriteLine("마법 공격");
        break;
    default:
        Console.WriteLine("기본 공격");
        break;
}
```

---

## 반복문 복습

반복문은 같은 작업을 여러 번 실행할 때 사용한다.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

| 반복문 | 사용 상황 |
|--------|-----------|
| `for` | 반복 횟수가 명확할 때 |
| `while` | 조건이 유지되는 동안 반복 |
| `do-while` | 최소 한 번 실행 |
| `foreach` | 배열이나 리스트 전체 순회 |

**배열과 foreach**

```csharp
int[] scores = { 80, 90, 70 };

foreach (int score in scores)
{
    Console.WriteLine(score);
}
```

**break와 continue**

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 3)
        continue;

    if (i == 7)
        break;

    Console.WriteLine(i);
}
```

> `continue`는 이번 반복만 건너뛰고, `break`는 반복문 전체를 종료한다.

---

## 배열과 리스트 복습

배열은 같은 타입의 값을 여러 개 저장하는 자료구조다.

```csharp
int[] damages = { 10, 20, 15, 30 };

Console.WriteLine(damages[0]);      // 10
Console.WriteLine(damages.Length);  // 4
```

배열은 크기가 고정되어 있다.
값을 추가하거나 삭제해야 한다면 `List<T>`를 사용한다.

```csharp
List<string> items = new List<string>();

items.Add("Potion");
items.Add("Sword");
items.Remove("Potion");

Console.WriteLine(items.Count);  // 1
```

| 구분 | 배열 | 리스트 |
|------|------|--------|
| 선언 | `int[]` | `List<int>` |
| 크기 | 고정 | 변경 가능 |
| 개수 | `.Length` | `.Count` |
| 추가 | 불가 | `.Add()` |
| 삭제 | 불가 | `.Remove()` |

---

## 메서드 복습

메서드는 특정 작업을 수행하는 코드 블록이다.
반복되는 코드를 메서드로 묶으면 재사용할 수 있다.

```csharp
static void PrintHp(int hp)
{
    Console.WriteLine($"HP: {hp}");
}

PrintHp(100);
PrintHp(50);
```

**반환값이 있는 메서드**

```csharp
static int Add(int a, int b)
{
    return a + b;
}

int result = Add(3, 5);
Console.WriteLine(result);  // 8
```

**배열을 받는 메서드**

```csharp
static int Sum(int[] numbers)
{
    int total = 0;

    foreach (int n in numbers)
    {
        total += n;
    }

    return total;
}

int[] scores = { 80, 90, 70 };
Console.WriteLine(Sum(scores));  // 240
```

> 메서드는 입력, 처리, 출력으로 나눠 생각하면 이해하기 쉽다.

---

## 클래스와 객체 복습

클래스는 객체를 만들기 위한 설계도다.
객체는 클래스로 만든 실제 대상이다.

```csharp
public class Player
{
    public string name;
    public int hp;

    public void PrintStatus()
    {
        Console.WriteLine($"{name} / HP: {hp}");
    }
}
```

```csharp
Player player = new Player();
player.name = "Knight";
player.hp = 100;
player.PrintStatus();
```

| 용어 | 의미 |
|------|------|
| 클래스 | 설계도 |
| 객체 | 설계도로 만든 실제 대상 |
| 필드 | 객체가 가지는 데이터 |
| 메서드 | 객체가 수행하는 동작 |

---

## 생성자와 this 복습

생성자는 객체가 만들어질 때 자동으로 실행되는 특별한 메서드다.
객체의 초기값을 설정할 때 사용한다.

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

```csharp
Player player = new Player("Knight", 100);
Console.WriteLine(player.name);  // Knight
```

> `this.name`은 현재 객체의 필드 `name`을 의미한다.
> 오른쪽 `name`은 생성자의 매개변수다.

**this가 필요한 이유**

```csharp
public Player(string name)
{
    name = name;       // 둘 다 매개변수 name
    this.name = name;  // 필드 name = 매개변수 name
}
```

---

## 접근 제한자 복습

접근 제한자는 필드나 메서드에 접근할 수 있는 범위를 정한다.

| 키워드 | 접근 범위 |
|--------|-----------|
| `public` | 어디서든 접근 가능 |
| `private` | 자기 클래스 내부에서만 접근 가능 |
| `protected` | 자기 클래스와 자식 클래스에서 접근 가능 |

```csharp
public class Player
{
    public string name;
    private int hp;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 0)
            hp = 0;
    }
}
```

> 중요한 값은 `private`으로 숨기고, 메서드를 통해 안전하게 바꾸는 것이 좋다.

---

## 상속 복습

상속은 부모 클래스의 필드와 메서드를 자식 클래스가 물려받는 것이다.

```csharp
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
```

```csharp
Warrior warrior = new Warrior();
warrior.name = "Knight";
warrior.attackPower = 30;
warrior.PrintStatus();
```

> 공통 기능은 부모 클래스에 두고, 자식 클래스는 필요한 기능만 추가한다.

---

## base, virtual, override 복습

`base`는 부모 클래스에 접근할 때 사용한다.
`virtual`과 `override`는 부모 메서드를 자식에서 다르게 동작하게 만들 때 사용한다.

```csharp
public class Character
{
    public string name;

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격한다!");
    }
}

public class Mage : Character
{
    public Mage(string name) : base(name) { }

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 마법을 시전한다!");
    }
}
```

```csharp
Mage mage = new Mage("Wizard");
mage.Attack();  // Wizard이(가) 마법을 시전한다!
```

| 키워드 | 역할 |
|--------|------|
| `base(...)` | 부모 생성자 호출 |
| `base.Method()` | 부모 메서드 호출 |
| `virtual` | 자식에서 재정의 가능 |
| `override` | 부모 메서드 재정의 |

---

## 다형성 복습

다형성은 부모 타입으로 자식 객체를 다루는 것이다.
같은 메서드를 호출해도 실제 객체 타입에 따라 다른 동작이 실행된다.

```csharp
Character[] party =
{
    new Character("Archer"),
    new Mage("Wizard")
};

foreach (Character c in party)
{
    c.Attack();
}
```

> 배열 타입은 `Character`지만, 실제 객체가 `Mage`이면 `Mage`의 `Attack()`이 실행된다.

---

## 실습 1 - 출력 예상하기

다음 코드의 출력 결과를 예상해보자.

```csharp
int hp = 40;
bool hasPotion = true;

if (hp < 50 && hasPotion)
{
    hp += 30;
}

Console.WriteLine(hp);
```

예상:

```text
70
```

---

## 실습 2 - 빈칸 채우기

아래 코드가 `Goblin이(가) 공격!`을 출력하도록 빈칸을 채워보자.

```csharp
public class Enemy
{
    public string name;

    public Enemy(string name)
    {
        this.name = name;
    }

    public void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격!");
    }
}

Enemy enemy = new Enemy("Goblin");
enemy.Attack();
```

확인할 것:

- 생성자 이름은 클래스 이름과 같다
- `this.name`은 필드다
- `"Goblin"`은 생성자의 인수다

---

## 실습 3 - 메서드로 분리하기

아래 코드는 점수 배열의 평균을 구한다.
합계 계산 부분을 메서드로 분리해보자.

```csharp
int[] scores = { 80, 90, 70 };

int total = 0;
foreach (int score in scores)
{
    total += score;
}

double average = total / (double)scores.Length;
Console.WriteLine(average);
```

분리 후:

```csharp
static int Sum(int[] numbers)
{
    int total = 0;

    foreach (int n in numbers)
    {
        total += n;
    }

    return total;
}

int[] scores = { 80, 90, 70 };
int total = Sum(scores);
double average = total / (double)scores.Length;
Console.WriteLine(average);
```

---

## 자주 헷갈리는 부분

| 헷갈리는 내용 | 정리 |
|---------------|------|
| `=`와 `==` | `=`는 대입, `==`는 비교 |
| `float` 리터럴 | `3.5f`처럼 `f`를 붙인다 |
| 배열 인덱스 | 0부터 시작한다 |
| `void` | 반환값이 없다는 뜻 |
| `return` | 값을 반환하고 메서드를 종료한다 |
| `this` | 현재 객체 자신 |
| `private` | 클래스 외부에서 직접 접근 불가 |
| `base` | 부모 클래스 접근 |
| `override` | 부모 메서드 재정의 |
