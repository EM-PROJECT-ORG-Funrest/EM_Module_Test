<h2>상품관련 CRUD</h2> <br/>
컬럼명 :  `GD_CODE`,  `GD_NM`,  `FMLY_PRCE`, `SPLY_CO_NM`, `OGPL_NM`

 상품 정보에 대한 테이블 생성 후 [조회, 삽입, 수정, 삭제] 가능

페이지 사진
---
MainPage

<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/f758e576-a7bf-445c-a69d-41e98be5dd97"></img>

UpdatePage

<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/967bf378-b758-4332-9bb2-8ec676aa4e84"></img>

InsertPage

<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/e1542352-b3d9-4349-b689-6f59b360fa09"></img>



File Tree
---
```
Windows 볼륨에 대한 폴더 경로의 목록입니다.
볼륨 일련 번호는 B088-B8B1입니다.
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
