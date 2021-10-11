CREATE TABLE [dbo].[Table]
(
	[Username] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NULL, 
    [Loai] BIT NULL, 
    [MaGiangVien] INT NULL, 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([MaGiangVien]) REFERENCES [GiangVien]([MaGiangVien])
)
