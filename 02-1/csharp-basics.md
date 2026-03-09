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