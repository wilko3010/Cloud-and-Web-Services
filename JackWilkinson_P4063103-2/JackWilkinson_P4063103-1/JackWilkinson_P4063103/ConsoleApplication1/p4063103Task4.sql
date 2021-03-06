/*
   25 January 201616:37:54
   User: 
   Server: SCM-99891\SQLEXPRESS
   Database: p4063103Task4
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	skillCode nchar(10) NOT NULL,
	skillName nchar(100) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	PK_Table_1 PRIMARY KEY CLUSTERED 
	(
	skillCode
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
