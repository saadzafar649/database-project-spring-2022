CREATE TABLE CategoryTable(
    CategoryId int GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    CategoryName VARCHAR(20),
    PRIMARY KEY(CategoryId)
    );

CREATE TABLE Product(
    productId INT GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1) ,
    productName VARCHAR(30),
    productTitle VARCHAR(200),
    productDescription VARCHAR(3000),
    Price INT DEFAULT(0),
    Discount INT DEFAULT(0),
    imageLink VARCHAR(300),
    active int Default(1),
    productCategory int,
    watchCount int default 0,
    PRIMARY KEY(productId ),
    Foreign Key(productCategory) References CategoryTable(CategoryId) ON DELETE SET NULL
    );


CREATE TABLE Color(
    ProductId INT,
    ColorName VARCHAR(20),
    quantity INT DEFAULT(0),
    Foreign Key(ProductId) References Product(ProductId) ON DELETE CASCADE
    );
    
CREATE TABLE Person(
    personId INT GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1) ,
    personName VARCHAR(30),
    email VARCHAR(50),
    personType VARCHAR(20),
    phoneNo Numeric(18,0),
    PRIMARY KEY(personId)
    );

CREATE TABLE Auth(
    personId INT,
    Username VARCHAR(30) NOT NULL,
    Pass VARCHAR(30) NOT NULL,
    lastlogin TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Foreign Key(personId) References Person(personId)
    );


CREATE TABLE Review(
    ReviewId int GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    ProductId int,
    personId Int,
    Review VARCHAR(500),
    Stars int DEFAULT(0),
    ReviewTime TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(ReviewId),
    Foreign Key(ProductId) References Product(ProductId),
    Foreign Key(personId) References Person(personId)
    );