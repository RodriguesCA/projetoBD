/* ------ Cria��o de sec��es ------  done */

INSERT INTO Seccao VALUES ('1', 'Comida Pr�-feita')
INSERT INTO Seccao VALUES ('2', 'Congelados')
INSERT INTO Seccao VALUES ('3', 'Fruta')
INSERT INTO Seccao VALUES ('4', 'Vegetais')
INSERT INTO Seccao VALUES ('5', 'Carne')
INSERT INTO Seccao VALUES ('6', 'Enlatados')
INSERT INTO Seccao VALUES ('7', 'Doces')
INSERT INTO Seccao VALUES ('8', 'Bebidas')
INSERT INTO Seccao VALUES ('9', 'Gr�os e Cereais')
INSERT INTO Seccao VALUES ('10','Higiene e outros')
INSERT INTO Seccao VALUES ('11','Condimentos') 

/* ------ Cria��o de Empregados ------- */

INSERT INTO Empregado VALUES ( 'Joao', '904344551', '1', '40', '750')
INSERT INTO Empregado VALUES ( 'Andr�', '362736707', '2', '40', '750')
INSERT INTO Empregado VALUES ( 'Barbara', '109162074', '3', '40', '750')
INSERT INTO Empregado VALUES ( 'Catia', '133069968', '4', '40', '750')
INSERT INTO Empregado VALUES ( 'Draymond', '495794145', '5', '40', '750')
INSERT INTO Empregado VALUES ( '�rica', '96028753', '6', '40', '750')

/* Criação de Caixistas */

INSERT INTO Caixista VALUES ('1', '1')
INSERT INTO Caixista VALUES ('2', '2')
INSERT INTO Caixista VALUES ('3', '3')

/* Criação de Lojistas */

INSERT INTO Lojista VALUES ('Bebidas', '4')
INSERT INTO Lojista VALUES ('Carne', '5')
INSERT INTO Lojista VALUES ('Condimentos', '6')

/* ------ Cria��o de Produtos ------- */

/* Sec��o  9  done */

