## 4장 관찰자패턴
- 관찰자패턴은 관찰을 하는 Observer와 관찰을 당하는 Subject로 나뉘어져있다.
- Subject에서 신호를 보내면 Subject를 계속 관찰 중이던 Observer들이 신호를 받고 신호에 따른 행동을 수행한다.
- Subject에서 Observer들을 목록으로 관리하여 Observer들 사이의 커플링을 없앤다.

## 5장 프로트타입패턴
- 프로트타입패턴은 어떤 객체가 자기자신과 비슷한 객체를 복제할 수 있게하는 패턴이다.
- 사용예제 : 데이터 모델링을 할 때 비슷한 카테고리의 데이터일 경우 그 카테고리의 기본형을 프로트타입으로 하여 카테고리내의 다른 데이터들을 단순하게 만들 수 있다.
