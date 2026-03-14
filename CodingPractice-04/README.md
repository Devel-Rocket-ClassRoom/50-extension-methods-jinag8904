# 코딩 연습 - 확장 메서드 만들기 (4)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. 체이닝 vs 중첩 호출

`StringExtensions` 정적 클래스에 다음 확장 메서드를 정의하세요:
- `Upper(this string text)`: 대문자로 변환
- `Trim(this string text)`: 앞뒤 공백 제거
- `Replace(this string text, char oldChar, char newChar)`: 문자 치환

`"  hello world  "` 문자열을 중첩 호출 방식과 메서드 체이닝 방식 두 가지로 처리하여 
결과를 비교하세요.

**실행 결과**

```
결과1: HELLO_WORLD
결과2: HELLO_WORLD
```

---

## 2. 접근할 수 없는 멤버

`SecretBox` 클래스에 `private string _secret`과 `public string PublicData`를 정의하세요. 
`SecretBoxExtensions` 확장 메서드에서는 `PublicData`만 접근할 수 있음을 확인하세요.

**실행 결과**

```
공개 데이터: 공개
```

---

## 3. 인스턴스 메서드 우선

`Greeter` 클래스에 `SayHello()` 인스턴스 메서드를 정의하고, 
`GreeterExtensions`에 같은 이름의 `SayHello` 확장 메서드와 `SayGoodbye` 확장 메서드를 정의하세요. 
인스턴스 메서드가 우선 호출되는 것을 확인하고, 
`GreeterExtensions.SayHello(g)` 형태로 명시적 호출도 테스트하세요.

**실행 결과**

```
인스턴스 메서드: 안녕하세요!
확장 메서드: 안녕히 가세요!
확장 메서드: 반갑습니다!
```
