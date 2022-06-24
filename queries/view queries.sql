CREATE OR REPLACE VIEW ProductCard
AS SELECT p.ProductId,Price,productName,productTitle,imageLink,productCategory,watchCount,AVG(Stars) AS Stars                                                        
FROM Product P
LEFT JOIN Review R
ON P.ProductId = R.ProductId
WHERE active = 1
GROUP BY p.ProductId,Price,productName,productTitle,imageLink,productCategory,watchCount;