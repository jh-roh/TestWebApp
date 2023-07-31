CREATE TABLE [dbo].[Garnishs] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (25) NOT NULL,
    [NoodleId] INT           NOT NULL,
    CONSTRAINT [PK_Garnishs] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Garnishs_Noodles_NoodleId] FOREIGN KEY ([NoodleId]) REFERENCES [dbo].[Noodles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Garnishs_NoodleId]
    ON [dbo].[Garnishs]([NoodleId] ASC);

