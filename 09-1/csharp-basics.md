## C# 기초 복습 — Console.ReadLine()

이번 시간은 지금까지 배운 C# 기초 문법을 `Console.ReadLine()`과 연결해서 복습한다.
사용자로부터 값을 입력받아 조건문, 반복문, 메서드, 클래스와 함께 활용하는 방법을 연습한다.

> 목표는 **콘솔에서 값을 입력받고, 그 값을 처리하는 흐름**을 스스로 작성할 수 있게 되는 것이다.

---

## Console.ReadLine() 기본

`Console.ReadLine()`은 사용자가 키보드로 입력한 값을 문자열로 읽어온다.

```csharp
string name = Console.ReadLine();
Console.WriteLine($"이름: {name}");
```

| 메서드 | 설명 |
|--------|------|
| `Console.WriteLine()` | 출력 후 줄바꿈 |
| `Console.Write()` | 출력 (줄바꿈 없음) |
| `Console.ReadLine()` | 한 줄 입력받기 |

> `Console.ReadLine()`의 반환 타입은 항상 `string`이다.
> 숫자가 필요하면 변환이 필요하다.

---

## 타입 변환

`Console.ReadLine()`은 문자열을 반환하므로, 숫자로 사용하려면 변환해야 한다.

```csharp
string input = Console.ReadLine();
int hp = int.Parse(input);
Console.WriteLine($"HP: {hp}");
```

**한 줄로 쓰기**

```csharp
int hp = int.Parse(Console.ReadLine());
```

| 변환 메서드 | 대상 타입 | 예시 |
|-------------|-----------|------|
| `int.Parse()` | `int` | `"100"` → `100` |
| `double.Parse()` | `double` | `"3.14"` → `3.14` |
| `float.Parse()` | `float` | `"1.5"` → `1.5f` |
| `bool.Parse()` | `bool` | `"true"` → `true` |

> 숫자가 아닌 문자열을 `int.Parse()`에 넣으면 오류가 발생한다.
> 예: `int.Parse("abc")` → 오류

---

## 조건문과 함께

입력받은 값에 따라 다른 메시지를 출력한다.

```csharp
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
```

**switch와 함께**

```csharp
Console.Write("직업 입력 (Warrior / Mage): ");
string job = Console.ReadLine();

switch (job)
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
```

---

## 반복문과 함께

반복문 안에서 여러 번 입력받을 수 있다.

**정해진 횟수만큼 입력받기**

```csharp
int[] scores = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"점수 {i + 1} 입력: ");
    scores[i] = int.Parse(Console.ReadLine());
}

foreach (int score in scores)
{
    Console.WriteLine(score);
}
```

**조건을 만족할 때까지 반복 입력**

```csharp
int hp = -1;

while (hp < 0 || hp > 100)
{
    Console.Write("HP 입력 (0~100): ");
    hp = int.Parse(Console.ReadLine());
}

Console.WriteLine($"HP: {hp}");
```

> `while`은 조건이 참인 동안 계속 반복한다.
> 입력값이 범위를 벗어나면 다시 묻는 패턴에 자주 쓰인다.

---

## 메서드로 분리하기

입력받는 부분을 메서드로 분리하면 재사용할 수 있다.

```csharp
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
```

**사용 예시**

```csharp
string name = ReadString("이름 입력: ");
int hp = ReadInt("HP 입력: ");

Console.WriteLine($"{name} / HP: {hp}");
```

> 입력 메서드를 따로 만들면 코드가 짧아지고, 나중에 수정하기도 쉽다.

---

## 클래스와 함께

입력받은 값으로 객체를 만들 수 있다.

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

    public void PrintStatus()
    {
        Console.WriteLine($"{name} / HP: {hp}");
    }
}
```

```csharp
Console.Write("이름 입력: ");
string name = Console.ReadLine();

Console.Write("HP 입력: ");
int hp = int.Parse(Console.ReadLine());

Player player = new Player(name, hp);
player.PrintStatus();
```

---

## 실습 1 - 출력 예상하기

다음 코드의 출력 결과를 예상해보자.
입력값이 `"30"`이라고 가정한다.

```csharp
Console.Write("HP 입력: ");
int hp = int.Parse(Console.ReadLine());

if (hp < 50)
{
    hp += 20;
}

Console.WriteLine(hp);
```

예상:

```text
50
```

---

## 실습 2 - 빈칸 채우기

아래 코드가 이름을 입력받아 `"안녕하세요, Gwangyu님!"`을 출력하도록 빈칸을 채워보자.

```csharp
Console.Write("이름 입력: ");
string name = ________________;

Console.WriteLine($"안녕하세요, {name}님!");
```

확인할 것:

- `Console.ReadLine()`의 반환 타입은 `string`이다
- 문자열은 `Parse` 없이 바로 사용할 수 있다

---

## 실습 3 - 점수 입력 후 평균 구하기

점수 3개를 입력받아 평균을 출력하는 프로그램을 작성해보자.

```csharp
int[] scores = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"점수 {i + 1}: ");
    scores[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (int score in scores)
{
    total += score;
}

double average = total / (double)scores.Length;
Console.WriteLine($"평균: {average}");
```

---

## 자주 헷갈리는 부분

| 헷갈리는 내용 | 정리 |
|---------------|------|
| `ReadLine()` 반환 타입 | 항상 `string`이다 |
| 숫자 입력 | `int.Parse(Console.ReadLine())`으로 변환 |
| `Console.Write` vs `WriteLine` | `Write`는 줄바꿈 없음, `WriteLine`은 있음 |
| `Parse` 오류 | 숫자가 아닌 문자열 입력 시 오류 발생 |
| `while` 반복 입력 | 올바른 값이 들어올 때까지 계속 물어볼 때 사용 |
