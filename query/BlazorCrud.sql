USE [BlazorCrud]
GO
/****** Object:  Table [dbo].[Heroe]    Script Date: 10/11/2021 23:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Heroe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[poder] [varchar](30) NULL,
	[universo] [varchar](15) NULL,
 CONSTRAINT [PK_Heroe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Heroe] ON 

INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (1, N'Batman', N'Inteligencia', N'DC')
INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (2, N'Ironman', N'Genio Tecnologico', N'Marvel')
INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (3, N'Superman', N'Superfuerza', N'DC')
INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (4, N'Capitan America', N'Poder', N'Marvel')
INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (5, N'Green Lintern', N'Anillo magico', N'DC')
INSERT [dbo].[Heroe] ([id], [nombre], [poder], [universo]) VALUES (6, N'Spiderman', N'Poder aracnido', N'Marvel')
SET IDENTITY_INSERT [dbo].[Heroe] OFF
GO
