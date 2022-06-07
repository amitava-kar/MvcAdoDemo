CREATE TABLE Employees_old (
    EmployeeId  INTEGER         PRIMARY KEY
                                UNIQUE
                                NOT NULL,
    Name        VARCHAR (60),
    Address     VARCHAR (255),
    Designation VARCHAR (60),
    Salary      DECIMAL (12, 2),
    JoiningDate DATE
);
