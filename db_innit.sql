USE MiniMercado
GO

/* ------ Cria��o de sec��es ------ */

INSERT INTO Seccao VALUES ('1', 'Carne')
INSERT INTO Seccao VALUES ('2', 'Fruta e Vegetais')
INSERT INTO Seccao VALUES ('3', 'Bebidas')
INSERT INTO Seccao VALUES ('4', 'Graos e Cereais')


/* ------ Cria��o de Empregados ------- */

INSERT INTO Empregado VALUES ( 'Joao', '904344551', '1', '40', '750')
INSERT INTO Empregado VALUES ( 'Andre', '362736707', '2', '40', '750')
INSERT INTO Empregado VALUES ( 'Barbara', '109162074', '3', '40', '750')
INSERT INTO Empregado VALUES ( 'Catia', '133069968', '4', '40', '750')
INSERT INTO Empregado VALUES ( 'Draymond', '495794145', '5', '40', '750')
INSERT INTO Empregado VALUES ( 'Erica', '96028753', '6', '40', '750')

/* -------- Cria��o de Caixas ----------*/

INSERT INTO Caixa VALUES ( '1', '1','0')
INSERT INTO Caixa VALUES ( '2', '2','0')
INSERT INTO Caixa VALUES ( '3', '3','0')

/* Criação de Caixistas */

INSERT INTO Caixista VALUES ('1', '1')
INSERT INTO Caixista VALUES ('2', '2')
INSERT INTO Caixista VALUES ('3', '3')

/* Criação de Lojistas */

INSERT INTO Lojista VALUES ('Bebidas', '4')
INSERT INTO Lojista VALUES ('Carne', '5')
INSERT INTO Lojista VALUES ('Fruta e Vegetais', '6')

/* ------ Cria��o de Produtos ------- */

/* Sec��o  9  done */

INSERT INTO Produto	VALUES ( 'Tagliatelle', '7875', 'Graos e Cereais', '1.99', '13', 20)
INSERT INTO Produto	VALUES ( 'Spaghetti', '2496', 'Graos e Cereais', '0.99', '13', 20)
INSERT INTO Produto	VALUES ( 'Arroz Agulha', '8736', 'Graos e Cereais', '1.49', '13',20)
INSERT INTO Produto	VALUES ( 'Arroz Carolino', '3319', 'Graos e Cereais', '1.49', '13',20)
INSERT INTO Produto	VALUES ( 'Ovos - Duzia', '7319', 'Graos e Cereais', '2.29', '13',20)
INSERT INTO Produto	VALUES ( 'Ovos - Meia Duzia', '1066', 'Graos e Cereais', '1.20', '13',20)
INSERT INTO Produto	VALUES ( 'Chocapic', '8044', 'Graos e Cereais', '3.29', '13',20)
INSERT INTO Produto	VALUES ( 'Estrelitas', '6186', 'Graos e Cereais', '2.99', '13',20)



/* Sec��o  8 done */

INSERT INTO Produto	VALUES ( 'Agua 6L'		,	'5522', 'Bebidas', '2.99', '13',20)
INSERT INTO Produto	VALUES ( 'Agua 1,5L'	,	'2058', 'Bebidas', '0.99', '13',20)
INSERT INTO Produto	VALUES ( 'Agua 0,5L'	,	'9378', 'Bebidas', '0.49', '13',20)
INSERT INTO Produto	VALUES ( 'Superbock x30',   '3580', 'Bebidas', '31.99', '13',20)
INSERT INTO Produto	VALUES ( 'Fanta 1,5L'	,	'7464', 'Bebidas', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Leite 1L'		,	'9828', 'Bebidas', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Coca-Cola 1,5L',  '5948', 'Bebidas', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Iced Tea 1,5L',   '1768', 'Bebidas', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Iced Tea 0,5L',   '4852', 'Bebidas', '1.99', '13',0)


/* Sec��o  5  done */

INSERT INTO Produto	VALUES ( 'Porco -- Costeletas do Cachaco'	, '3068', 'Carne', '7.99', '13',20)
INSERT INTO Produto	VALUES ( 'Porco -- Entremeada'				, '7656', 'Carne', '5.99', '13',20)
INSERT INTO Produto	VALUES ( 'Porco -- Bifes'					, '4576', 'Carne', '4.99', '13',20)
INSERT INTO Produto	VALUES ( 'Vaca -- Bife da Vazia'			, '1587', 'Carne', '9.99', '13',20)
INSERT INTO Produto	VALUES ( 'Vaca -- Picanha'					, '9487', 'Carne', '7.99', '13',20)
INSERT INTO Produto	VALUES ( 'Vaca -- Rosbife'					, '0432', 'Carne', '11.99', '13',20)
INSERT INTO Produto	VALUES ( 'Frango -- Lombinhos'				, '5456', 'Carne', '6.99', '13',20)
INSERT INTO Produto	VALUES ( 'Frango -- Coxas'					, '9334', 'Carne', '5.99', '13',20)
INSERT INTO Produto	VALUES ( 'Frango -- Pernas'					, '8651', 'Carne', '5.99', '13',0)

/* Sec��o  4 done (pre�os) */

INSERT INTO Produto	VALUES ( 'Alface'		, '0533', 'Fruta e Vegetais', '0.99', '13',20)
INSERT INTO Produto	VALUES ( 'Tomate'		, '3550', 'Fruta e Vegetais', '0.99', '13',20)
INSERT INTO Produto	VALUES ( 'Cenoura'		, '3984', 'Fruta e Vegetais', '0.99', '13',20)
INSERT INTO Produto	VALUES ( 'Cebola'		, '2142', 'Fruta e Vegetais', '0.99', '13',20)
INSERT INTO Produto	VALUES ( 'Maça'			, '2260', 'Fruta e Vegetais', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Banana'		, '3953', 'Fruta e Vegetais', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Morangos'		, '7009', 'Fruta e Vegetais', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Pessego'		, '3655', 'Fruta e Vegetais', '1.99', '13',20)
INSERT INTO Produto	VALUES ( 'Curgete'		, '6472', 'Fruta e Vegetais', '1.99', '13',0)

/* -------- Cria��o de Clientes ----------*/

INSERT INTO Cliente VALUES ( 'Antonio'	, '367876970')
INSERT INTO Cliente VALUES ( 'Maria'	, '565173331')
INSERT INTO Cliente VALUES ( 'Olga'		, '847272010')
INSERT INTO Cliente VALUES ( 'Felix'	, '013636521')