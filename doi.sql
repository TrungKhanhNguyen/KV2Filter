
CREATE TABLE [dbo].[Doi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hohieu] [nvarchar](50) NULL,
	[Huongdo] [nvarchar](50) NULL,
	[Mangdai] [nvarchar](50) NULL,
	[Giong] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](max) NULL,
	[Diaban] [nvarchar](50) NULL,
	[PhienId] [int] NULL,
 CONSTRAINT [PK_Doi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]




