CREATE TABLE [dbo].[regi] (
    [ID]     INT          IDENTITY (1, 1) NOT NULL,
    [urname] VARCHAR (40) NOT NULL,
    [email]  VARCHAR (50) NOT NULL,
    [passwd] VARCHAR (40) NOT NULL,
    [phonenum] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

