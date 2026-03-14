# 코딩 연습 - 확장 메서드 만들기 (3)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. 문자열 타입 확장

`StringExtensions` 정적 클래스에 다음 확장 메서드를 정의하세요:
- `IsCapitalized(this string text)`: 첫 글자가 대문자인지 확인
- `Capitalize(this string text)`: 첫 글자를 대문자로 변환 (나머지 소문자)
- `Reverse(this string text)`: 문자열 뒤집기 (`Array.Reverse` 사용)

`"hello"` 문자열로 테스트하세요.

**실행 결과**

```
'hello' 대문자로 시작? False
첫 글자 대문자: Hello
뒤집기: olleh
```

---

## 2. 메서드 체이닝

`StringChainExtensions` 정적 클래스에 다음 확장 메서드를 정의하세요:
- `AddPrefix(this string text, string prefix)`: 접두사 추가
- `AddSuffix(this string text, string suffix)`: 접미사 추가
- `Take(this string text, int count)`: 처음 N글자만 반환
- `AddEllipsis(this string text)`: 말줄임표(`...`) 추가

`"안녕하세요 반갑습니다 좋은 하루 되세요"` 문자열을 
`.Take(10).AddEllipsis().AddPrefix("[메시지] ").AddSuffix(" (더보기)")` 체이닝으로 처리하세요.

**실행 결과**

```
원본: 안녕하세요 반갑습니다 좋은 하루 되세요
결과: [메시지] 안녕하세요 반갑습니... (더보기)
```

---

## 3. 컬렉션 확장

`CollectionExtensions` 정적 클래스에 다음 제네릭 확장 메서드를 정의하세요:
- `IsEmpty<T>(this ICollection<T> collection)`: 컬렉션이 비어있는지 확인
- `HasItems<T>(this ICollection<T> collection)`: 요소가 있는지 확인
- `ForEach<T>(this IList<T> list, Action<T> action)`: 각 요소에 대해 작업 수행

문자열 배열 `{ "철수", "영희", "민수" }`와 빈 `List<int>`로 테스트하세요.

**실행 결과**

```
names 비어있음? False
emptyList 비어있음? True
names에 요소 있음? True

이름 목록:
  - 철수
  - 영희
  - 민수
```
