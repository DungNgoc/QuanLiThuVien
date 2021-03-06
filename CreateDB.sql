

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO

USE [QLTV]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [nvarchar](8) NOT NULL,
	[hovaten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [int] NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylap] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(1,N'X')
GO
INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(2,N'Y')
GO


USE [QLTV]
GO


INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap]) VALUES(N'0000001',N'Phan Minh Toàn',2,convert(datetime,'10/02/1998 00:00:00'),N'Bắc Bình, Bình Thuận',N'16521261@gm.uit.edu.vn',convert(datetime,'11/05/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap]) VALUES(N'0000002',N'Nguyen Ngoc Dung',2,convert(datetime,'12/26/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'11/05/2018 00:00:00',101))
GO
USE [QLTV]
GO

