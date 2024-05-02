![header](https://capsule-render.vercel.app/api?type=venom&color=auto&height=300&section=header&text=funrest%20project&fontSize=90&fontColor=black) <hr>


DEVELOPMENT MOTIVATION
---
> 여가생활 컨텐츠 펀딩 웹사이트
> > 기존에 있던 펀딩 사이트들은 실제 존재하는 물건이나 음식들에 대한 펀딩밖에 없었습니다.<br>
하지만 여기에 국한되지 않고 더 나아가 여가 생활을 위한 영화, 도서, 뮤지컬&연극을 위한 펀딩을 해보기 위해 프로젝트를 구상하였습니다. <br><br>
> 상세 설명 <br>
> > - 영화 : 이미 개봉하여 영화관에서 볼 수 없는 영화를 다시 보기위해 펀딩을 하여 재개봉<br>
> > - 도서 : 도서를 출판하고 싶은 작가들의 줄거리를 보고 구매자들이 펀딩하여 도서 출판<br>
> > - 뮤지컬 & 연극 : 극장이 멀어 직접 관람하지 못한 구매자들이 펀딩하여 녹화본을 받아 볼 수 있도록 함 ( 녹화물에 대한 녹화, 배포 안됨)<br>


HISTORY
---
[TOTAL] | [김규호] | [안지윤] | [옥은진] | [홍재성] |
-


PLANS
---
 |LANGUAGE|PLAN|IMPLEMENT|DESCRIPTION|
 |-|-|-|-|
 |DB설계|-|-|-|
 |FRONT-END|-|-|-|
 |BACK-END|-|-|-|


MEMBERS
---
 |NAME|ROLE|DETAILS|DESCRIPTION|
 |-|-|-|-|
 |김규호|-|-|-|
 |안지윤|-|-|-|
 |옥은진|-|-|-|
 |홍재성|-|-|-|


SKILLS
---
### Front-End
---
 <img src="https://img.shields.io/badge/HTML5-f75421?style=for-the-badge&logo=htmlacademy&logoColor=white"> <img src="https://img.shields.io/badge/CSS-1572B6?style=for-the-badge&logo=css3&logoColor=white"> <img src="https://img.shields.io/badge/JAVASCRIPT-e8d44d?style=for-the-badge&logo=javascript&logoColor=white"> 


### Back-End
---
 <img src="https://img.shields.io/badge/JAVA-e13f33?style=for-the-badge&logo=doubanread&logoColor=white"> <img src="https://img.shields.io/badge/JSP-1E8CBE?style=for-the-badge&logo=doubanread&logoColor=white"> <img src="https://img.shields.io/badge/SERVLET-4B4B77?style=for-the-badge&logo=doubanread&logoColor=white"> <img src="https://img.shields.io/badge/SPRING-STS3-6DB33F?style=for-the-badge&logo=spring&logoColor=white"> <img src="https://img.shields.io/badge/SPRINGBOOT-6DB33F?style=for-the-badge&logo=springboot&logoColor=white"> 


### DataBase
---
 <img src="https://img.shields.io/badge/MYSQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white">  


### DevOps
---
<img alt="git" src="https://img.shields.io/badge/GIT-F05032?style=for-the-badge&logo=git&logoColor=white"> <img alt="github" src="https://img.shields.io/badge/GITHUB-181717?style=for-the-badge&logo=github2&logoColor=white"> <img alt="notion" src ="https://img.shields.io/badge/notion-000000.svg?&style=for-the-badge&logo=notion&logoColor=white"/>
<img alt="slack" src ="https://img.shields.io/badge/slack-481449.svg?&style=for-the-badge&logo=slack&logoColor=white"/> <img src="https://img.shields.io/badge/AWS-EC2-FF9900?style=for-the-badge&logo=amazonec2&logoColor=white">


END POINT DOC
---
|URI|REQUEST METHOD|REQUEST PARAMETER TYPE|RESPONSE VALUE TYPE|DESCRIPTION
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|
|-|-|-|-|-|


DEPENDENCIES LIST
---
|CAT|NAME|DESCRIPTION|LINK|-|-|
|-|-|-|-|-|-|
|FN|-|-|-|-|-|
|FN|-|-|-|-|-|
|BN|-|-|-|-|-|
|BN|-|-|-|-|-|
|DB|-|-|-|-|-|
|DEVOPS|-|-|-|-|-|


ERD[]
---


FILE TREES[JSP/SERVLET]
---
```
Windows 볼륨에 대한 폴더 경로의 목록입니다.
볼륨 일련 번호는 B088-B8B1입니다.
C:.
│  .classpath
│  .project
│  
├─.settings
│      .jsdtscope
│      org.eclipse.core.resources.prefs
│      org.eclipse.jdt.core.prefs
│      org.eclipse.wst.common.component
│      org.eclipse.wst.common.project.facet.core.xml
│      org.eclipse.wst.jsdt.ui.superType.container
│      org.eclipse.wst.jsdt.ui.superType.name
│      
├─build
│  └─classes
│      └─com
│          └─example
│              └─app
│                  ├─controller
│                  │  └─product
│                  ├─domain
│                  │  └─common
│                  │      ├─dao
│                  │      │  └─common
│                  │      ├─dto
│                  │      └─service
│                  └─filter
└─src
    └─main
        ├─ImportedClasses
        │  └─com
        │      └─example
        │          └─app
        │              ├─controller
        │              │  │  FrontController.class
        │              │  │  HomeController.class
        │              │  │  SubController.class
        │              │  │  
        │              │  └─product
        │              │          ProductDeleteController.class
        │              │          ProductInsertController.class
        │              │          ProductListController.class
        │              │          ProductUpdateController.class
        │              │          
        │              ├─domain
        │              │  └─common
        │              │      ├─dao
        │              │      │  │  ProductDao.class
        │              │      │  │  ProductDaoImpl.class
        │              │      │  │  
        │              │      │  └─common
        │              │      │          CommonDao.class
        │              │      │          ConnectionPool.class
        │              │      │          ConnectionPool_ByHikari.class
        │              │      │          
        │              │      ├─dto
        │              │      │      Criteria.class
        │              │      │      PageDto.class
        │              │      │      productDto.class
        │              │      │      
        │              │      └─service
        │              │              ProductService.class
        │              │              ProductServiceImpl.class
        │              │              
        │              └─filter
        │                      UTF_8_EncodingFilter.class
        │                      
        ├─java
        │  └─com
        │      └─example
        │          └─app
        │              ├─controller
        │              │  └─product
        │              ├─domain
        │              │  └─common
        │              │      ├─dao
        │              │      │  └─common
        │              │      ├─dto
        │              │      └─service
        │              └─filter
        └─webapp
            ├─META-INF
            │      context.xml
            │      MANIFEST.MF
            │      
            ├─resources
            └─WEB-INF
                │  web.xml
                │  
                ├─lib
                │      commons-logging-1.3.1.jar
                │      jstl-1.2.jar
                │      logback-classic-1.5.3.jar
                │      mysql-connector-j-8.3.0.jar
                │      slf4j-api-2.0.12.jar
                │      
                └─view
                    │  index.jsp
                    │  
                    └─product
                            add.jsp
                            list.jsp
                            update.jsp
                            
```
 <img src="https://capsule-render.vercel.app/api?type=waving&color=cde4ad&height=150&section=footer" />
