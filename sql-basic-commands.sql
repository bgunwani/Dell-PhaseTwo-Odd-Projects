

-- CREATE NEW DATABASE

	CREATE DATABASE TrainingDB;

-- USE EXISTING DATABASE

	USE TrainingDB;

-- Create New Database Table named `department`

	CREATE TABLE Department
	(DeptId int,
	DeptName varchar(200),
	DeptLocation varchar(200),
	DeptAddedDate datetime);

-- Retrieve All the Data from `department` table

	SELECT * FROM Department;

-- Insert Sample Data into `department` table

	INSERT INTO Department VALUES(101, 'Sales', 'Chennai', GETDATE());
	INSERT INTO Department VALUES(102, 'Testing', 'Bangalore', '2021-11-01');
	INSERT INTO Department VALUES(103, 'Development', 'Bangalore', '11-01-2021');
	INSERT INTO Department VALUES(104, 'Admin', 'Chennai', '11-2021-01');
	INSERT INTO Department(DeptId, DeptLocation, DeptName) VALUES(105, 'Chennai', 'Advertisment');

-- Update Specific Records in `Department` Table

	UPDATE Department
	SET DeptLocation = 'Hyderabad', DeptAddedDate = GETDATE()
	WHERE DeptId = 104

-- Update All Records in `Department` Table

	UPDATE Department
	SET DeptAddedDate = GETDATE()

-- Delete Specific Records from `Department` Table

	DELETE FROM Department
	WHERE DeptLocation = 'Chennai';

-- Delete All Records from `Department` Table

	Delete from Department;

-- Drop Database Table

	Drop TABLE Department;