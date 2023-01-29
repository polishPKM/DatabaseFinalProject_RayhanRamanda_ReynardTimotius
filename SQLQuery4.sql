USE [dbIMS]
GO

/****** Object:  Table [dbo].[tbOrder]    Script Date: 12/24/2022 2:25:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbOrder](
	[orderid] [int] NOT NULL,
	[odate] [date] NOT NULL,
	[pid] [int] NOT NULL,
	[cid] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[price] [int] NOT NULL,
	[total] [int] NOT NULL,
 CONSTRAINT [PK_tbOrder] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

