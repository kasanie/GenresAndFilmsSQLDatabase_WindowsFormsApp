CREATE TABLE [dbo].[Film] (
	[Id] INT NOT NULL PRIMARY KEY,
    [genreKey]  INT   NOT NULL,
    [genreName] NTEXT NOT NULL,
    [filmName]  NTEXT NOT NULL,
    [totalDisk] INT   NOT NULL,
    [takeDisk]  INT   NOT NULL,
    [leftDisk]  INT   NOT NULL
);

