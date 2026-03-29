## 메서드 (Method)

특정 작업을 수행하는 **코드 블록**에 이름을 붙여 재사용할 수 있게 만든 단위.
같은 코드를 여러 번 작성하는 대신, 메서드를 한 번 정의하고 필요할 때 **호출**한다.

```csharp
static void SayHello()
{
    Console.WriteLine("안녕하세요!");
}

SayHello();  // 안녕하세요!
SayHello();  // 안녕하세요!
```

> 메서드를 사용하면 코드 중복을 줄이고, 각 기능을 독립적으로 관리할 수 있다.

---

## 메서드 정의 구조

```
반환타입 메서드이름(매개변수 목록)
{
    // 실행할 코드
}
```

| 구성 요소 | 역할 |
|-----------|------|
| 반환타입 | 메서드가 돌려주는 값의 타입. 없으면 `void` |
| 메서드이름 | 파스칼 케이스(PascalCase)로 작성 |
| 매개변수 목록 | 호출 시 전달받는 값. 없으면 `()` |

> C#에서 메서드 이름은 **대문자로 시작**하는 파스칼 케이스를 사용한다.
> 예: `SayHello`, `CalculateScore`, `PrintResult`

---

## 매개변수 (Parameter)

메서드가 외부에서 값을 받아 사용할 때 선언하는 **입력 변수**.

```csharp
static void Greet(string name)
{
    Console.WriteLine($"안녕하세요, {name}!");
}

Greet("Gwangyu");  // 안녕하세요, Gwangyu!
Greet("Unity");    // 안녕하세요, Unity!
```

> 괄호 안에 선언한 변수를 **매개변수(parameter)**,
> 호출 시 전달하는 값을 **인수(argument)**라고 한다.

**여러 개의 매개변수**는 쉼표로 구분한다.

```csharp
static void PrintScore(string name, int score)
{
    Console.WriteLine($"{name}: {score}점");
}

PrintScore("Alice", 90);  // Alice: 90점
PrintScore("Bob", 75);    // Bob: 75점
```

> 인수는 매개변수의 **순서와 타입**이 일치해야 한다.

---

## 반환값 (Return Value)

메서드가 계산한 결과를 호출한 곳으로 돌려줄 때 `return`을 사용한다.

```csharp
static int Add(int a, int b)
{
    return a + b;
}

int result = Add(3, 5);
Console.WriteLine(result);  // 8
```

> `return` 문을 만나면 메서드가 즉시 종료되고 값이 반환된다.
> 반환타입이 `void`이면 `return`을 생략하거나 `return;`만 쓴다.

**반환값을 직접 표현식에 사용**할 수도 있다.

```csharp
static double Average(int a, int b, int c)
{
    return (a + b + c) / 3.0;
}

Console.WriteLine($"평균: {Average(80, 90, 70)}");  // 평균: 80
```

---

## void와 반환타입 비교

| | `void` | 반환타입 있음 |
|---|---|---|
| 반환값 | 없음 | 있음 (`int`, `string` 등) |
| `return` | 생략 가능 | 필수 |
| 사용 방식 | 단독 호출 | 변수에 대입하거나 표현식에 사용 |

```csharp
// void — 출력만 하고 끝
static void PrintDouble(int n)
{
    Console.WriteLine(n * 2);
}

// int 반환 — 계산 결과를 돌려줌
static int Double(int n)
{
    return n * 2;
}

PrintDouble(5);          // 10 (출력)
int value = Double(5);   // value = 10 (저장 후 활용 가능)
```

---

## 기본값 매개변수 (Default Parameter)

매개변수에 기본값을 지정하면 인수를 생략할 수 있다.

```csharp
static void PrintScore(string name, int score = 0)
{
    Console.WriteLine($"{name}: {score}점");
}

PrintScore("Alice", 90);  // Alice: 90점
PrintScore("Bob");        // Bob: 0점
```

> 기본값 매개변수는 **오른쪽**에 배치해야 한다.
> 기본값 없는 매개변수가 뒤에 오면 컴파일 에러가 발생한다.

---

## 메서드 오버로딩 (Method Overloading)

같은 이름의 메서드를 **매개변수 목록이 다르게** 여러 번 정의할 수 있다.

```csharp
static int Add(int a, int b)
{
    return a + b;
}

static double Add(double a, double b)
{
    return a + b;
}

static int Add(int a, int b, int c)
{
    return a + b + c;
}

Console.WriteLine(Add(1, 2));        // 3
Console.WriteLine(Add(1.5, 2.5));    // 4
Console.WriteLine(Add(1, 2, 3));     // 6
```

> 컴파일러가 인수의 **타입과 개수**를 보고 알맞은 메서드를 자동으로 선택한다.
> 반환타입만 다른 경우는 오버로딩이 아니며 컴파일 에러가 발생한다.

---

## 변수의 범위 (Scope)

메서드 내부에서 선언한 변수는 **그 메서드 안에서만** 유효하다.

