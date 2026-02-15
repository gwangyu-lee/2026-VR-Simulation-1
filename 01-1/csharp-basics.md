# C# 기초 문법

## 목차
- [C# 기초 문법](#c-기초-문법)
  - [목차](#목차)
  - [토큰 (Token)](#토큰-token)
  - [리터럴 (Literal)](#리터럴-literal)
  - [키워드 (Keyword)](#키워드-keyword)
  - [식별자 (Identifier)](#식별자-identifier)
    - [Camel Case](#camel-case)
  - [연산자 (Operator)](#연산자-operator)
    - [산술 연산자 (Arithmetic Operator)](#산술-연산자-arithmetic-operator)
    - [대입 연산자 (Assignment Operator)](#대입-연산자-assignment-operator)
    - [관계 연산자 (Relational Operator)](#관계-연산자-relational-operator)
    - [논리 연산자 (Logical Operator)](#논리-연산자-logical-operator)
    - [비트 연산자 (Bitwise Operator)](#비트-연산자-bitwise-operator)
  - [상수 (Constant)](#상수-constant)
  - [스코프 (Scope)](#스코프-scope)
  - [부동소수점 주의사항](#부동소수점-주의사항)

---

## 토큰 (Token)

프로그래밍 언어에서 **가장 작은 단위**. 공백으로 구분된다.

```csharp
int one = 1;
// 토큰 5개: int / one / = / 1 / ;
```

토큰이 모여 **표현식(Expression)** 이 되고, 표현식이 모여 **프로그램**이 완성된다.
표현식의 끝은 `;` (세미콜론)으로 표시한다.

---

## 리터럴 (Literal)

코드에 직접 쓴 **고정된 값**. 타입에 따라 종류가 다르다.

| 타입 | 키워드 | 예시 | 비고 |
|------|--------|------|------|
| 정수 | `int` | `2` | |
| 소수 (배정밀도) | `double` | `0.1` | 기본 소수 타입 |
| 소수 (단정밀도) | `float` | `0.1f` | 리터럴 뒤에 `f` 필수 |
| 논리 | `bool` | `false` | |
| 문자열 | `string` | `"Gwangyu"` | |
| 문자 | `char` | `'G'` | |

```csharp
int two         = 2;
double pointOne = 0.1;
float pointOneF = 0.1f;  // float 리터럴은 숫자 뒤에 f를 붙인다
bool isStudent  = false;
string name     = "Gwangyu";
char initial    = 'G';
```

> **`double` vs `float`**
> 둘 다 소수를 다루지만 정밀도와 메모리 크기가 다르다.
> - `double` : 64bit, 더 정밀 (기본값)
> - `float`  : 32bit, 덜 정밀, 메모리 절약 → Unity에서 주로 사용
> - `float` 리터럴은 반드시 숫자 뒤에 `f`를 붙인다. 안 붙이면 `double`로 인식.

> **`char` vs `string`**
> `char`는 반드시 한 글자. `string`은 0개 이상 몇 글자든 가능.

---

## 키워드 (Keyword)

언어에서 **미리 예약된 단어**. 식별자(변수 이름)로 사용할 수 없다.

```csharp
int three       = 3;    // int: 정수 선언 키워드
double pointTwo = 0.2;  // double: 소수 선언 키워드 (64bit)
float pointTwoF = 0.2f; // float: 소수 선언 키워드 (32bit)
```

---

## 식별자 (Identifier)

**변수의 이름**. 아래 규칙을 따른다.

| 규칙 | 예시 |
|------|------|
| 키워드 사용 불가 | ❌ `int int = 4;` |
| 숫자로 시작 불가 | ❌ `int 4 = 4;` |
| 특수문자 불가 (`_` 제외) | ❌ `int 2*2 = 4;` |
| 숫자 포함 가능 | ✅ `int myNumber4 = 4;` |
| `_` 사용 가능 | ✅ `int _five = 5;` |

### Camel Case

C#에서 권장하는 네이밍 스타일.

```
my number → myNumber
```

| 스타일 | 시작 | 사용처 |
|--------|------|--------|
| **lowerCamelCase** | 소문자 | 변수 |
| **UpperCamelCase** | 대문자 | 클래스, 메서드 |

```csharp
int myNumberIsFour = 4;  // 변수: lowerCamelCase
// public class MyClass  // 클래스: UpperCamelCase
```

> `_`로 구분하는 snake_case(`my_number_is_five`)는 C#에서 권장하지 않는다.

---

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
