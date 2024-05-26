/* TRIGGER */
USE MiniMercado
GO

/* UM EMPREGADO NAO PODE SER CAIXISTA E LOJISTA */
CREATE TRIGGER ValidarCaixista ON Caixista
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM inserted i JOIN Lojista l ON i.N_Caixista=l.N_Lojista)
    BEGIN
        RAISERROR('Um Empregado não pode ser Lojista e Caixista.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO

CREATE TRIGGER ValidarLojista ON Lojista
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM inserted i JOIN Caixista c ON i.N_Lojista=c.N_Caixista)
    BEGIN
        RAISERROR('Um Empregado não pode ser Lojista e Caixista.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO

/* UM PRODUTO NAO PODE PERTENCER A MAIS QUE UMA SECCAO */
CREATE TRIGGER ValidarSeccao ON Produto
AFTER INSERT, UPDATE
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM Produto p1 JOIN inserted i ON p1.Codigo=i.Codigo WHERE p1.Tipo_Seccao <> i.Tipo_Seccao)
    BEGIN
        RAISERROR('Um Produto não pode pertencer a mais que uma secção.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO

/* SE UM PRODUTO NAO EXISTIR NO ARMAZAM, NAO FAZER O RESTOCK */
CREATE TRIGGER ValidarRestock ON Produto
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM inserted i LEFT JOIN Armazem a ON i.Codigo=a.C_Produto WHERE i.Unidades <> (SELECT Unidades FROM Produto p WHERE p.Codigo=i.Codigo) AND a.C_Produto is NULL)
    BEGIN 
        RAISERROR('Um Produto não exite no armazém.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO 

/* SE PRODUTO JA EXISTE NO ARMAZEM, IMPEDIR A ENCOMENDA DE MAIS PRODUTOS */
CREATE TRIGGER ValidarEncomenda ON Armazem
INSTEAD OF INSERT 
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM inserted i JOIN Armazem a ON i.C_Produto=a.C_Produto)
    BEGIN
        RAISERROR('O produto já existe no armazém.', 16, 1);
        ROLLBACK TRAN;
    END
    ELSE
    BEGIN
        INSERT INTO Armazem (C_Produto, T_Seccao, Unidades) SELECT C_Produto, T_Seccao, Unidades FROM inserted;
    END
END
GO

/* SE UM PRODUTO TIVER 0 UNIDADES, NAO O PODE ADICIONAR A COMPRA */
CREATE TRIGGER ValidarUnidadesProd ON Compra_Produto
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM inserted i JOIN Produto p ON i.C_Produto=p.Codigo WHERE Unidades=0)
    BEGIN
        RAISERROR('O produto tem 0 unidades. Não pode adicionado à compra.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO