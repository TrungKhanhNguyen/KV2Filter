CREATE TABLE [dbo].[Chinh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[Tanso] [decimal](18, 0) NULL,
	[PTLienlac] [nvarchar](50) NULL,
	[Hohieu] [nvarchar](50) NULL,
	[Noidung] [nvarchar](max) NULL,
	[Huongdo] [decimal](18, 0) NULL,
	[Mangdai] [nvarchar](50) NULL,
	[Giong] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](max) NULL,
	[Diaban] [nvarchar](50) NULL,
	[HohieuDecimal] [decimal](18, 0) NULL,
	[PhienId] [int] NULL,
 CONSTRAINT [PK_Chinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]