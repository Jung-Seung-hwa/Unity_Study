# 📖 Unity Study Repository

<p>
<b>4명이 함께 Unity와 C#을 학습하며 실제 게임을 구현하는 스터디 프로젝트 저장소입니다.</b><br>
<b>새로운 언어나 기술에 대한 두려움을 줄이고, 낯선 환경에서도 빠르게 적응할 수 있는 개발 역량을 기르는 것을 목표로 합니다.</b>
</p>

---

## 📌 목차 (Table of Contents)

1. [프로젝트 소개](#section-1)  
2. [스터디 목표](#section-2)  
3. [사용 교재](#section-3)  
4. [스터디 운영 방식](#section-4)  
5. [구현 진행 현황](#section-5)  
6. [게임 프로젝트 목록](#section-6)  
7. [기술 스택](#section-7)  
8. [팀 소개](#section-8)  
9. [포트폴리오 활용 목적](#section-9)  
10. [향후 계획](#section-10)

---

<a id="section-1"></a>
## 📖 1. 프로젝트 소개 (Project Overview)

- Unity 엔진과 C# 언어를 활용한 게임 개발 스터디 프로젝트
- 학습 과정과 구현 결과를 기록하는 포트폴리오 목적의 저장소

**스터디 목적**
- 새로운 기술 스택에 대한 두려움 줄이기
- 독학 능력 및 적응력 증명

**스터디 기간**
- 2024년 11월 20일(목) ~ 현재 진행 중

**참여 인원 (4명)**
- 류현석
- 정승화
- 김태완
- 임주환

---

<a id="section-2"></a>
## 🎯 2. 스터디 목표 (Study Goals)

- Unity 엔진 기본 구조 이해
- C# 문법 및 객체지향 프로그래밍 개념 학습
- 실습 중심의 게임 제작 경험
- GitHub를 활용한 협업 경험 축적

---

<a id="section-3"></a>
## 📚 3. 사용 교재 (Study Materials)

<table>
  <tr>
    <td width="220">
      <img src="https://github.com/user-attachments/assets/666799cb-0e7b-4bb8-9e3f-7c93391ba74f" width="200">
    </td>
    <td>
      <h3>교재명 : 레트로의 유니티 6 게임 프로그래밍 에센스</h3>
      <h3>출판사 : 한빛미디어</h3>
      <br>
      <h4>선택 이유</h4>
      <ul>
        <li>게임 개발에 대한 공통 관심사</li>
        <li>실습 중심 학습을 통해 직접 구현하며 이해하기 위함</li>
      </ul>
    </td>
  </tr>
</table>

---

<a id="section-4"></a>
## 🧩 4. 스터디 운영 방식 (Study Workflow)

**진행 시간**
- 평일 오전 9시 ~ 오후 6시

**진행 방식**
- Discord 온라인 모임
- 화면 공유 기반 학습
- 챕터 단위 실습 진행
- 문제 발생 시 팀원들과 함께 해결

**협업 방식**
- 역할 분담 없이 전원이 동일한 챕터 진행
- 코드 비교를 통한 상호 피드백

### 실제 협업 화면

<table>
  <tr>
    <td>
      <img src="https://github.com/user-attachments/assets/7715bc1d-8e66-40cd-b624-fcfc9a5100cf" width="400">
    </td>
    <td>
      <img src="https://github.com/user-attachments/assets/2b964a64-ce2c-4e94-a123-a04cfd161ff2" width="400">
    </td>
  </tr>
</table>

**코드 공유 방식**
- Discord를 통한 실시간 코드 공유
- KakaoTalk을 통한 코드 및 오류 캡처 공유
- GitHub를 통한 버전 이력 관리

---

<a id="section-5"></a>
## ⚙️ 5. 구현 진행 현황 (Implementation Progress)

- 현재 학습 및 구현 진행 중
- 내용은 지속적으로 업데이트 예정

**세부 진행 상황**
- 챕터별 실습 목록 : 정리 예정
- 게임별 핵심 기능 : 정리 중

---

<a id="section-6"></a>
## 🎮 6. 게임 프로젝트 목록 (Game Projects)

이 챕터에서는 Unity 기초 기능을 활용해 3D 회피 게임을 완성했다.  
탄알 생성, 충돌 처리, 점수 UI, 게임 전체 흐름 관리 등 게임 개발의 기본 구조를 실습하며 전반적인 게임 제작 과정을 경험했다.

### 🎮 닷지 : 3D 총알 피하기

-  **탄알 Prefab 생성** 및 `Instantiate()`를 통한 탄알 스폰
-  `Coroutine` + `WaitForSeconds()`로 **주기적 탄알 생성 패턴** 구현
-  `Rigidbody` 기반 플레이어 이동 및 **물리 엔진 제어**
-  `OnCollisionEnter()`로 **충돌 감지 및 게임 오버 처리**
-  TextMeshPro를 활용한 **점수 UI 표시 / 실시간 업데이트**
-  간단한 **점수 저장 로직** 구현
-  `GameManager` 생성 후 게임 흐름(스폰, 점수, 게임오버) 중앙 관리
-  **싱글톤 패턴**으로 GameManager 전역 접근 구조 학습
-  씬 설정 & 빌드를 통해 **최종 게임 실행 파일 제작**

**플레이 영상**

[![Play](https://img.shields.io/badge/▶️_Play-Video-blue)](https://github.com/user-attachments/assets/b56ed807-4a50-437a-9c1d-b9411728220c)


---

### 🏃 유니런 : 2D 러너

- 끊임없이 앞으로 달리는 2D 러너 게임
- 점프/슬라이딩과 같은 기본 조작 구현 예정
- 장애물을 피하면서 최대 거리 갱신 목표

**플레이 영상**

https://github.com/user-attachments/assets/a7fd3681-369c-4fc3-87f5-f715f5d40c22

---

<a id="section-7"></a>
## 🛠 7. 기술 스택 (Tech Stack)

- Unity
- C#
- Git / GitHub
- Discord

---

<a id="section-8"></a>
## 👥 8. 팀 소개 (Team)

- 역할 구분 없이 모든 팀원이 동일한 학습 흐름으로 참여

**팀원**
- 류현석
- 정승화
- 김태완
- 임주환

---

<a id="section-9"></a>
## 📌 9. 포트폴리오 활용 목적 (Portfolio Purpose)

- 새로운 기술에 빠르게 적응하는 역량 증명
- Unity 기반 프로젝트 경험 기록
- 팀 협업 경험 시각화

---

<a id="section-10"></a>
## 🚀 10. 향후 계획 (Future Plans)

- 챕터별 구현 내용 정리
- 게임 플레이 영상 및 이미지 추가
- 코드 리팩터링 및 구조 개선


