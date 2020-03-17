USE Northwind
--Reset stuff while testing********************************
DROP ROLE IF EXISTS SalesRole
DROP ROLE IF EXISTS HRRole
DROP ROLE IF EXISTS CEORole
--Create Roles*********************************************
CREATE ROLE SalesRole
CREATE ROLE HRRole
CREATE ROLE CEORole
--Give permissions******************************************
GRANT SELECT ON dbo.Customers TO SalesRole
GRANT SELECT ON dbo.Orders TO SalesRole
GRANT SELECT ON dbo.Employees TO HRRole
GRANT SELECT ON dbo.Customers TO CEORole
GRANT SELECT ON dbo.Orders TO CEORole
GRANT SELECT ON dbo.Employees TO CEORole
--Create Logins**********************************************
CREATE LOGIN Login_Ceo WITH PASSWORD = 'Login_Ceo';
CREATE LOGIN Login_HR WITH PASSWORD = 'Login_HR';
CREATE LOGIN Login_Sales WITH PASSWORD = 'Login_Sales';
--Create Users for logins************************************
CREATE USER User_Ceo FOR LOGIN Login_Ceo
CREATE USER User_HR FOR LOGIN Login_HR
CREATE USER User_Sales FOR LOGIN Login_Sales
--Add users to role******************************************
ALTER ROLE SalesRole
	ADD MEMBER User_Sales
ALTER ROLE HRRole
	ADD MEMBER User_HR
ALTER ROLE CEORole
	ADD MEMBER User_Ceo