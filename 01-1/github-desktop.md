# GitHub Desktop 사용법

## 목차
- [GitHub Desktop 사용법](#github-desktop-사용법)
  - [목차](#목차)
  - [Git과 GitHub이란?](#git과-github이란)
    - [Git](#git)
    - [GitHub](#github)
  - [GitHub Desktop 설치](#github-desktop-설치)
  - [기본 개념](#기본-개념)
  - [저장소 (Repository)](#저장소-repository)
    - [새 저장소 만들기](#새-저장소-만들기)
    - [기존 저장소 클론하기](#기존-저장소-클론하기)
  - [기본 워크플로우](#기본-워크플로우)
    - [1. 파일 수정](#1-파일-수정)
    - [2. Commit (커밋)](#2-commit-커밋)
    - [3. Push (푸시)](#3-push-푸시)
    - [4. Pull (풀)](#4-pull-풀)
    - [전체 흐름 요약](#전체-흐름-요약)
  - [브랜치 (Branch)](#브랜치-branch)
    - [브랜치 만들기](#브랜치-만들기)
    - [브랜치 전환하기](#브랜치-전환하기)
    - [브랜치 합치기 (Merge)](#브랜치-합치기-merge)
  - [충돌 해결 (Merge Conflict)](#충돌-해결-merge-conflict)
    - [충돌이 발생한 파일 모습](#충돌이-발생한-파일-모습)
    - [해결 방법](#해결-방법)

---

## Git과 GitHub이란?

### Git
- **버전 관리 시스템 (VCS, Version Control System)**
- 파일의 변경 이력을 기록하고 관리하는 도구
- 언제, 누가, 무엇을 바꿨는지 추적 가능
- 이전 버전으로 되돌리기 가능

### GitHub
- Git 저장소를 **온라인에 저장**하고 공유하는 플랫폼
- 팀원과 협업할 때 사용
- GitHub Desktop은 Git을 GUI로 쉽게 사용할 수 있게 해주는 앱

```
로컬 컴퓨터 (Git) ←──── push / pull ────→ 온라인 (GitHub)
```

---

## GitHub Desktop 설치

1. [https://desktop.github.com](https://desktop.github.com) 접속
2. 운영체제에 맞는 버전 다운로드 및 설치
3. GitHub 계정으로 로그인
4. 이름 / 이메일 설정 확인

---

## 기본 개념

| 용어 | 설명 |
|------|------|
| **Repository (저장소)** | 프로젝트 파일과 변경 이력을 담는 폴더 |
| **Commit** | 변경사항을 저장하는 행위 (스냅샷 찍기) |
| **Push** | 로컬 커밋을 GitHub 서버에 업로드 |
| **Pull** | GitHub 서버의 변경사항을 로컬로 다운로드 |
| **Branch** | 독립적인 작업 공간 (나뭇가지) |
| **Merge** | 두 브랜치를 하나로 합치는 것 |
| **Clone** | GitHub의 저장소를 로컬에 복사 |

---

## 저장소 (Repository)

### 새 저장소 만들기
1. GitHub Desktop 상단 메뉴 → **File > New Repository**
2. 이름, 로컬 경로 설정
3. **Create Repository** 클릭
4. **Publish repository** 로 GitHub에 업로드

### 기존 저장소 클론하기
1. GitHub 웹사이트에서 저장소 접속
2. **Code** 버튼 → URL 복사
3. GitHub Desktop → **File > Clone Repository**
4. URL 붙여넣기 → 로컬 경로 선택 → **Clone**

---

## 기본 워크플로우

### 1. 파일 수정

로컬 폴더에서 파일을 수정하면 GitHub Desktop **Changes** 탭에 자동으로 표시된다.

```
파일 수정 → Changes 탭에서 확인
```

### 2. Commit (커밋)

변경사항을 하나의 묶음으로 저장하는 행위.

1. **Changes** 탭에서 저장할 파일 체크
2. 하단 **Summary** 에 커밋 메시지 입력
3. **Commit to main** 클릭

> **좋은 커밋 메시지 작성법**
> - 무엇을 바꿨는지 명확하게
> - ❌ `update` / ❌ `fix` / ❌ `asdf`
> - ✅ `Add player movement script`
> - ✅ `Fix collision bug on wall`

### 3. Push (푸시)

로컬 커밋을 GitHub 서버에 업로드.

1. 커밋 후 상단 **Push origin** 버튼 클릭
2. GitHub 웹사이트에서 반영 확인

### 4. Pull (풀)

팀원이 올린 최신 변경사항을 내 로컬로 가져오기.

1. 상단 **Fetch origin** 버튼 클릭 (변경사항 확인)
2. **Pull origin** 버튼 클릭 (변경사항 적용)

> 작업 시작 전에 항상 **Pull** 먼저 하는 습관을 들이자.

### 전체 흐름 요약

```
Pull → 파일 수정 → Commit → Push
```

---

## 브랜치 (Branch)

메인 코드를 건드리지 않고 **독립적으로 작업**할 수 있는 공간.

```
main  ──────────────────────────────▶
         └── feature ──▶ (merge)
```

### 브랜치 만들기
1. 상단 **Current Branch** 클릭
2. **New Branch** 클릭
3. 브랜치 이름 입력 → **Create Branch**

> 브랜치 이름 예시: `feature/player-jump`, `fix/ui-bug`

### 브랜치 전환하기
1. 상단 **Current Branch** 클릭
2. 목록에서 원하는 브랜치 선택

### 브랜치 합치기 (Merge)
1. **main** 브랜치로 전환
2. 상단 메뉴 → **Branch > Merge into Current Branch**
3. 합칠 브랜치 선택 → **Merge**

---

## 충돌 해결 (Merge Conflict)

같은 파일의 같은 부분을 두 사람이 동시에 수정하면 **충돌(Conflict)** 이 발생한다.

### 충돌이 발생한 파일 모습

```
<<<<<<< HEAD
int speed = 5;       // 내가 수정한 내용
=======
int speed = 10;      // 상대방이 수정한 내용
>>>>>>> feature/movement
```

### 해결 방법
1. GitHub Desktop에서 충돌 파일 확인
2. **Open in Editor** 로 파일 열기
3. `<<<<<<<`, `=======`, `>>>>>>>` 표시 제거 후 원하는 코드만 남기기
4. 파일 저장 → **Mark as Resolved**
5. **Commit merge** 로 마무리

> 충돌을 예방하려면 팀원과 **작업 영역을 미리 나누고**, 자주 Pull/Push 하자.
