CREATE TABLE [dbo].[Students] (
    [studentID]   INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (MAX) NOT NULL,
    [hinhphat]    NVARCHAR(50)            NOT NULL,
    [soluong]     INT            NOT NULL,
    [ngaynopphat] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([studentID] ASC)
);

