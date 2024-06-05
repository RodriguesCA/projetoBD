USE MiniMercado
GO

CREATE FUNCTION dbo.GetStoreInventoryValueBySection (@SectionType VARCHAR(50))
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @InventoryValue DECIMAL(18, 2);
    
    SELECT @InventoryValue = SUM(p.Preco * p.Quantidade)
    FROM Produto p
    INNER JOIN Seccao s ON p.Secao_Tipo = s.Tipo
    WHERE s.Tipo = @SectionType;
    
    RETURN ISNULL(@InventoryValue, 0);
END;