INSERT INTO Produto	VALUES ( 'Tagliatelle', '7875', 'Gr�os e Cereais', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Spaghetti', '2496', 'Gr�os e Cereais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Arroz Agulha', '8736', 'Gr�os e Cereais', '1,49', '13','20')
INSERT INTO Produto	VALUES ( 'Arroz Carolino', '3319', 'Gr�os e Cereais', '1,49', '13','20')
INSERT INTO Produto	VALUES ( 'Ovos - D�zia', '7319', 'Gr�os e Cereais', '2,29', '13','20')
INSERT INTO Produto	VALUES ( 'Ovos - Meia D�zia', '1066', 'Gr�os e Cereais', '1,20', '13','20')
INSERT INTO Produto	VALUES ( 'Chocapic', '8044', 'Gr�os e Cereais', '3,29', '13','20')
INSERT INTO Produto	VALUES ( 'Estrelitas', '6186', 'Gr�os e Cereais', '2,99', '13','20')

/* Sec��o  7 done */

INSERT INTO Produto	VALUES ( 'Chocolate Milka', '6841', 'Doces', '3,99', '13','20')
INSERT INTO Produto	VALUES ( 'Kinder Barritas', '1722', 'Doces', '2,99', '13','20')
INSERT INTO Produto	VALUES ( 'Filipinos',		'1065', 'Doces', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Ferrero Roch�',	'3874', 'Doces', '2,99', '13','20')
INSERT INTO Produto	VALUES ( 'Raffaello',		'1329', 'Doces', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Oreo',			'2154', 'Doces', '2,99', '13','20')
INSERT INTO Produto	VALUES ( 'Bolacha Maria',	'8075', 'Doces', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Crackers',		'1067', 'Doces', '0,99', '13','20')

/* Sec��o  8 done */

INSERT INTO Produto	VALUES ( '�gua 6L'		,	'5522', 'Bebidas', '2,99', '13','20')
INSERT INTO Produto	VALUES ( '�gua 1,5L'	,	'2058', 'Bebidas', '0,99', '13','20')
INSERT INTO Produto	VALUES ( '�gua 0,5L'	,	'9378', 'Bebidas', '0,49', '13','20')
INSERT INTO Produto	VALUES ( 'Superbock x30',   '3580', 'Bebidas', '31,99', '13','20')
INSERT INTO Produto	VALUES ( 'Fanta 1,5L'	,	'7464', 'Bebidas', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Leite 1L'		,	'9828', 'Bebidas', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Coca-Cola 1,5L',  '5948', 'Bebidas', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Iced Tea 1,5L',   '1768', 'Bebidas', '1,99', '13','20')

/* Sec��o  6  done */

INSERT INTO Produto	VALUES ( 'Salsichas'		, '1639', 'Enlatados', '2,49', '13','20')
INSERT INTO Produto	VALUES ( 'Atum'				, '0339', 'Enlatados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Cogumelos'		, '6986', 'Enlatados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pat�'				, '9379', 'Enlatados', '3,99', '13','20')
INSERT INTO Produto	VALUES ( 'Azeitonas'		, '4216', 'Enlatados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Polpa de Tomate'	, '2111', 'Enlatados', '2,49', '13','20')
INSERT INTO Produto	VALUES ( 'Milho'			, '1267', 'Enlatados', '1,49', '13','20')
INSERT INTO Produto	VALUES ( 'Sardinha'			, '6035', 'Enlatados', '4,99', '13','20')

/* Sec��o  5  done */

INSERT INTO Produto	VALUES ( 'Porco -- Costeletas do Cacha�o'	, '3068', 'Carne', '7,99', '13','20')
INSERT INTO Produto	VALUES ( 'Porco -- Entremeada'				, '7656', 'Carne', '5,99', '13','20')
INSERT INTO Produto	VALUES ( 'Porco -- Bifes'					, '4576', 'Carne', '4,99', '13','20')
INSERT INTO Produto	VALUES ( 'Vaca -- Bife da Vazia'			, '1587', 'Carne', '9,99', '13','20')
INSERT INTO Produto	VALUES ( 'Vaca -- Picanha'					, '9487', 'Carne', '7,99', '13','20')
INSERT INTO Produto	VALUES ( 'Vaca -- Rosbife'					, '0432', 'Carne', '11,99', '13','20')
INSERT INTO Produto	VALUES ( 'Frango -- Lombinhos'				, '5456', 'Carne', '6,99', '13','20')
INSERT INTO Produto	VALUES ( 'Frango -- Coxas'					, '9334', 'Carne', '5,99', '13','20')

/* Sec��o  4 done (pre�os) */

INSERT INTO Produto	VALUES ( 'Alface'		, '0533', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Tomate'		, '3550', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Cenoura'		, '3984', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Cebola'		, '2142', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Alho'			, '1354', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Alho Franc�s'	, '2928', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pimento'		, '8476', 'Vegetais', '0,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pepino'		, '3791', 'Vegetais', '0,99', '13','20')

/* Sec��o  3  done (pre�os) */

INSERT INTO Produto	VALUES ( 'Ma��'		, '2260', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Banana'	, '3953', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Morangos'	, '7009', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'P�ssego'	, '3655', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Manga'	, '1617', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Mel�o'	, '2685', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Melancia'	, '7919', 'Fruta', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Uvas'		, '4160', 'Fruta', '1,99', '13','20')

/* Sec��o 2  done (pre�os) */

INSERT INTO Produto	VALUES ( 'Salm�o'			, '2061', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Gelado de Menta'	, '0555', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pizza Carbonara'	, '7471', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pescada'			, '9792', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Mix de Vegetais'	, '5627', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Batatas Palito'	, '9036', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Gelado Chocolate'	, '6779', 'Congelados', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pizza 4 Queijos'	, '6761', 'Congelados', '1,99', '13','20')

/* Sec��o  1  done (pre�os) */

INSERT INTO Produto	VALUES ( 'Massa bolonhesa'		, '1512', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Frango de Churrasco'	, '3673', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pizza Bolonhesa'		, '2431', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Lasanha'				, '5677', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Salada de Frango'		, '8699', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Sopa de Legumes'		, '7415', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Bacalhau com natas'	, '2234', 'Comida Pr�-feita', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Grelhada Mista'		, '4108', 'Comida Pr�-feita', '1,99', '13','20')

/* Sec��o  10 done (pre�os) */

INSERT INTO Produto	VALUES ( 'Desodorizantes'	, '2783', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Escova de Dentes'	, '9890', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Papel Higi�nico'	, '6661', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Vassoura'			, '3815', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Condicionador'	, '9830', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pasta de dentes'	, '7120', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Fio Dent�rio'		, '5289', 'Higiene e outros', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Shamp�'			, '6135', 'Higiene e outros', '1,99', '13','20')

/* Sec��o  11 done (pre�os) */

INSERT INTO Produto	VALUES ( 'Sal Fino'			, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Sal Grosso'		, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Pimenta Preta'	, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Paprica'			, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Alho em P�'		, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Louro'			, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Piment�o Doce'	, '7875', 'Condimentos', '1,99', '13','20')
INSERT INTO Produto	VALUES ( 'Piri-Piri'		, '7875', 'Condimentos', '1,99', '13','20')


/* -------- Cria��o de Clientes ----------*/

INSERT INTO Cliente VALUES ( 'Ant�nio'	, '367 876 970')
INSERT INTO Cliente VALUES ( 'Maria'	, '565 173 331')
INSERT INTO Cliente VALUES ( 'Olga'		, '847 272 010')
INSERT INTO Cliente VALUES ( 'F�lix'	, '013 636 521')


/* -------- Cria��o de Caixas ----------*/

INSERT INTO Caixa VALUES ( '1', ,'0')
INSERT INTO Caixa VALUES ( '2', ,'0')
INSERT INTO Caixa VALUES ( '3', ,'0')
INSERT INTO Caixa VALUES ( '4', ,'0')
INSERT INTO Caixa VALUES ( '5', ,'0')
INSERT INTO Caixa VALUES ( '6', ,'0')
INSERT INTO Caixa VALUES ( '7', ,'0')
INSERT INTO Caixa VALUES ( '8', ,'0')