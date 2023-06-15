CREATE TABLE [dbo].[Users] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]             NVARCHAR (50) NULL,
    [LastName]              NVARCHAR (50) NULL,
    [Email]                 NVARCHAR (50) NULL,
    [PhoneNumber]           NVARCHAR (50) NULL,
    [PassportSeries]        NVARCHAR (50) NULL,
    [Departure_Destination] NVARCHAR (50) NULL,
    [Seats]                 NVARCHAR (50) NULL,
    [Time]                  DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);