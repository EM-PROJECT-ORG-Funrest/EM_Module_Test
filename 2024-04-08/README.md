맴버와 알림 서비스에 대한 CRUD 구현 <br/>
---
- controller 와 service 는 interface 구현 <br/>

- 컬럼명 : <br/>
- (1) Member :  `id`, `pw`, `name`, `addr`, `tel`, `authority` <br/>
- (2) Notify :  `id`, `notifyCode`, `notifyDate` <br/>
- 맴버, 알림에 대한 테이블 생성 후 [조회, 삽입, 수정, 삭제] 가능 <br/>




<h2>MVC PATTERN</h2>
Presentation Layer(프레젠테이션 계층)
- 사용자의 요청사항을 받아서 해당 서비스로 연결해주고 처리 결과를 사용자에게 알려주는 영역

<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/9def9d67-4640-45b5-bdfa-e7f279eac48a">

<h2>MVC PATTERN</h2>
Business Layer & Persistance Layer(비즈니스 계층, 지속계층)

<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/d67b043f-c09f-46a5-8ee0-53343c94acd0">
<hr/>

File Tree(ADD Interface) - FundingProject
---
```    

C:.
│  .classpath
│  .project
│  
└─FundingProject
    ├─bin
    │  │  V2.1.drawio
    │  │  
    │  └─MemberCRUD
    │      ├─Controller
    │      │      FrontController.class
    │      │      Main.class
    │      │      MemberController.class
    │      │      NotifyController.class
    │      │      SubController.class
    │      │      
    │      ├─Dependencies
    │      │      commons-logging-1.3.1.jar
    │      │      mysql-connector-j-8.3.0.jar
    │      │      spring-security-crypto-3.2.10.RELEASE.jar
    │      │      
    │      └─Domain
    │          ├─Dao
    │          │      CommonDao.class
    │          │      ConnectionPool.class
    │          │      MemberDao.class
    │          │      MemberDaoImpl.class
    │          │      NotifyDao.class
    │          │      NotifyDaoImpl.class
    │          │      SessionDao.class
    │          │      SessionDaoImpl.class
    │          │      
    │          ├─Dto
    │          │      MemberDto.class
    │          │      NotifyDto.class
    │          │      SessionDto.class
    │          │      
    │          └─Service
    │                  MemberService.class
    │                  MemberServiceImpl.class
    │                  NotifyService.class
    │                  NotifyServiceImpl.class
    │                  
    └─src
        │  V2.1.drawio
        │  
        └─MemberCRUD
            ├─Controller
            │      FrontController.java
            │      Main.java
            │      MemberController.java
            │      NotifyController.java
            │      SubController.java
            │      
            ├─Dependencies
            │      commons-logging-1.3.1.jar
            │      mysql-connector-j-8.3.0.jar
            │      spring-security-crypto-3.2.10.RELEASE.jar
            │      
            └─Domain
                ├─Dao
                │      CommonDao.java
                │      ConnectionPool.java
                │      MemberDao.java
                │      MemberDaoImpl.java
                │      NotifyDao.java
                │      NotifyDaoImpl.java
                │      SessionDao.java
                │      SessionDaoImpl.java
                │      
                ├─Dto
                │      MemberDto.java
                │      NotifyDto.java
                │      SessionDto.java
                │      
                └─Service
                        MemberService.java
                        MemberServiceImpl.java
                        NotifyService.java
                        NotifyServiceImpl.java
                        

```
---

<hr/>