```csharp
static void MethodA()
{
    int x = 10;
    Console.WriteLine(x);  // 10
}

static void MethodB()
{
    // Console.WriteLine(x);  // ❗️ 에러 — x는 MethodA의 지역변수
    int x = 99;               // 별개의 변수
    Console.WriteLine(x);    // 99
}
```

> 메서드 내부 변수를 **지역 변수(local variable)**라고 한다.
> 메서드가 종료되면 지역 변수는 사라진다.

---

## 예제 — 점수 판정 메서드

조건문과 메서드를 결합해 점수를 등급으로 변환한다.

```csharp
static string GetGrade(int score)
{
    if (score >= 90)
        return "A";
    else if (score >= 80)
        return "B";
    else if (score >= 70)
        return "C";
    else
        return "F";
}

Console.WriteLine(GetGrade(95));  // A
Console.WriteLine(GetGrade(82));  // B
Console.WriteLine(GetGrade(65));  // F
```

> 각 `if` 분기에서 `return`을 사용하면
> 불필요한 조건 검사 없이 즉시 값을 반환할 수 있다.

---

## 예제 — 배열과 메서드

배열 처리를 메서드로 분리하면 코드가 명확해진다.

```csharp
static int Sum(int[] arr)
{
    int total = 0;
    foreach (int n in arr)
    {
        total += n;
    }
    return total;
}

static double Average(int[] arr)
{
    return Sum(arr) / (double)arr.Length;
}

static int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

int[] scores = { 80, 90, 70, 85, 60 };

Console.WriteLine($"합계: {Sum(scores)}");         // 합계: 385
Console.WriteLine($"평균: {Average(scores)}");     // 평균: 77
Console.WriteLine($"최댓값: {Max(scores)}");       // 최댓값: 90
```

> `Average` 메서드 내부에서 `Sum` 메서드를 **재사용**하고 있다.
> 메서드는 다른 메서드를 호출할 수 있다.

---

## 명명된 인수 (Named Argument)

메서드를 호출할 때 **매개변수 이름을 명시**해 인수를 전달할 수 있다.

```csharp
static void CreateCharacter(string name, int hp, int speed)
{
    Console.WriteLine($"이름: {name}, HP: {hp}, 속도: {speed}");
}

// 순서대로 전달
CreateCharacter("Hero", 100, 5);

// 이름으로 전달 — 순서 무관
CreateCharacter(hp: 100, name: "Hero", speed: 5);
```

> 매개변수가 많을 때 명명된 인수를 사용하면 각 값의 의미가 명확해진다.

기본값 매개변수와 함께 사용하면 특정 매개변수만 골라서 전달할 수 있다.

```csharp
static void PrintInfo(string name, int level = 1, bool isActive = true)
{
    Console.WriteLine($"{name} / Lv.{level} / 활성: {isActive}");
}

PrintInfo("Alice");                        // Alice / Lv.1 / 활성: True
PrintInfo("Bob", level: 5);               // Bob / Lv.5 / 활성: True
PrintInfo("Carol", isActive: false);      // Carol / Lv.1 / 활성: False
```

---

## 재귀 (Recursion)

메서드가 자기 자신을 **호출**하는 것.
반복되는 구조를 간결하게 표현할 수 있다.

```csharp
static int Factorial(int n)
{
    if (n <= 1)
        return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(5));  // 120
// 5 * 4 * 3 * 2 * 1 = 120
```

| 호출 순서 | 계산 |
|-----------|------|
| `Factorial(5)` | `5 * Factorial(4)` |
| `Factorial(4)` | `4 * Factorial(3)` |
| `Factorial(3)` | `3 * Factorial(2)` |
| `Factorial(2)` | `2 * Factorial(1)` |
| `Factorial(1)` | `1` (종료 조건) |

> 재귀에는 반드시 **종료 조건(base case)**이 있어야 한다.
> 종료 조건이 없으면 메서드가 무한히 호출되어 스택 오버플로가 발생한다.

```csharp
static int Sum(int n)
{
    if (n <= 0)
        return 0;

    return n + Sum(n - 1);
}

Console.WriteLine(Sum(10));  // 55  (1+2+...+10)
```

---

### 정리

| 구문 | 역할 |
|------|------|
| `void 메서드()` | 반환값 없는 메서드 |
| `타입 메서드()` | 값을 반환하는 메서드 |
| `매개변수` | 외부에서 메서드로 전달하는 입력값 |
| `return` | 메서드 종료 및 값 반환 |
| 기본값 매개변수 | 인수 생략 가능 — `void M(int x = 0)` |
| 오버로딩 | 같은 이름, 다른 매개변수로 메서드 중복 정의 |
| 지역 변수 | 메서드 내부에서만 유효한 변수 |
| 명명된 인수 | 호출 시 `이름: 값` 형식으로 순서 없이 전달 |
| 재귀 | 메서드가 자기 자신을 호출 — 종료 조건 필수 |
