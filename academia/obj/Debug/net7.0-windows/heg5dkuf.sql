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

CREATE TABLE [Alunos] (
    [Id] nvarchar(450) NOT NULL,
    [name] nvarchar(max) NOT NULL,
    [cpf] nvarchar(max) NOT NULL,
    [phone] nvarchar(max) NULL,
    [matricula] int NOT NULL,
    CONSTRAINT [PK_Alunos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Professores] (
    [id] int NOT NULL IDENTITY,
    [nome] nvarchar(max) NULL,
    [cpf] nvarchar(max) NULL,
    [phone] nvarchar(max) NULL,
    CONSTRAINT [PK_Professores] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Treinos] (
    [Id_treino] int NOT NULL IDENTITY,
    [Nome_Exercicio] nvarchar(max) NOT NULL,
    [Repeticoes] nvarchar(max) NOT NULL,
    [Equipamentos] nvarchar(max) NOT NULL,
    [Matricula_aluno] int NOT NULL,
    CONSTRAINT [PK_Treinos] PRIMARY KEY ([Id_treino])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230622195949_initial', N'7.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Professores]') AND [c].[name] = N'Id_Aluno');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Professores] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Professores] DROP COLUMN [Id_Aluno];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230623001144_test', N'7.0.7');
GO

COMMIT;
GO

