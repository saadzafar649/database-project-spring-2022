CREATE OR REPLACE PROCEDURE ADDWATCHCOUNT(IDPARM IN INT) 
IS
watchCount1 product.watchcount%type;
BEGIN
    SELECT watchCount
    INTO watchCount1
    FROM Product
    WHERE productId = IDPARM;
    watchCount1 := watchCount1 + 1;
    UPDATE Product 
    SET watchCount = watchCount1
    WHERE productId = IDPARM;
    commit;
END;
