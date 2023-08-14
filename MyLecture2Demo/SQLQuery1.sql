-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
 [Id] int IDENTITY(1,1) NOT NULL,
 [FirstName] nvarchar(max) NOT NULL,
 [LastName] nvarchar(max) NOT NULL,
PRIMARY KEY (Id)
);
GO