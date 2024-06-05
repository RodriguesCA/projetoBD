USE MiniMercado
GO

CREATE VIEW EmployeeRole AS
SELECT 
    e.Nome,
    e.NIF,
    e.N_Empregado,
    CASE 
        WHEN c.N_Caixista IS NOT NULL THEN 'Caixista'
        WHEN l.N_Lojista IS NOT NULL THEN 'Lojista'
        ELSE 'Unknown'
    END AS Role
FROM 
    Empregado e
LEFT JOIN 
    Caixista c ON e.N_Empregado = c.N_Caixista
LEFT JOIN 
    Lojista l ON e.N_Empregado = l.N_Lojista;