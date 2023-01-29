USE [dbIMS]
GO

/****** Object:  Table [dbo].[tbCustomer]    Script Date: 12/24/2022 2:24:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbCustomer](
	[cid] [int] NOT NULL,
	[cname] [varchar](50) NOT NULL,
	[cphone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbCustomer] PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

