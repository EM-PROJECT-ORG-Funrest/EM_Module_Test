Product CRUD 구현 & ERD, MVC Pattern, Class Diagram 구현
---
- 이전 회차에 진행했던 모듈 수정 작업 수행
- 상품에 대한 `[조회(키워드별, 전체), 삽입, 수정, 삭제]` 기능 구현
- 페이징 처리 기능 구현
- 현재 제출 자료에 대한 `ERD`, `MVC Pattern`, `Class Diagram` 구현
- FILE-TREE 제출
<hr/>

Entity Relationship Diagram(ERD)
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/b28d03bc-f5bf-4b9e-a16b-52a9d2b4ba74"></img>

<hr/>

Class Diagram
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/8f3d9787-f295-48bc-9736-f853e520483e"></img>
  <img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/017e9d58-ee62-4262-a0fd-33fab757e0b0"></img>
  <img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/bdb70777-7f41-4a7d-ac82-207212c8a0c3"></img>

<hr/>

MVC Pattern
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/eadfb68a-9a54-4794-8648-f5fd0415dfb7"></img>

<hr/>

Main View
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/8c464d16-b6d0-4381-b231-2578ce50932e"></img>

<hr/>

Select Service
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/6f0af688-7bc4-489c-8563-13550193ffc0"></img>

<hr/>

Insert Service
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/560da78b-b1bd-4026-b69e-a0d85d6ca236"></img>
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/568666ef-31df-476a-8724-fe03c89d5694"></img>

<hr/>

Update Service
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/db4711f7-f43f-42be-b457-a4d866129cec"></img>
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/d4d436bd-c544-48af-80f4-43346c740418"></img>

<hr/>

Delete Service(Main View 시점과 비교)
---
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/d8bcb918-037e-48a2-a832-615ec38b7fe9"></img>

<hr/>

File-Tree
---
```
C:.
├─build
│  └─classes
│      └─com
│          └─example
│              └─app
│                  ├─controller
│                  │  │  FrontController.class
│                  │  │  HomeController.class
│                  │  │  SubController.class
│                  │  │  
│                  │  └─product
│                  │          ProductDeleteController.class
│                  │          ProductInsertController.class
│                  │          ProductListController.class
│                  │          ProductUpdateController.class
│                  │          
│                  ├─domain
│                  │  └─common
│                  │      ├─dao
│                  │      │  │  ProductDao.class
│                  │      │  │  ProductDaoImpl.class
│                  │      │  │  
│                  │      │  └─common
│                  │      │          CommonDao.class
│                  │      │          ConnectionPool.class
│                  │      │          ConnectionPool_ByHikari.class
│                  │      │          
│                  │      ├─dto
│                  │      │      Criteria.class
│                  │      │      PageDto.class
│                  │      │      productDto.class
│                  │      │      
│                  │      └─service
│                  │              ProductService.class
│                  │              ProductServiceImpl.class
│                  │              
│                  └─filter
│                          UTF_8_EncodingFilter.class
│                          
└─src
    └─main
        ├─java
        │  └─com
        │      └─example
        │          └─app
        │              ├─controller
        │              │  │  FrontController.java
        │              │  │  HomeController.java
        │              │  │  SubController.java
        │              │  │  
        │              │  └─product
        │              │          ProductDeleteController.java
        │              │          ProductInsertController.java
        │              │          ProductListController.java
        │              │          ProductUpdateController.java
        │              │          
        │              ├─domain
        │              │  └─common
        │              │      ├─dao
        │              │      │  │  ProductDao.java
        │              │      │  │  ProductDaoImpl.java
        │              │      │  │  
        │              │      │  └─common
        │              │      │          CommonDao.java
        │              │      │          ConnectionPool.java
        │              │      │          ConnectionPool_ByHikari.java
        │              │      │          
        │              │      ├─dto
        │              │      │      Criteria.java
        │              │      │      PageDto.java
        │              │      │      productDto.java
        │              │      │      
        │              │      └─service
        │              │              ProductService.java
        │              │              ProductServiceImpl.java
        │              │              
        │              └─filter
        │                      UTF_8_EncodingFilter.java
        │                      
        └─webapp
            ├─META-INF
            │      context.xml
            │      MANIFEST.MF
            │      
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


