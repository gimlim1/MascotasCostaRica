USE [MascotasCR]
GO

----------- Se borran foraneas ------
IF EXISTS (SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'FK_User_Rol_RolID')
BEGIN
ALTER TABLE [dbo].[User] DROP CONSTRAINT  FK_User_Rol_RolID
END


----------- Se borran tablas ------
IF OBJECT_ID('dbo.Rol', 'U') IS NOT NULL
DROP TABLE [dbo].[Rol]

IF OBJECT_ID('dbo.User', 'U') IS NOT NULL
DROP TABLE [dbo].[User]


----------- Se crean tablas ------
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rol](
	RolID [int] IDENTITY(1,1),
	Nombre [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_Rol_RolID] PRIMARY KEY CLUSTERED 
(
	[RolID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[User](
	UserID [INT] IDENTITY(1,1),
	UserFirstName [nvarchar](50) NOT NULL,
	UserLastName [nvarchar] (50) NOT NULL,
	Email [nvarchar] (50) NOT NULL,
	Phone [nvarchar] (50) NOT NULL,
	Username [nvarchar] (50) NOT NULL,
	Password [nvarchar] (50) NOT NULL,
	Active [int] NOT NULL,
	RolID [int] NOT NULL
 CONSTRAINT [PK_User_UserID] PRIMARY KEY CLUSTERED 
(
	[UserID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Rol_RolID] FOREIGN KEY([RolID])
REFERENCES [dbo].[Rol] ([RolID])
GO





