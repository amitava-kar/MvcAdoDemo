--
-- File generated with SQLiteStudio v3.3.3 on Sat May 7 12:33:35 2022
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Employees
DROP TABLE IF EXISTS Employees;

CREATE TABLE Employees (
    EmployeeId  INTEGER         PRIMARY KEY
                                UNIQUE
                                NOT NULL,
    Name        VARCHAR (60),
    Address     VARCHAR (255),
    Designation VARCHAR (60),
    Salary      DECIMAL (12, 2),
    JoiningDate DATE            DEFAULT [dd/mm/yyyy]
);

INSERT INTO Employees (
                          EmployeeId,
                          Name,
                          Address,
                          Designation,
                          Salary,
                          JoiningDate
                      )
                      VALUES (
                          1,
                          'Amitava Kar',
                          'Sankrail, Howrah, WB-711313',
                          'PM',
                          90000,
                          '06/05/2022'
                      );


-- Index: sqlite_autoindex_Employees_1
DROP INDEX IF EXISTS sqlite_autoindex_Employees_1;

CREATE INDEX sqlite_autoindex_Employees_1 ON Employees (
    EmployeeId COLLATE BINARY
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
