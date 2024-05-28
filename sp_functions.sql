/* SP FUNCTIONS */
USE MiniMercado
GO

/* ADICIONAR CAIXISTA - ADICIONAR EMPREGADOS */
GO
CREATE PROC addCaixista @Nome			VARCHAR(30),
						@NIF			INTEGER,
						@N_Caixista		INTEGER,
						@N_Horas		INTEGER,
						@Salario		INTEGER,
						@N_Caixa		INTEGER
AS 
BEGIN
	INSERT INTO Empregado VALUES (@Nome, @NIF, @N_Caixista, @N_Horas, @Salario);
	INSERT INTO Caixista VALUES (@N_Caixa, @N_Caixista);
END

/* ADICIONAR LOJISTA - ADICIONAR EMPREGADOS */
GO
CREATE PROC addLojista	@Nome			VARCHAR(30),
						@NIF			INTEGER,
						@N_Lojista		INTEGER,
						@N_Horas		INTEGER,
						@Salario		INTEGER,
						@T_Seccao		VARCHAR(50)
AS
BEGIN
	INSERT INTO Empregado VALUES (@Nome, @NIF, @N_Lojista, @N_Horas, @Salario);
	INSERT INTO Lojista VALUES (@T_Seccao, @N_Lojista);	
END

/* REMOVER EMPREGADO - ATUALIZAR EMPREGADOS */
GO
CREATE PROC removeEmpregado @N_Empregado INTEGER
AS 
BEGIN
	IF EXISTS (SELECT 1 FROM Caixista WHERE N_Caixista=@N_Empregado)
	BEGIN
		DELETE FROM Caixista WHERE N_Caixista=@N_Empregado;
		DELETE FROM Empregado WHERE N_Empregado=@N_Empregado;
	END
	IF EXISTS (SELECT 1 FROM Lojista WHERE N_Lojista=@N_Empregado)
	BEGIN
		DELETE FROM Lojista WHERE N_Lojista=@N_Empregado;
		DELETE FROM Empregado WHERE N_Empregado=@N_Empregado;
	END
END

/* REPOR PRODUTO - ADICIONAR PRODUTO, REMOVER ARMAZ�M */
GO 
CREATE PROC reporProduto @codigoProduto		INTEGER
AS 
BEGIN 
	BEGIN TRAN;

	BEGIN TRY
		DECLARE @quantidadeArmazem INTEGER;
		SELECT @quantidadeArmazem=Unidades FROM Armazem WHERE C_Produto=@codigoProduto;

		UPDATE Produto SET Unidades=Unidades+@quantidadeArmazem WHERE Codigo=@codigoProduto;

		DELETE FROM Armazem WHERE C_Produto=@codigoProduto;

		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;
	END CATCH
END

/* ALTERAR PRE�OS - ATUALIZAR PRODUTOS (???) */
/* ENCOMENDAR PRODUTOS - ADICIONAR AO ARMAZEM */
GO
CREATE PROC encomendarProduto @codigoProduto INTEGER,
							  @tipoSeccao	 VARCHAR(50),
							  @quantidade	 INTEGER
AS
BEGIN
	INSERT INTO Armazem (C_Produto, T_Seccao, Unidades) VALUES (@codigoProduto, @tipoSeccao, @quantidade);
	COMMIT TRAN;
END

/* ADICIONAR CLIENTES + ADICIONAR UMA COMPRA */
GO
CREATE PROC addCliente @nomeCliente VARCHAR(30),
					   @nifCliente	INTEGER
AS
BEGIN
	DECLARE @numeroCompra 	INTEGER
	DECLARE @numeroCaixista INTEGER

	INSERT INTO Cliente (Nome, NIF) VALUES (@nomeCliente, @nifCliente);
		
/*	SELECT TOP 1 @numeroCaixista=N_Caixista FROM Caixista ORDER BY NEWID();

	SET @numeroCompra = (SELECT ISNULL(MAX(N_Compra), 0) + 1 FROM Compra);

	INSERT INTO Compra (c_Data, N_Compra, N_Empregado, NIF_Cliente) VALUES (GETDATE(), @numeroCompra, @numeroCaixista, @nifCliente);*/
END

/* ADICIONAR PRODUTOS A COMPRA - ATUALIAZR PRODUTOS, ADICIONAR COMPRA_PRODUTO */
GO
CREATE PROC addProdCompra @codigoProduto INTEGER,
						  @quantidade	 INTEGER,
						  @nifCliente	 INTEGER
AS
BEGIN
	BEGIN TRAN;
		
	DECLARE @numeroCompra 		 INTEGER
	DECLARE @unidadesDisponiveis INTEGER


	IF EXISTS (SELECT 1 FROM Cliente WHERE NIF=@nifCliente)
	BEGIN
		SELECT @numeroCompra=N_Compra FROM Compra WHERE NIF_Cliente=@nifCliente;
		SELECT @unidadesDisponiveis=Unidades FROM Produto WHERE Codigo=@codigoProduto;

		IF @unidadesDisponiveis >= @quantidade
		BEGIN
			INSERT Compra_Produto (N_Compra, C_Produto, Quantidade) VALUES (@numeroCompra, @codigoProduto, @quantidade);

			UPDATE Produto SET Unidades=Unidades-@quantidade WHERE Codigo=@codigoProduto;
		END
		ELSE
		BEGIN
			INSERT Compra_Produto (N_Compra, C_Produto, Quantidade) VALUES (@numeroCompra, @codigoProduto, @unidadesDisponiveis);

			UPDATE Produto SET Unidades=Unidades-@unidadesDisponiveis WHERE Codigo=@codigoProduto;
		END
		COMMIT TRAN;
	END
	ELSE
	BEGIN
		RAISERROR('Cliente não existe.', 16, 1);
		ROLLBACK TRAN;
	END
END
