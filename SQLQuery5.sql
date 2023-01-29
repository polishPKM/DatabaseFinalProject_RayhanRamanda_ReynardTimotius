USE [dbIMS]
GO

/****** Object:  Table [dbo].[tbProduct]    Script Date: 12/24/2022 2:25:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbProduct](
	[pid] [int] NOT NULL,
	[pname] [varchar](50) NOT NULL,
	[pqty] [int] NOT NULL,
	[pprice] [int] NOT NULL,
	[pdescription] [varchar](50) NOT NULL,
	[pcategory] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

