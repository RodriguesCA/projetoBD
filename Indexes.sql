USE MiniMercado
GO

CREATE INDEX idx_empregado_nome ON Empregado(Nome);
CREATE INDEX idx_caixista_empregado ON Caixista(N_Caixista);
CREATE INDEX idx_lojista_empregado ON Lojista(N_Lojista);