## 조건문 (Conditional Statement)

프로그램의 **흐름을 제어**하는 구문. 조건에 따라 다른 코드를 실행한다.

---

### if 문

`bool` 조건이 `true`일 때만 블록 안의 코드를 실행한다.

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A");
}
```

> `if`의 조건은 반드시 `bool` 타입이어야 한다.
> C와 달리 `if (1)` 같은 정수 조건은 C#에서 **사용 불가**.

---

### if-else 문

조건이 `true`이면 `if` 블록, `false`이면 `else` 블록을 실행한다.

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("A가 아님");
}
```

---

### else if 문

여러 조건을 **순서대로** 검사한다. 위에서부터 확인하며, 처음으로 `true`인 블록만 실행한다.

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else if (score >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("F");
}
// 출력: B
```

> `else if`는 **위에서부터 순서대로** 검사하므로,
> `score >= 80`에 도달했을 때 이미 `score >= 90`은 `false`임이 보장된다.
> 따라서 조건의 **순서가 중요**하다.

---

### 중첩 if (Nested if)

`if` 안에 또 다른 `if`를 넣을 수 있다.

```csharp
int score = 85;
bool isSubmitted = true;

if (isSubmitted)
{
    if (score >= 90)
    {
        Console.WriteLine("A");
    }
    else
    {
        Console.WriteLine("B 이하");
    }
}
else
{
    Console.WriteLine("미제출");
}
```

> 중첩이 깊어지면 코드 가독성이 떨어진다.
> 가능하면 논리 연산자(`&&`, `||`)로 조건을 합치는 것을 고려한다.

---

### 논리 연산자와 조건문

2주차에 배운 논리 연산자를 조건문에 활용할 수 있다.

```csharp
int score = 85;
bool isSubmitted = true;

if (isSubmitted && score >= 90)
{
    Console.WriteLine("A");
}
else if (isSubmitted && score >= 80)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("기타");
}
```

| 연산자 | 의미 | 조건문에서의 역할 |
|--------|------|-------------------|
| `&&` | AND | 두 조건이 **모두** 참이어야 실행 |
| `\|\|` | OR | 하나라도 참이면 실행 |
| `!` | NOT | 조건을 **반전** |

```csharp
bool isGameOver = false;

if (!isGameOver)
{
    Console.WriteLine("게임 계속");
}
// !false → true → 블록 실행
```

---

### switch 문

하나의 값을 여러 `case`와 비교한다. `if-else if` 체인의 대안.

```csharp
string grade = "B";

switch (grade)
{
    case "A":
        Console.WriteLine("우수");
        break;
    case "B":
        Console.WriteLine("양호");
        break;
    case "C":
        Console.WriteLine("보통");
        break;
    default:
        Console.WriteLine("기타");
        break;
}
// 출력: 양호
```

| 요소 | 역할 |
|------|------|
| `switch (값)` | 비교할 대상 |
| `case 리터럴:` | 일치 여부 확인 |
| `break;` | 해당 case 실행 후 switch 종료 |
| `default:` | 어떤 case에도 해당하지 않을 때 (else와 유사) |

> **`break`를 빠뜨리면** 컴파일 에러가 발생한다.
> C/C++과 달리 C#은 fall-through를 허용하지 않는다.

---

### 조건 연산자 — 삼항 연산자 (Ternary Operator)

간단한 `if-else`를 한 줄로 작성할 수 있다.

```
조건 ? 참일 때 값 : 거짓일 때 값
```

```csharp
int score = 85;
string result = score >= 90 ? "A" : "A가 아님";
Console.WriteLine(result);  // A가 아님
```

> 삼항 연산자는 **단순한 값 선택**에만 사용한다.
> 복잡한 로직은 `if-else`가 더 읽기 쉽다.

---

### 정리

| 구문 | 사용 시점 |
|------|-----------|
| `if` | 하나의 조건 검사 |
| `if-else` | 두 갈래 분기 |
| `else if` | 여러 조건을 순서대로 검사 |
| `switch` | 하나의 값을 여러 경우와 비교 |
| `? :` | 간단한 값 선택 (한 줄) |
