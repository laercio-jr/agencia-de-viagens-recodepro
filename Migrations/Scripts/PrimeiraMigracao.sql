IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Viagens] (
    [Id] int NOT NULL IDENTITY,
    [Viajante] nvarchar(40) NOT NULL,
    [Destino] nvarchar(40) NOT NULL,
    [TemGuia] bit NOT NULL,
    CONSTRAINT [PK_Viagens] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211219030446_PrimeiraMigracao', N'5.0.13');
GO

COMMIT;
GO

