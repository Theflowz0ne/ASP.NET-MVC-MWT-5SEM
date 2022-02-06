CREATE TABLE [dbo].[User] (
    [Id]       INT           NOT NULL,
    [Username] VARCHAR (50)  NOT NULL,
    [Password] VARCHAR (255) NOT NULL,
    [Role]     VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);