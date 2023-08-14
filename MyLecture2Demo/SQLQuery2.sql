﻿-- Creating table 'Units'
CREATE TABLE [dbo].[Units] (
 [Id] int IDENTITY(1,1) NOT NULL,
 [Name] nvarchar(max) NOT NULL,
 [Description] nvarchar(max) NOT NULL,
 [StudentId] int NOT NULL,
PRIMARY KEY (Id),
FOREIGN KEY (StudentId) REFERENCES Students(Id)
);
GO