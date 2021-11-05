

-- Create New Database Table named `department`

	CREATE TABLE Department
	(DeptId int primary key,
	DeptName varchar(200) not null,
	DeptLocation varchar(200) check (DeptLocation IN ('Chennai', 'Bangalore', 'Hyderabad')),
	DeptAddedDate datetime default GETDATE());

-- Insert Sample Data into `department` table

	INSERT INTO Department VALUES(101, 'Sales', 'Chennai', GETDATE());
	INSERT INTO Department VALUES(102, 'Testing', 'Hyderabad', DEFAULT);
	INSERT INTO Department(DeptId, DeptName, DeptLocation) VALUES(103, 'Development', 'Bangalore');
	INSERT INTO Department VALUES(104, 'Admin', 'Bangalore', DEFAULT);
	INSERT INTO Department VALUES(105, 'Production', 'Chennai', DEFAULT);

	SELECT * FROM Department;

-- Create New Database Table named `department`

	CREATE TABLE Employee
	(EmpId int primary key,
	EmpName varchar(200) not null,
	EmpEmail varchar(200) unique,
	EmpSalary float check (EmpSalary > 5000),
	EmpAddedDate DateTime default GETDATE(),
	DeptId int foreign key references Department(DeptId))

	SELECT * FROM Employee;

-- Insert Sample Data into `employee` table

	INSERT INTO Employee VALUES(5001, 'Kartik Sharma', 'kartik@gmail.com', 12000, DEFAULT, 101);
	INSERT INTO Employee VALUES(5002, 'King Kochhar', 'king@gmail.com',20000, DEFAULT, 102);
	INSERT INTO Employee VALUES(5003, 'Shreya Ghoshal', 'shreya@gmail.com',22000, DEFAULT, 101);
	INSERT INTO Employee VALUES(5004, 'Sujatha Batra', 'sujatha@gmail.com',15000, DEFAULT, 102);
	INSERT INTO Employee VALUES(5005, 'Venky Deva', 'venky@gmail.com',30000, DEFAULT, 103);
	INSERT INTO Employee VALUES(5006, 'Sarah Bowling', 'sarah@gmail.com',8000, DEFAULT, 104);
	INSERT INTO Employee VALUES(5007, 'Gautam Bhalla', 'gautam@gmail.com',10000, DEFAULT, 103);
	INSERT INTO Employee VALUES(5008, 'John Smith', 'john@gmail.com',21000, DEFAULT, 104);
	INSERT INTO Employee VALUES(5009, 'Roger Lee', 'roger@gmail.com',23000, DEFAULT, NULL);

	SELECT * FROM Department;
	SELECT * FROM Employee;

-- Projection: Restricting Columns

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee;

-- Selection: Restricting Rows

	SELECT * 
	FROM Employee
	WHERE EmpSalary > 15000;

-- Projection and Selection: Restricting Columns and Rows

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary > 15000;

-- Arithmetic Operators (+, -, *, /):

	SELECT EmpId, EmpName, EmpSalary, EmpSalary*12 as AnnualSalary
	FROM Employee
	WHERE EmpSalary > 15000;

	SELECT EmpId, EmpName, EmpSalary, EmpSalary*12 as 'Annual Salary'
	FROM Employee
	WHERE EmpSalary > 15000;

-- Logical Operators (AND, OR, NOT):

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary >= 10000 AND EmpSalary <= 20000;

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName = 'Kartik Sharma' AND EmpSalary = 12000;

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName = 'Kartik Sharma' OR EmpName = 'Venky Deva' OR EmpName = 'Gautam Bhalla';

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName = 'Kartik Sharma' AND NOT EmpSalary = 20000;

-- Misc Operators (BETWEEN, IN, LIKE, NOT NULL)

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary BETWEEN 10000 and 20000

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary NOT BETWEEN 10000 and 20000

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName IN ('Kartik Sharma', 'Venky Deva', 'Gautam Bhalla');

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName NOT IN ('Kartik Sharma', 'Venky Deva', 'Gautam Bhalla');

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName LIKE 'S%';

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName LIKE '%a';
	
	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName LIKE '%a%';

	SELECT EmpId, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName LIKE '_a%';

	SELECT EmpId, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE DeptId IS NULL

	SELECT EmpId, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE DeptId IS NOT NULL

-- JOIN: Retrieving Data from More than One Table:

	SELECT * FROM Department;
	SELECT * FROM Employee;

-- Retrieve Employee Name and their respective Department Name

	SELECT Employee.EmpName,Employee.EmpSalary, Department.DeptName, Department.DeptLocation
	FROM Employee JOIN Department
	ON Employee.DeptId = Department.DeptId

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e JOIN Department d
	ON e.DeptId = d.DeptId

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e JOIN Department d
	ON e.DeptId = d.DeptId
	WHERE e.EmpSalary > 15000

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e JOIN Department d
	ON e.DeptId = d.DeptId
	AND e.EmpSalary > 15000

-- Left Outer Join: Retrieve all records from Left Table only matched records from Right Table

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e LEFT OUTER JOIN Department d
	ON e.DeptId = d.DeptId

-- Right Outer Join: Retrieve all records from Right Table only matched records from left Table

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e Right OUTER JOIN Department d
	ON e.DeptId = d.DeptId

-- Full Outer Join: Retrieve all matched and non-matched records from Left and Right Table

	SELECT e.EmpName,e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e full OUTER JOIN Department d
	ON e.DeptId = d.DeptId
	
	SELECT * FROM Employee;
	SELECT * FROM Department;
	

