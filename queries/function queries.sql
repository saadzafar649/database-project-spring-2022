CREATE OR REPLACE FUNCTION authuser(username auth.username%type,pass auth.pass%type)
RETURN INT
IS
RET INT;
BEGIN
    RET:=-1;
    SELECT a.personid
    INTO RET
    FROM Auth A
    WHERE a.username = username
    AND a.pass = pass;
    RETURN RET;
END;
/

CREATE OR REPLACE FUNCTION usertype(userid int)
RETURN VARCHAR2
IS
RET person.persontype%type;
BEGIN
    SELECT personType
    INTO RET
    FROM Person P
    WHERE personId = userid;
    RETURN RET;
END;
/