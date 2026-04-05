## 클래스와 객체 (Class and Object)

현실의 대상을 프로그램 안에서 표현하기 위해 **데이터와 기능을 하나로 묶는 설계도**를 클래스라고 한다.
클래스를 기반으로 실제로 만든 개별 대상을 객체(object) 또는 인스턴스(instance)라고 한다.

```csharp
public class Player
{
    public string name;
    public int hp;
}

Player player1 = new Player();
player1.name = "Hero";
player1.hp = 100;

Console.WriteLine(player1.name);  // Hero
Console.WriteLine(player1.hp);    // 100
```

> `Player`는 설계도이고, `player1`은 그 설계도로 만든 실제 객체다.

---

## 클래스 정의 구조

```csharp
접근제한자 class 클래스이름
{
    필드
    메서드
}
```

| 구성 요소 | 역할 |
|-----------|------|
| `class` | 클래스를 정의할 때 사용하는 키워드 |
| 클래스이름 | 파스칼 케이스로 작성 |
| 필드 | 객체가 저장할 데이터 |
| 메서드 | 객체가 수행할 동작 |

> 클래스 이름은 보통 `Player`, `Monster`, `GameManager`처럼 **명사형**으로 작성한다.

---

## 필드 (Field)

클래스 내부에 선언하는 변수. 객체가 가져야 하는 **상태 정보**를 저장한다.

```csharp
public class Monster
{
    public string name;
    public int hp;
    public float speed;
}
```

```csharp
Monster slime = new Monster();
slime.name = "Slime";
slime.hp = 30;
slime.speed = 2.5f;

Console.WriteLine($"{slime.name} / HP: {slime.hp} / Speed: {slime.speed}");
```

> 같은 클래스로 여러 객체를 만들면, 필드 값은 객체마다 따로 저장된다.

---

## 객체 생성 (`new`)

클래스는 설계도일 뿐이므로, 실제로 사용하려면 `new` 키워드로 객체를 생성해야 한다.

```csharp
Player playerA = new Player();
Player playerB = new Player();

playerA.name = "Alice";
playerB.name = "Bob";

Console.WriteLine(playerA.name);  // Alice
Console.WriteLine(playerB.name);  // Bob
```

> `playerA`와 `playerB`는 같은 `Player` 클래스로 만들었지만 서로 다른 객체다.

**객체는 서로 독립적으로 상태를 가진다.**

```csharp
Player playerA = new Player();
Player playerB = new Player();

playerA.name = "Alice";
playerA.hp = 100;

playerB.name = "Bob";
playerB.hp = 60;

playerA.hp -= 30;

Console.WriteLine($"{playerA.name}: {playerA.hp}");  // Alice: 70
Console.WriteLine($"{playerB.name}: {playerB.hp}");  // Bob: 60
```

> `playerA`의 HP를 바꿔도 `playerB`의 HP는 바뀌지 않는다.
> 각 객체는 자기만의 필드 값을 따로 가진다.

---

## 메서드를 가진 클래스

클래스는 데이터만 저장하는 것이 아니라, 그 데이터와 관련된 **동작**도 함께 가질 수 있다.

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

Player player = new Player();
player.name = "Hero";
player.hp = 100;
player.PrintStatus();  // Hero / HP: 100
```

> 객체 내부 메서드는 자기 자신의 필드에 직접 접근할 수 있다.

---

## 생성자 (Constructor)

객체가 생성될 때 **초기값을 넣기 위한 특별한 메서드**.
이름이 클래스 이름과 같고, 반환타입을 쓰지 않는다.

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

Player player = new Player("Hero", 100);
Console.WriteLine($"{player.name} / {player.hp}");
```

| 특징 | 설명 |
|------|------|
| 이름 | 클래스 이름과 동일 |
| 반환타입 | 없음 |
| 호출 시점 | `new`로 객체를 만들 때 자동 실행 |

> 생성자를 사용하면 객체 생성 직후의 상태를 안전하게 정할 수 있다.

---

## `this` 키워드

현재 객체 자신을 가리키는 참조.
매개변수 이름과 필드 이름이 같을 때 구분할 때 자주 사용한다.

```csharp
public class Player
{
    public string name;

    public Player(string name)
    {
        this.name = name;
    }
}
```

