## 연산자 (Operator)

### 산술 연산자 (Arithmetic Operator)

`+`, `-`, `*`, `/`

```csharp
double pi    = 3.14;
double twoPi = pi * 2;   // 6.28

double six      = 6;
double myNumber = six / 5;  // 1.2
```

### 대입 연산자 (Assignment Operator)

`=` : 오른쪽 값을 왼쪽 변수에 **대입(저장)** 한다.

```csharp
int seven = 7;   // seven에 7을 대입
seven = 777;     // seven에 777을 재대입
```

### 관계 연산자 (Relational Operator)

비교 결과는 `bool` (true / false).

| 연산자 | 의미 |
|--------|------|
| `>` | 크다 |
| `<` | 작다 |
| `>=` | 크거나 같다 |
| `<=` | 작거나 같다 |
| `==` | 같다 |
| `!=` | 다르다 |

```csharp
bool true1 = 8 > 5;   // true
bool true2 = 8 == 8;  // true
bool true3 = 8 != 9;  // true
```

### 논리 연산자 (Logical Operator)

| 연산자 | 의미 | 결과 |
|--------|------|------|
| `&&` | AND | 둘 다 true여야 true |
| `\|\|` | OR | 하나라도 true면 true |

```csharp
bool myLogic1 = (10 > 5)  && (20 > 10);  // true  && true  → true
bool myLogic2 = (10 > 15) || (20 > 10);  // false || true  → true
```

### 비트 연산자 (Bitwise Operator)

`&` (AND), `|` (OR) — 비트 단위로 연산.

```csharp
byte bitOne = 0b0000_0001;
byte bitTwo = 0b0000_0010;

int myBit1 = bitOne & bitTwo;
//   0000_0001
// & 0000_0010
// = 0000_0000  →  0

int myBit2 = bitOne | bitTwo;
//   0000_0001
// | 0000_0010
// = 0000_0011  →  3
```

> 숫자 리터럴에서 `_`는 가독성을 위한 구분자로 사용 가능하다.
> `1_000_000` == `1000000`

---

## 상수 (Constant)

`const` 키워드로 선언. 한 번 값을 지정하면 **변경 불가**.

```csharp
const int eight = 8;
// eight = 888;  ❌ 컴파일 에러
```

---

## 스코프 (Scope)

`{ }` 중괄호로 범위를 나타낸다.
들여쓰기(tab)로 스코프를 시각적으로 구분한다.

```csharp
public class Program           // 클래스 스코프 시작
{
    public static void Main()  // 메서드 스코프 시작
    {
        int x = 10;            // Main 스코프 안
    }                          // 메서드 스코프 끝
}                              // 클래스 스코프 끝
```

---

## 부동소수점 주의사항

`double`과 `float` 모두 이진수로 소수를 표현하기 때문에 **미세한 오차**가 발생한다.

```csharp
double a = 0.1;
double b = 0.2;
double c = 0.3;

Console.WriteLine(a + b);      // 0.30000000000000004
Console.WriteLine(c == 0.3);   // True
Console.WriteLine(c == a + b); // False  ← 주의!

float fa = 0.1f;
float fb = 0.2f;
float fc = 0.3f;
Console.WriteLine(fc == fa + fb); // False  ← float도 동일한 문제 발생
```

> 산술 연산 자체는 문제없지만,
> **산술 연산 후 관계 연산(`==`)으로 비교**할 때는 오차를 주의해야 한다.
> `double`보다 `float`의 정밀도가 낮아 오차가 더 크게 나타날 수 있다.
