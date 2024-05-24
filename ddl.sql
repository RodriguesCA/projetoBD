CREATE DATABASE MiniMercado
GO

CHECKPOINT

USE MiniMercado
GO

CREATE TABLE Seccao(
    N_Corredor    INTEGER        NOT NULL                CHECK(N_Corredor > 0),
    Tipo          VARCHAR(50)    NOT NULL,

    PRIMARY KEY( Tipo ) 
);

CREATE TABLE Cliente(
    Nome          VARCHAR(30),
    NIF           INTEGER        NOT NULL,

    PRIMARY KEY ( NIF )
);

CREATE TABLE Produto(
    Nome          VARCHAR(30)    NOT NULL,
    Codigo        INTEGER        NOT NULL                CHECK(Codigo > 0),
    Tipo_Seccao   VARCHAR(50),
    Preco         DECIMAL(10, 2),
    IVA           INTEGER        NOT NULL,
    Unidades      INTEGER        CHECK(Unidades > 0),

    PRIMARY KEY ( Codigo ),
    FOREIGN KEY ( Tipo_Seccao ) REFERENCES Seccao ( Tipo )
);

CREATE TABLE Empregado(
    Nome          VARCHAR(30)    NOT NULL,
    NIF           INTEGER        NOT NULL,
    N_Empregado   INTEGER        NOT NULL,
    N_Horas       INTEGER,
    Salario       INTEGER        CHECK(Salario > 550),

    PRIMARY KEY ( N_Empregado )
);

CREATE TABLE Compra(
    c_Data        DATE           NOT NULL,
    N_Compra      INTEGER        NOT NULL     CHECK(N_Compra > 0),
    N_Empregado   INTEGER        NOT NULL,
    NIF_Cliente   INTEGER        NOT NULL,

    PRIMARY KEY(N_Compra),
    FOREIGN KEY(NIF_Cliente) REFERENCES Cliente(NIF),
    FOREIGN KEY(N_Empregado) REFERENCES Empregado(N_Empregado)
);

CREATE TABLE Compra_Produto(
    N_Compra      INTEGER        NOT NULL,
    C_Produto     INTEGER        NOT NULL,
    Quantidade    INTEGER        NOT NULL CHECK(Quantidade > 0),

    PRIMARY KEY (N_Compra, C_Produto),
    FOREIGN KEY (N_Compra) REFERENCES Compra (N_Compra),
    FOREIGN KEY (C_Produto) REFERENCES Produto (Codigo)
);

CREATE TABLE Caixista(
    N_Caixa       INTEGER        NOT NULL,
    N_Caixista    INTEGER        NOT NULL,

    FOREIGN KEY(N_Caixista) REFERENCES Empregado(N_Empregado)
);

CREATE TABLE Lojista(
    T_Seccao      VARCHAR(50)    NOT NULL,
    N_Lojista     INTEGER        NOT NULL,

    FOREIGN KEY(N_Lojista) REFERENCES Empregado(N_Empregado),
    FOREIGN KEY(T_Seccao)  REFERENCES Seccao(Tipo)
);

CREATE TABLE Armazem(
    C_Produto     INTEGER        NOT NULL    CHECK(C_Produto > 0),
    T_Seccao      VARCHAR(50)    NOT NULL,
    Unidades      INTEGER,

    FOREIGN KEY(C_Produto) REFERENCES Produto(Codigo),
    FOREIGN KEY(T_Seccao)  REFERENCES Seccao(Tipo)
);
