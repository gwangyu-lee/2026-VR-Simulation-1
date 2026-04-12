## 상속 (Inheritance)

기존 클래스의 **필드와 메서드를 물려받아** 새로운 클래스를 만드는 것.
공통된 기능은 부모 클래스에 두고, 자식 클래스에서 확장하거나 변형한다.

```csharp
public class Character
{
    public string name;
    public int hp;

    public void PrintStatus()
    {
        Console.WriteLine($"{name} / HP: {hp}");
    }
}

public class Warrior : Character
{
    public int attackPower;
}

Warrior w = new Warrior();
w.name = "Knight";
w.hp = 150;
w.attackPower = 30;

w.PrintStatus();  // Knight / HP: 150
```

> `Warrior`는 `Character`를 상속받았으므로 `name`, `hp`, `PrintStatus()`를 그대로 사용할 수 있다.

---

## 다단계 상속 (Multi-level Inheritance)

상속은 2단계뿐 아니라 **3단계 이상으로 이어질 수 있다**.
자식이 다시 부모가 되어 손자 클래스로 이어지는 구조다.

```csharp
public class Character           // 1단계 — 최상위 부모
{
    public string name;
    public int hp;

    public virtual void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격한다!");
    }
}

public class Warrior : Character    // 2단계 — Character 상속
{
    public int attackPower;

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 검으로 공격한다!");
    }
}

public class BerserkerWarrior : Warrior    // 3단계 — Warrior 상속
{
    public bool isRaging;

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 광전사 모드로 폭발적 공격!");
    }
}

BerserkerWarrior b = new BerserkerWarrior();
b.name = "Ragnar";      // Character에서 상속
b.hp = 200;             // Character에서 상속
b.attackPower = 50;     // Warrior에서 상속
b.isRaging = true;      // 자기 자신의 필드

b.Attack();  // Ragnar이(가) 광전사 모드로 폭발적 공격!
```

```
Character
    └── Warrior
            └── BerserkerWarrior
```

> `BerserkerWarrior`는 `Warrior`를 상속받고, `Warrior`는 `Character`를 상속받으므로
> `Character`의 필드와 메서드도 모두 물려받는다.

**주의**

- 단계가 깊어질수록 구조가 복잡해져 유지보수가 어려워진다
- Unity 실무에서는 2~3단계가 한계로 여겨지며, 그 이상은 상속 대신 **컴포넌트 패턴**을 선호한다

---

## 상속 구조 표현

```
부모 클래스 (Base Class / Parent Class)
    └── 자식 클래스 (Derived Class / Child Class)
```

```csharp
public class 자식클래스 : 부모클래스
{
    // 추가 필드와 메서드
}
```

| 용어 | 설명 |
|------|------|
| 부모 클래스 | 공통 기능을 정의한 클래스 |
| 자식 클래스 | 부모를 상속받아 확장한 클래스 |
| `:` | 상속 관계를 나타내는 기호 |

> C#에서 클래스는 **단일 상속**만 가능하다. 부모를 두 개 이상 가질 수 없다.

---

## 상속과 생성자

자식 클래스 객체를 생성하면 **부모 클래스의 생성자**가 먼저 실행된다.
`base()`를 사용해 부모 생성자에 값을 전달한다.

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
}

public class Warrior : Character
{
    public int attackPower;

    public Warrior(string name, int hp, int attackPower)
        : base(name, hp)
    {
        this.attackPower = attackPower;
    }
}

Warrior w = new Warrior("Knight", 150, 30);
Console.WriteLine($"{w.name} / HP: {w.hp} / 공격: {w.attackPower}");
// Knight / HP: 150 / 공격: 30
```

> `: base(name, hp)`는 "부모 생성자에 이 값들을 넘겨줘"라는 뜻이다.

---

## 메서드 오버라이딩 (Method Overriding)

부모 클래스의 메서드를 **자식 클래스에서 재정의**하는 것.
부모에 `virtual`, 자식에 `override` 키워드를 붙인다.

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

    public virtual void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격한다!");
    }
}

public class Warrior : Character
{
    public int attackPower;

    public Warrior(string name, int hp, int attackPower)
        : base(name, hp)
    {
        this.attackPower = attackPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 검으로 {attackPower}의 피해를 준다!");
    }
}

Character c = new Character("Archer", 80, 0);  // 여기선 간단히 표현
Warrior w = new Warrior("Knight", 150, 30);

w.Attack();  // Knight이(가) 검으로 30의 피해를 준다!
```

| 키워드 | 역할 |
|--------|------|
| `virtual` | 부모 메서드를 자식이 재정의할 수 있도록 허용 |
| `override` | 부모의 `virtual` 메서드를 자식이 재정의 |

> `virtual`이 없는 메서드는 `override`할 수 없다.

---

## `base` 키워드

자식 클래스에서 **부모 클래스의 멤버**에 접근할 때 사용한다.

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

    public virtual void PrintStatus()
    {
        Console.WriteLine($"이름: {name} / HP: {hp}");
    }
}

public class Mage : Character
{
    public int mana;

