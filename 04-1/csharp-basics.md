## 배열 (Array)

같은 타입의 값을 **순서 있게** 저장하는 자료구조. 인덱스는 0부터 시작한다.

```csharp
int[] scores = { 80, 90, 70, 85, 60 };

Console.WriteLine(scores[0]);      // 80
Console.WriteLine(scores[4]);      // 60
Console.WriteLine(scores.Length);  // 5
```

> `scores.Length`는 배열의 **전체 요소 개수**를 반환한다.

**값 수정** — 인덱스로 직접 덮어쓴다.

```csharp
int[] scores = { 80, 90, 70 };
scores[1] = 95;
Console.WriteLine(scores[1]);  // 95
```

> 배열은 **크기가 고정**되어 있어 요소를 추가하거나 삭제할 수 없다.
> 요소를 동적으로 추가·삭제하려면 `List<T>`를 사용한다.

```csharp
List<int> scores = new List<int> { 80, 90, 70 };

scores.Add(85);     // 끝에 추가 → { 80, 90, 70, 85 }
scores.Remove(90);  // 값으로 삭제 → { 80, 70, 85 }

Console.WriteLine(scores.Count);  // 3
```

| | `int[]` | `List<int>` |
|---|---|---|
| 크기 | 고정 | 가변 |
| 추가/삭제 | 불가 | `Add` / `Remove` |
| 요소 수 | `.Length` | `.Count` |

---

## 문자열 보간 (String Interpolation)

`$"..."` 문법으로 문자열 안에 변수나 식을 직접 삽입한다.

```csharp
string name = "Gwangyu";
int score = 85;

Console.WriteLine($"이름: {name}, 점수: {score}");
// 출력: 이름: Gwangyu, 점수: 85
```

> `{ }` 안에는 변수뿐 아니라 연산식도 쓸 수 있다.

```csharp
Console.WriteLine($"합계: {80 + 90}");  // 합계: 170
```

---

## 반복문 (Loop Statement)

동일한 코드를 **조건이 만족되는 동안 반복** 실행하는 구문.

---

### for 문

반복 횟수가 **명확할 때** 사용한다.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
// 출력: 0 1 2 3 4
```

| 구성 요소 | 역할 |
|-----------|------|
| `int i = 0` | 초기화 — 루프 시작 전 한 번 실행 |
| `i < 5` | 조건 — 매 반복 전 검사, `false`가 되면 종료 |
| `i++` | 증감 — 매 반복 후 실행 |

---

### while 문

조건이 `true`인 동안 반복한다. 반복 횟수가 **불명확할 때** 사용한다.

```csharp
int count = 0;

while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
// 출력: 0 1 2
```

> 조건을 잘못 설정하면 **무한 루프**가 발생한다.
> 루프 내부에서 조건을 변화시키는 코드가 반드시 있어야 한다.

---

### do-while 문

**최소 한 번**은 실행한 뒤 조건을 검사한다.

```csharp
int count = 0;

do
{
    Console.WriteLine(count);
    count++;
} while (count < 3);
// 출력: 0 1 2
```

> `while`은 조건이 처음부터 `false`이면 한 번도 실행되지 않지만,
> `do-while`은 조건과 무관하게 **최소 1회** 실행된다.

---

### foreach 문

컬렉션(배열 등)의 **모든 요소를 순서대로** 순회한다.

```csharp
int[] scores = { 80, 90, 70, 85 };

foreach (int score in scores)
{
    Console.WriteLine(score);
}
// 출력: 80 90 70 85
```

> 인덱스가 필요 없을 때 사용하며, 루프 내부에서 컬렉션을 수정할 수 없다.

---

### break와 continue

**`break`** — 루프를 즉시 종료한다.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break;

    Console.WriteLine(i);
}
// 출력: 0 1 2 3 4
```

**`continue`** — 현재 반복을 건너뛰고 다음 반복으로 이동한다.

```csharp
for (int i = 0; i < 5; i++)
{
    if (i == 2)
        continue;

    Console.WriteLine(i);
}
// 출력: 0 1 3 4
```

---

### 배열 + 반복문

**for 문 — 인덱스가 필요할 때**

```csharp
int[] scores = { 80, 90, 70, 85, 60 };

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"scores[{i}] = {scores[i]}");
}
// scores[0] = 80
// scores[1] = 90
// ...
```

**foreach 문 — 합계·평균 계산**

```csharp
int[] scores = { 80, 90, 70, 85, 60 };

int sum = 0;
foreach (int score in scores)
{
    sum += score;
}

Console.WriteLine($"합계: {sum}");       // 합계: 385
Console.WriteLine($"평균: {sum / 5.0}"); // 평균: 77
```

**조건 결합 — 특정 값만 처리**

```csharp
int[] scores = { 80, 90, 70, 85, 60 };

foreach (int score in scores)
{
    if (score >= 80)
        Console.WriteLine($"{score} → Pass");
    else
        Console.WriteLine($"{score} → Fail");
}
// 80 → Pass  /  90 → Pass  /  70 → Fail  /  85 → Pass  /  60 → Fail
```

---

### 예제 — 2D 좌표 출력

중첩 반복문으로 격자 형태의 좌표를 출력한다.

```csharp
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 2; y++)
    {
        Console.WriteLine($"({x}, {y})");
    }
}
// 출력:
// (0, 0)  (0, 1)
// (1, 0)  (1, 1)
// (2, 0)  (2, 1)
```

> x가 고정된 상태에서 y가 먼저 순회한다.
> 바깥 루프 1번 도는 동안 안쪽 루프는 y 범위 전체를 반복한다.

---

### 예제 — 패턴 출력

중첩 반복문과 조건문을 결합해 문자 패턴을 그린다.

**대각선 패턴 — `i == j`일 때 `*`**

```csharp
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i == j)
            Console.Write("* ");
        else
            Console.Write("- ");
    }
    Console.WriteLine();
}
// * - - - -
// - * - - -
// - - * - -
// - - - * -
// - - - - *
```

**체커보드 패턴 — `(i + j) % 2 == 0`일 때 `#`**

```csharp
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ((i + j) % 2 == 0)
            Console.Write("# ");
        else
            Console.Write(". ");
    }
    Console.WriteLine();
}
// # . # . #
// . # . # .
// # . # . #
// . # . # .
// # . # . #
```

---

### 정리

| 구문 | 사용 시점 |
|------|-----------|
| `for` | 반복 횟수가 정해진 경우 |
| `while` | 조건이 만족될 때까지 반복 |
| `do-while` | 최소 1회 실행이 보장되어야 하는 경우 |
| `foreach` | 배열·컬렉션의 모든 요소를 순회할 때 |
| `break` | 루프 즉시 종료 |
| `continue` | 현재 반복 건너뛰기 |
