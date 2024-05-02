File Tree(ADD Interface) - FundingProject
---
```    
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
---

<hr/>

<h2>MVC PATTERN</h2>
Presentation Layer(프레젠테이션 계층)
- 사용자의 요청사항을 받아서 해당 서비스로 연결해주고 처리 결과를 사용자에게 알려주는 영역
<img src="https://github.com/EM-PROJECT-ORG-Funrest/EM_Module_Test/assets/102271645/9def9d67-4640-45b5-bdfa-e7f279eac48a">