    public Mage(string name, int hp, int mana)
        : base(name, hp)
    {
        this.mana = mana;
    }

    public override void PrintStatus()
    {
        base.PrintStatus();  // 부모의 PrintStatus 먼저 실행
        Console.WriteLine($"MP: {mana}");
    }
}

Mage m = new Mage("Wizard", 80, 200);
m.PrintStatus();
// 이름: Wizard / HP: 80
// MP: 200
```

> `base.메서드()`를 호출하면 부모의 구현을 먼저 실행하고 자식에서 추가 동작을 붙일 수 있다.

---

## 상속의 접근 제한

`private` 멤버는 자식 클래스에서도 직접 접근할 수 없다.
자식 클래스에서 접근을 허용하려면 `protected`를 사용한다.

| 키워드 | 자기 클래스 | 자식 클래스 | 외부 |
|--------|:-----------:|:-----------:|:----:|
| `public` | O | O | O |
| `protected` | O | O | X |
| `private` | O | X | X |

```csharp
public class Character
{
    public string name;
    protected int hp;

    public Character(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
}

public class Warrior : Character
{
    public Warrior(string name, int hp) : base(name, hp) { }

    public void ShowHp()
    {
        Console.WriteLine(hp);  // protected이므로 접근 가능
    }
}
```

> `private`이면 자식 클래스에서도 `hp`에 직접 접근할 수 없다.
> 공통 필드를 자식에서 쓰려면 `protected`로 선언하거나 메서드를 통해 접근한다.

---

## 다형성 (Polymorphism)

부모 타입 변수로 **자식 객체를 참조**할 수 있다.
같은 메서드 호출이 객체 타입에 따라 다르게 동작한다.

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

public class Warrior : Character
{
    public Warrior(string name) : base(name) { }

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 검으로 공격한다!");
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

Character[] party = {
    new Warrior("Knight"),
    new Mage("Wizard"),
    new Character("Archer")
};

foreach (Character c in party)
{
    c.Attack();
}
// Knight이(가) 검으로 공격한다!
// Wizard이(가) 마법을 시전한다!
// Archer이(가) 공격한다!
```

> 배열에는 `Character` 타입으로 담았지만, 실제 객체 타입에 따라 서로 다른 `Attack()`이 실행된다.
> 이것이 다형성이다.

---

## `is` 와 `as`

런타임에 객체의 실제 타입을 확인하거나 변환할 때 사용한다.

```csharp
Character c = new Warrior("Knight");

if (c is Warrior)
{
    Console.WriteLine("이 객체는 Warrior입니다.");
}

Warrior w = c as Warrior;
if (w != null)
{
    Console.WriteLine($"Warrior로 변환 성공");
}
```

| 연산자 | 역할 |
|--------|------|
| `is` | 객체가 해당 타입인지 확인 (`bool` 반환) |
| `as` | 해당 타입으로 변환. 실패하면 `null` 반환 |

> `as`는 변환에 실패해도 예외를 던지지 않고 `null`을 반환하기 때문에 안전하게 사용할 수 있다.

---

## 봉인 클래스 (`sealed`)

더 이상 상속을 허용하지 않을 때 `sealed`를 붙인다.

```csharp
public sealed class FinalBoss : Character
{
    public FinalBoss(string name) : base(name) { }
}

// public class Sub : FinalBoss { }  // ❗️ 에러 — sealed 클래스는 상속 불가
```

> Unity에서 `MonoBehaviour`를 상속받은 컴포넌트 클래스에 `sealed`를 붙여 추가 상속을 막는 경우도 있다.

---

## 예제 — 적 캐릭터 계층 구조

```csharp
public class Enemy
{
    public string name;
    protected int hp;

    public Enemy(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격!");
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
        Console.WriteLine($"{name} HP: {hp}");
    }
}

public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 30) { }

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 단검으로 찌른다!");
    }
}

public class Dragon : Enemy
{
    public Dragon() : base("Dragon", 500) { }

    public override void Attack()
    {
        Console.WriteLine($"{name}이(가) 화염 브레스를 내뿜는다!");
    }
}

Enemy[] enemies = { new Goblin(), new Dragon() };

foreach (Enemy e in enemies)
{
    e.Attack();
    e.TakeDamage(10);
}
// Goblin이(가) 단검으로 찌른다!
// Goblin HP: 20
// Dragon이(가) 화염 브레스를 내뿜는다!
// Dragon HP: 490
```

> `Goblin`과 `Dragon`은 서로 다른 방식으로 공격하지만,
> `Enemy` 배열에 넣어 같은 방식으로 처리할 수 있다.

---

## 상속 정리

| 구문 | 역할 |
|------|------|
| `: 부모클래스` | 상속 선언 |
| `base(...)` | 부모 생성자 호출 |
| `base.메서드()` | 부모 메서드 호출 |
| `virtual` | 자식에서 재정의 허용 |
| `override` | 부모의 virtual 메서드 재정의 |
| `protected` | 자식 클래스까지 접근 허용 |
| `is` | 타입 확인 |
| `as` | 타입 변환 (실패 시 null) |
| `sealed` | 더 이상 상속 불가 |
