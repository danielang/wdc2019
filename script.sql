USE [wdc2019workshop]
GO
/****** Object:  User [wdcuser]    Script Date: 16.10.2019 15:55:59 ******/
CREATE USER [wdcuser] FOR LOGIN [wdcuser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [wdcuser]
GO
/****** Object:  Table [dbo].[hotels]    Script Date: 16.10.2019 15:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hotels](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](64) NULL,
	[rooms_max] [smallint] NULL,
	[rooms_curr] [smallint] NULL
) ON [PRIMARY]
GO
