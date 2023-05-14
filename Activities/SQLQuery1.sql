create database revature;
use revature;
-- Create the Person table
CREATE TABLE Person
(
    PersonID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT
);

-- Create the Address table
CREATE TABLE Address
(
    AddressID INT PRIMARY KEY IDENTITY(1,1),
    PersonID INT FOREIGN KEY REFERENCES Person(PersonID),
    Street VARCHAR(50),
    City VARCHAR(50),
    State VARCHAR(50),
    ZipCode VARCHAR(10)
);

-- Insert sample data into the Person table
INSERT INTO Person (FirstName, LastName, Age)
VALUES 
('John', 'Doe', 32),
('Jane', 'Doe', 28),
('Jim', 'Smith', 40);
--Begin Transaction
INSERT INTO Person (FirstName, LastName, Age)
VALUES 
('Bhaskar', 'patna', 33);
--commit
--RollBack;

select * from Person
delete from person where PersonID=9;

CREATE TRIGGER tr_person_Insert
ON Person
AFTER INSERT
AS
BEGIN
    -- Check if the inserted employee is already in the 'People' table
    IF EXISTS (SELECT * FROM Person WHERE age = (SELECT age FROM inserted))
    BEGIN
        -- Raise an error if the employee is already in the 'People' table
        RAISERROR('This person is already in the People table.', 16, 1);
        ROLLBACK TRAN;
    END;
END;

-- Insert sample data into the Address table
INSERT INTO Address (PersonID, Street, City, State, ZipCode)
VALUES 
(1, '123 Main St', 'New York', 'NY', '10001'),
(2, '456 Park Ave', 'Los Angeles', 'CA', '90001'),
(3, '789 Market St', 'Chicago', 'IL', '60601');
-- Create two sample tables, 'People' and 'Employees'
CREATE TABLE People (ID INT PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50));
CREATE TABLE Employees (ID INT PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50));

-- Insert sample data into the 'People' table
INSERT INTO People (ID, FirstName, LastName)
VALUES (1, 'John', 'Doe'), (2, 'Jane', 'Doe'), (3, 'Jim', 'Smith');

-- Insert sample data into the 'Employees' table
INSERT INTO Employees (ID, FirstName, LastName)
VALUES (1, 'John', 'Doe'), (4, 'Jane', 'Jones'), (5, 'Jim', 'Johnson');
select * from people;
select * from Employees

-- Use UNION to combine the result sets of two SELECT statements, removing duplicates
SELECT FirstName,LastName
FROM People
UNION
SELECT FirstName, LastName
FROM Employees;

select  Id ,FirstName,LastName
from People
Except
select id, FirstName,LastName
from Employees

-- Use UNION ALL to combine the result sets of two SELECT statements, keeping duplicates
SELECT FirstName, LastName
FROM People
UNION ALL
SELECT FirstName, LastName
FROM Employees;

-- Inner Join (returns only matching rows from both tables)
SELECT p.FirstName, p.LastName, a.Street, a.City, a.State
FROM Person p
INNER JOIN Address a ON p.PersonID = a.PersonID;

-- Left Join (returns all rows from the left table and matching rows from the right table)
SELECT p.FirstName, p.LastName, a.Street, a.City, a.State
FROM Person p
LEFT JOIN Address a ON p.PersonID = a.PersonID;

-- Right Join (returns all rows from the right table and matching rows from the left table)
SELECT p.FirstName, p.LastName, a.Street, a.City, a.State
FROM Person p
RIGHT JOIN Address a ON p.PersonID = a.PersonID;

-- Full Outer Join (returns all rows from both tables, with NULL values for non-matching rows)
SELECT p.FirstName, p.LastName, a.Street, a.City, a.State
FROM Person p
FULL OUTER JOIN Address a ON p.PersonID = a.PersonID;


-- Define a CTE to return the first 10 people
WITH PeopleCTE AS (
  SELECT TOP 10 ID, FirstName, LastName
  FROM People
)
-- Use the CTE to select the first 10 people
SELECT *
FROM PeopleCTE;

