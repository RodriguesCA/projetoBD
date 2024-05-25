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
						@T_Seccao		INTEGER
AS
	BEGIN
		INSERT INTO Empregado VALUES (@Nome, @NIF, @N_Lojista, @N_Horas, @Salario);
		INSERT INTO Caixista VALUES (@T_Seccao, @N_Lojista);	
	END

/* REMOVER CAIXISTA - ATUALIZAR EMPREGADOS */
GO
CREATE PROC removeCaixista @N_Caixista INTEGER
AS 
	BEGIN
		DELETE FROM Caixista WHERE N_Caixista=@N_Caixista;
		DELETE FROM Empregado WHERE N_Empregado=@N_Caixista;
	END

/* REMOVER LOJISTA - ATUALIZAR EMPREGADOS */
GO 
CREATE PROC removeLojista @N_Lojista	INTEGER 
AS 
	BEGIN
		DELETE FROM Lojista WHERE N_Lojista=@N_Lojista;
		DELETE FROM Empregado WHERE N_Empregado=@N_Lojista;
	END

/* REPOR PRODUTO - ADICIONAR PRODUTO, REMOVER ARMAZ�M */
GO 
CREATE PROC reporProduto @codigoProduto		INTEGER,
						 @tipoSeccao		VARCHAR(50)
AS 
	BEGIN 
		BEGIN TRAN;

		BEGIN TRY
			DECLARE @quantidadeArmazem INTEGER;
			SELECT @quantidadeArmazem=Unidades FROM Armazem WHERE C_Produto=@codigoProduto;

			IF @quantidadeArmazem IS NULL
			BEGIN
				RAISERROR('Produto nao encontrado no armazem.', 16, 1);
				ROLLBACK TRAN;
			END

			UPDATE Produto SET Unidades=Unidades+@quantidadeArmazem;

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
		IF EXISTS (SELECT 1 FROM Produto WHERE Codigo=@codigoProduto)
		BEGIN
			INSERT INTO Armazem (C_Produto, T_Seccao, Unidades) VALUES (@codigoProduto, @tipoSeccao, @quantidade);
		END
		ELSE
		BEGIN
			RAISERROR('Produto nao existe na base de dados.', 16, 1);
		END
	END

/* ADICIONAR CLIENTES + ADICIONAR UMA COMPRA */
GO
CREATE PROC addCliente @nomeCliente VARCHAR(30),
					   @nifCliente	INTEGER
AS
	BEGIN
		INSERT INTO Cliente (Nome, NIF) VALUES (@nomeCliente, @nifCliente);
	END

/* ADICIONAR PRODUTOS A COMPRA - ATUALIAZR PRODUTOS, ADICIONAR COMPRA_PRODUTO */
GO
CREATE PROC addProdCompra @codigoProduto INTEGER,
						  @quantidade	 INTEGER,
						  @nifCliente	 INTEGER
AS
	BEGIN
		IF EXISTS (SELECT 1 FROM CLIENTE WHERE NIF=@nifCliente)
		BEGIN	
			INSERT Compra_Produto (N_Compra, C_Produto, Quantidade) VALUES (RAND(), );
		END
		ELSE
		BEGIN
			RAISERROR('Cliente não existe.', 16, 1);
		END
	END
/* TRIGGER */
/* UM EMPREGADO N�O PODE SER CAIXISTA E LOJISTA */
/* UM PRODUTO N�O PODE TER O MESMO C�DIGO */
/* UM PRODUTO N�O PODE PERTENCER A MAIS QUE UMA SECC�AO */
/* QUANDO UM CLIENTE FINALIZA UMA COMPRA, SAI DA LOJA (REMOVER) */
/* SE UM PRODUTO N�O EXISTIR NO ARMAZ�M, N�O FAZER O RESTOCK */
/* SE PRODUTO J� EXISTE NO ARMAZEM, IMPEDIR A ENCOMENDA DE MAIS PRODUTOS */
/* SE UM PRODUTO TIVER 0 UNIDADES, N�O O PODE ADICIONAR � COMPRA */