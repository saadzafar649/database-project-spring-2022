
Insert into CategoryTable(CategoryName) VALUES('Shoes');
Insert into CategoryTable(CategoryName) VALUES('Shirts');
Insert into CategoryTable(CategoryName) VALUES('Shorts');
Insert into CategoryTable(CategoryName) VALUES('Socks');

Insert Into Product(productName,productTitle,productDescription,Price,imageLink,productCategory)
VALUES('BUSENITZ PRO SHOES','Orignal BUSENITZ PRO SHOES',
'This style is the result of a collaboration between adidas Action Sports and Dennis Busenitz. These shoes transform the Copa Mundial football boot into skate shoes built for Dennis signature all-terrain skating. With a durable upper, cupsole construction and a Geofit collar, the shoes will help you take on any obstacle'
,80,'https://assets.adidas.com/images/w_600,f_auto,q_auto/dfb2593201f8422280c7a7fa00e4768a_9366/Busenitz_Pro_Shoes_Black_G48060.jpg',1);

INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(1,'BLUE',10);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(1,'GREEN',10);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(1,'YELLOW',10);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(1,'RED',5);


Insert Into Product(productName,productTitle,productDescription,Price,imageLink,productCategory)
VALUES('Mens Maroon Plain Shirt','Mens Maroon Plain Shirt - EMTSB21-035 Orignal BUSENITZ PRO SHOES',
'Mens Formal Shirt<br>Regular Fit<br>Cotton Fabric<br>Wide Collar<br>Barrel Cuff<br>edenrobe Engraved Button<br><br>'
,40,'https://cdn.edenrobe.com/media/catalog/product/cache/e38112291c6befe51adab3aecb028052/0/n/0n9a7991-emtsb21-035.jpg',2);

INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(41,'BLUE',4);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(41,'GREEN',2);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(41,'YELLOW',1);
INSERT INTO Color(ProductId,ColorName,QUANTITY) VALUES(41,'RED',5);

INSERT INTO Person(personName,email,personType,phoneNo) VALUES('Saad','saadzafar649@gmail.com','user',03157055586);

INSERT INTO Auth(personId,Username,Pass) VALUES(1,'SAAD','1234');