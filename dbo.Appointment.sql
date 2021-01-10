CREATE TABLE [dbo].[Appointment] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Nume]     NVARCHAR (MAX) NULL,
    [Prenume]  NVARCHAR (MAX) NULL,
    [Serviciu] NVARCHAR (MAX) NULL,
    [Telefon]  INT            NOT NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([ID] ASC)
);

