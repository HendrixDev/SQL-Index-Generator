# SQL-Index-Generator
Generates SQL to create DB indexes based on read text file

Tasked with creating indexes on a database to improve the speed and performance of queries. 
As I was scanning the columns of each table to determine which columns should be indexed, I opened an instance of notepad.
When I had finished there were alot more indexes that I had anticipated.
Instead of manually typing the SQL to build the indexes, I wrote this program to parse my notepad and build the queries automatically:

Input Format:
COLUMN on TABLE
FirstName on tblPerson
LastName on tblPerson

Expected output:
<br>
--COLUMN on TABLE
CREATE INDEX TABLE_COLUMN_idx
ON TABLE (COLUMN);

--FirstName on tblPerson
CREATE INDEX tblPerson_FirstName_idx
ON tblPerson (FirstName);

--LastName on tblPerson
CREATE INDEX tblPerson_LastName_idx
ON tblPerson (LastName);
