USE [p4063103Hebbraco]
GO
/****** Object:  Table [dbo].[BusinessUnit]    Script Date: 13/10/2015 14:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusinessUnit](
	[businessUnitId] [int] IDENTITY(1,1) NOT NULL,
	[businessUnitCode] [nchar](10) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[officeAddress1] [nvarchar](max) NOT NULL,
	[officeAdresss2] [nvarchar](max) NOT NULL,
	[officeAddress3] [nvarchar](max) NOT NULL,
	[officePostCode] [nchar](10) NOT NULL,
	[officeContact] [nvarchar](max) NOT NULL,
	[officePhone] [nvarchar](50) NOT NULL,
	[officeEmail] [nvarchar](50) NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_BusinessUnit] PRIMARY KEY CLUSTERED 
(
	[businessUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 13/10/2015 14:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[staffId] [int] IDENTITY(1,1) NOT NULL,
	[businessUnitId] [int] NOT NULL,
	[staffCode] [nvarchar](50) NOT NULL,
	[firstName] [nvarchar](max) NOT NULL,
	[middleName] [nvarchar](max) NOT NULL,
	[lastName] [nvarchar](max) NOT NULL,
	[dob] [date] NOT NULL,
	[startDate] [date] NOT NULL,
	[profile] [nvarchar](max) NULL,
	[emailAddress] [nvarchar](max) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[staffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BusinessUnit] ON 

INSERT [dbo].[BusinessUnit] ([businessUnitId], [businessUnitCode], [title], [description], [officeAddress1], [officeAdresss2], [officeAddress3], [officePostCode], [officeContact], [officePhone], [officeEmail], [Active]) VALUES (4, N'AnSrBu    ', N'Analytical Services', N'none', N'Unit 4', N'business park', N'Thornaby-on-Tees', N'TS17 9DE  ', N'01642 487593', N'01642 123654', N'anylyticalservices@business.com', NULL)
INSERT [dbo].[BusinessUnit] ([businessUnitId], [businessUnitCode], [title], [description], [officeAddress1], [officeAdresss2], [officeAddress3], [officePostCode], [officeContact], [officePhone], [officeEmail], [Active]) VALUES (5, N'RaPrBu    ', N'Radiation Protection', N'none', N'Unit 5', N'business park', N'Thornaby-on-Tees', N'TS17 9DE  ', N'01642 382389', N'01642 098123', N'radiationprotection@business.com', NULL)
INSERT [dbo].[BusinessUnit] ([businessUnitId], [businessUnitCode], [title], [description], [officeAddress1], [officeAdresss2], [officeAddress3], [officePostCode], [officeContact], [officePhone], [officeEmail], [Active]) VALUES (6, N'ReTeBu    ', N'Reservoir Technologies', N'none', N'Unit 6', N'industry way', N'Middlesbrough', N'TS17 5JW  ', N'01642 894233', N'01642 827384', N'resevoirtechnology@business.com', NULL)
INSERT [dbo].[BusinessUnit] ([businessUnitId], [businessUnitCode], [title], [description], [officeAddress1], [officeAdresss2], [officeAddress3], [officePostCode], [officeContact], [officePhone], [officeEmail], [Active]) VALUES (7, N'SuTeBu    ', N'Subsea Technologies', N'none', N'Unit 7', N'workmans walk', N'Ingleby Barwik', N'TS17 9DE  ', N'01642 123483', N'01642 110043', N'subseatechnology@business.com', NULL)
SET IDENTITY_INSERT [dbo].[BusinessUnit] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([staffId], [businessUnitId], [staffCode], [firstName], [middleName], [lastName], [dob], [startDate], [profile], [emailAddress], [Active]) VALUES (2, 4, N'6345', N'Richard', N'James', N'Spence', CAST(N'1996-03-20' AS Date), CAST(N'2006-05-04' AS Date), N'average height, with brown hair and brown eyes', N'r.j.spence@gmail.com', 1)
INSERT [dbo].[Staff] ([staffId], [businessUnitId], [staffCode], [firstName], [middleName], [lastName], [dob], [startDate], [profile], [emailAddress], [Active]) VALUES (5, 5, N'5436', N'Michael', N'Aaron', N'Thompson', CAST(N'1995-01-12' AS Date), CAST(N'2004-09-08' AS Date), N'tall, with brown culy hair and facial hair', N'm.a.thompson@gmail.com', 0)
INSERT [dbo].[Staff] ([staffId], [businessUnitId], [staffCode], [firstName], [middleName], [lastName], [dob], [startDate], [profile], [emailAddress], [Active]) VALUES (7, 5, N'3010', N'Jack', N'Joseph', N'Wilkinson', CAST(N'1994-10-30' AS Date), CAST(N'2001-03-19' AS Date), N'average height, with dashingly good looks and brown hair with green eyes', N'j.j.wilkinson@gmail.com', 1)
INSERT [dbo].[Staff] ([staffId], [businessUnitId], [staffCode], [firstName], [middleName], [lastName], [dob], [startDate], [profile], [emailAddress], [Active]) VALUES (8, 7, N'9823', N'Liam', N'James', N'Pemberton', CAST(N'1996-04-05' AS Date), CAST(N'2005-06-09' AS Date), N'tall, with long dark brown hair and facial hair', N'l.j.pemberton@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Staff] OFF
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_BusinessUnit] FOREIGN KEY([businessUnitId])
REFERENCES [dbo].[BusinessUnit] ([businessUnitId])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_BusinessUnit]
GO
