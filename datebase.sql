USE [CustomLogin]
GO
/****** Object:  Table [dbo].[login]    Script Date: 26.02.2023 5:55:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](16) NULL,
	[password] [nchar](16) NULL,
	[admin] [int] NOT NULL,
	[firstname] [nchar](21) NULL,
	[lastname] [nchar](21) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[login] ADD  CONSTRAINT [DF_login_admin]  DEFAULT ((0)) FOR [admin]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'user_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'login user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'secret code of user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'lvl admin privelegy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login', @level2type=N'COLUMN',@level2name=N'admin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'table of users' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'login'
GO
