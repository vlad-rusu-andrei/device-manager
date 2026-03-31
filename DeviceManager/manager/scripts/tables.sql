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

CREATE TABLE [Devices] (
    [Id] bigint NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Manufacturer] nvarchar(max) NOT NULL,
    [Type] int NOT NULL,
    [Processor] nvarchar(max) NOT NULL,
    [Os] nvarchar(max) NOT NULL,
    [Ram] int NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Devices] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] bigint NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Role] bit NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260331081739_InitialCreate', N'8.0.0');
GO

COMMIT;
GO