> `this.name`은 필드, 오른쪽 `name`은 생성자의 매개변수다.

**`this`가 없으면 어떻게 보일까?**

```csharp
public class Player
{
    public string name;

    public Player(string name)
    {
        name = name;
    }
}
```

위 코드는 둘 다 **매개변수 `name`**으로 해석되므로, 필드 `name`에 값이 들어가지 않는다.
그래서 필드에 접근한다는 뜻을 분명히 하기 위해 `this.name = name;`으로 작성한다.

```csharp
Player player = new Player("Hero");
Console.WriteLine(player.name);  // null
```

**메서드 안에서 현재 객체 자신을 가리킬 때도 사용한다.**

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
        Console.WriteLine($"{this.name} / HP: {this.hp}");
    }
}

Player player = new Player("Knight", 100);
player.PrintStatus();  // Knight / HP: 100
```

> 여기서 `this.name`은 "이 메서드를 호출한 객체의 name"이라는 뜻이다.
> 다만 필드 이름이 겹치지 않는 경우에는 `name`, `hp`처럼 `this`를 생략해도 된다.

**정리**

| 표현 | 의미 |
|------|------|
| `name` | 가까운 범위의 변수 또는 필드 |
| `this.name` | 현재 객체의 필드 |
| `this` | 현재 메서드를 실행 중인 객체 자신 |

---

## 접근 제한자 (Access Modifier)

클래스, 필드, 메서드에 대한 **접근 가능 범위**를 제어한다.

| 키워드 | 의미 |
|--------|------|
| `public` | 어디서든 접근 가능 |
| `private` | 해당 클래스 내부에서만 접근 가능 |

```csharp
public class Player
{
    public string name;
    private int hp;

    public void SetHp(int value)
    {
        hp = value;
    }

    public void PrintHp()
    {
        Console.WriteLine(hp);
    }
}
```

> 중요한 데이터는 `private`으로 숨기고, 메서드를 통해 제어하는 방식이 자주 사용된다.

**예제 - 데미지를 받을 때만 HP 변경하기**

```csharp
public class Player
{
    public string name;
    private int hp;

    public Player(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 0)
            hp = 0;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{name} / HP: {hp}");
    }
}

Player player = new Player("Knight", 100);
player.TakeDamage(30);
player.TakeDamage(80);
player.PrintStatus();  // Knight / HP: 0
```

> `hp`를 `public`으로 열어두면 외부에서 아무 값이나 넣을 수 있지만,
> `private`으로 숨기면 클래스 내부 규칙에 따라 안전하게 관리할 수 있다.

---

## 클래스와 메서드의 역할 분리

`Main`에 모든 코드를 몰아넣는 대신, 관련 데이터와 기능을 클래스로 묶으면 구조가 명확해진다.

```csharp
public class Enemy
{
    public string name;
    public int hp;

    public Enemy(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Console.WriteLine($"{name}이(가) {damage}의 피해를 입음");
    }
}

Enemy goblin = new Enemy("Goblin", 50);
goblin.TakeDamage(10);
Console.WriteLine(goblin.hp);  // 40
```

> 데이터와 기능을 함께 묶으면 코드 재사용성과 가독성이 좋아진다.

---

## 클래스 vs 객체 정리

| 구분 | 의미 | 예시 |
|------|------|------|
| 클래스 | 설계도 | `Player` |
| 객체 | 설계도로 만든 실제 대상 | `player1` |
| 필드 | 객체가 가지는 데이터 | `name`, `hp` |
| 메서드 | 객체가 수행하는 기능 | `PrintStatus()`, `TakeDamage()` |

---

## 예제 - 캐릭터 클래스 만들기

```csharp
public class Character
{
    public string name;
    public int hp;

    public Character(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public void Heal(int amount)
    {
        hp += amount;
        Console.WriteLine($"{name} 회복: +{amount}");
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{name} / HP: {hp}");
    }
}

Character hero = new Character("Knight", 100);
hero.PrintStatus();  // Knight / HP: 100
hero.Heal(20);       // Knight 회복: +20
hero.PrintStatus();  // Knight / HP: 120
```

> 클래스는 Unity의 `Player`, `Enemy`, `Bullet`, `Item` 같은 게임 오브젝트의 데이터를 구조화할 때 매우 중요하다.
