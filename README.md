# RuiMoraes.Teste.EstoqueAPI

Projeto desenvolvido sob o Visual Studio 2022 Community Edition.
# Tecnologias usadas:
* .NET 7
* C#11
* EF (CORE) 7
* SQL Server (localdb)

# Para instalar o banco de dados.
Pode usar o nugter package console e executar o comando "update-database"

Ou instalar via script abaixo:
# Script
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

CREATE TABLE [Categorias] (
    [Id] int NOT NULL,
    [Nome] nvarchar(30) NOT NULL,
    [Descricao] nvarchar(100) NOT NULL,
    [DataCriacao] datetime2 NULL,
    [Situacao] int NOT NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL,
    [Nome] nvarchar(100) NOT NULL,
    [Descricao] nvarchar(200) NOT NULL,
    [Preco] decimal(10,2) NOT NULL,
    [Quantidade] int NOT NULL,
    [CategoriaId] int NOT NULL,
    [DataCriacao] datetime2 NULL,
    [Situacao] int NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Produtos_Categorias_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categorias] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Produtos_CategoriaId] ON [Produtos] ([CategoriaId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221222040217_Initial', N'7.0.1');
GO

COMMIT;
GO
--------------------

