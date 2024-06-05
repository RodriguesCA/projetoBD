# BD: Trabalho Prático APF-T

**Grupo**: P7g2
- Afonso Rodrigues, MEC: 107715
- José Jordão, MEC: 103075


## Introdução / Introduction
 
No contexto da unidade curricular de Base de Dados, do curso de Licenciatura em Engenharia de Computadores e Informática, foi-nos proposto criar um projeto para gerir um sistema funcional com uma complexidade razoável e aplicável ao mundo real. De forma a  cumprir o objetivo proposto decidimos desenvolver um sistema de gestão de mini mercados, onde este relatório descreverá de forma sucinta o nosso sistema, destacando todo o processo de desenvolvimento do mesmo e as partes fundamentais para o seu funcionamento.
No material fornecido em anexo, o diretório /sql estão contidos os ficheiros script necessários para criar corretamente a base de dados, e em /source uma interface desenvolvida em C# e o código relativo à mesma.
Para nossa aplicação interagir com uma base de dados, é necessário alterar o atributo data source pertencente à função getSGBDConnection no ficheiro Welcome.cs de acordo com o server name da base de dados desejada.
Também segue em anexo, os slides e vídeos usados na apresentação do projeto em /presentation.

## ​Análise de Requisitos / Requirements

Considerando um sistema de gestão de um mini mercado, este sistema terá de oferecer:
- Adicionar ou despedir empregados ao mini mercado, estes empregados poderão ser lojistas ou caixistas (operadores de caixa). Todos os empregados têm que ter um número de empregado, nome, nif, número de horas de trabalho, salário e, caso seja caixista, o número da caixa. 
- Registar os produtos do mini mercado, estes produtos são identificados por unidades, IVA, nome, preço, código e o tipo de secção a que pertencem na loja. 
- Registar as compras no mini mercado, estas compras são identificados por data, número, códigos dos produtos comprados, nif do cliente e número do empregado que finalizou a compra. 
- Monitorizar clientes do mini mercado, estes registados pelo nome e nif.
- A possibilidade de um empregado se despedir.
- Simular um dia de trabalho, ou seja, calcular o número de vendas, calcular o número de horas trabalhadas e fazer o inventário.

## DER - Diagrama Entidade Relacionamento/Entity Relationship Diagram

### Versão final/Final version

[DER Diagram](anexos/der.png "AnImage")

### APFE 

Melhoramos a compras sendo esta capaz de saber quantos produtos foram comprados em cada compra, com a criação de uma nova entidade Compra_Produto.
Criação de uma entidade separada para as caixas.

## ER - Esquema Relacional/Relational Schema

### Versão final/Final Version

[ER Diagram](anexos/er.png "AnImage")

### APFE

Fizemos as alterações segundo as melhorias no DER

## ​SQL DDL - Data Definition Language

[SQL DDL File](SQL/ddl.sql "SQLFileQuestion")

## SQL DML - Data Manipulation Language


### Index - Empregados

[Screenshot_Empregados](screenshots/Index_Empregados.png "AnImage")

```sql
-- View para mostrar os caixistas, assim como os seus dados e a caixa associada a cada um
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



-- Store procedure para adicionar um caixista
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
	UPDATE Caixa SET N_Caixista = @N_Caixista WHERE N_Caixa = @N_Caixa;
	
END

```

private void button1_add_caixista_Click(object sender, EventArgs e)
{
    
    
    
    
    
    
    loadCaixistas();
    if (!verifySGBDConnection())
    {
        MessageBox.Show("Falha na conexão com o banco de dados.");
        return;
    }

    if (string.IsNullOrWhiteSpace(textBox_name_caixista.Text))
    {
        MessageBox.Show("Nome Inválido!");
        return;
    }

    if (textBox_nif_caixista.Text.Length != 9 || !int.TryParse(textBox_nif_caixista.Text, out int nif))
    {
        MessageBox.Show("NIF Inválido");
        return;
    }

    if (!int.TryParse(textBox_horas_caixista.Text, out int horas))
    {
        MessageBox.Show("Número de Horas Invalido");
    }

    if (!int.TryParse(textBox_num_caixista.Text, out int num))
    {
        MessageBox.Show("Número de Empregado Invalido");
    }

    if (!int.TryParse(textBox_sal_caixista.Text, out int sal))
    {
        MessageBox.Show("Salário Invalido");
    }

    if (sal <= 550)
    {
        MessageBox.Show("Salário Demasiado Pequeno");
    }

    if (comboBox_caixas.SelectedItem == null)
    {
        MessageBox.Show("Necessário Associar caixa");
    };

    string caixa = comboBox_caixas.SelectedItem.ToString();


    try
    {
        cn = getSGBDConnection();
        if (!verifySGBDConnection())
        {
            MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test");
            return;
        }

        using (SqlCommand cmd = new SqlCommand("addCaixista", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBox_name_caixista.Text;
            cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nif;
            cmd.Parameters.Add("@N_Caixista", SqlDbType.Int).Value = num;
            cmd.Parameters.Add("@N_Horas", SqlDbType.Int).Value = horas;
            cmd.Parameters.Add("@Salario", SqlDbType.Int).Value = sal;
            cmd.Parameters.Add("@N_Caixa", SqlDbType.Int).Value = caixa;


            int result = cmd.ExecuteNonQuery();

            MessageBox.Show("Caixista adicionado com sucesso!");

            loadEmpregados();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro ao adicionar Caixista: {ex.Message}");
    }
    finally
    {
        if (cn != null && cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
    }
}

```sql
-- Stored Procedure para Remover Empregadoss
CREATE PROC removeEmpregado @N_Empregado INTEGER
AS 
BEGIN
	IF EXISTS (SELECT 1 FROM Caixista WHERE N_Caixista=@N_Empregado)
	BEGIN
		UPDATE Caixa SET N_Caixista = NULL WHERE N_Caixista =@N_Empregado;
		DELETE FROM Caixista WHERE N_Caixista=@N_Empregado;
		DELETE FROM Empregado WHERE N_Empregado=@N_Empregado;
	END
	IF EXISTS (SELECT 1 FROM Lojista WHERE N_Lojista=@N_Empregado)
	BEGIN
		DELETE FROM Lojista WHERE N_Lojista=@N_Empregado;
		DELETE FROM Empregado WHERE N_Empregado=@N_Empregado;
	END
END


```


Para a adição e visualização de Lojstas, o método usado foi o mesmo, utilizando um store procedure para adição, e uma view para mostrar os lojistas assim como a secção a que estão associados.
Na remoção de empregados tivemos também, no caso de ser caixista, como podemos ver em cima, de limpar a tabela da caixa para cortar a associação entre o caixista e a caixa a que estava atribuido.

### Index - Clientes

[Screenshot_Clientes](screenshots/Index_Clientes.png "AnImage")

```sql
-- Ver clientes
SELECT * FROM Cliente

-- Stored Procedure para adicionar Clientes
CREATE PROC addCliente @nomeCliente VARCHAR(30),
					   @nifCliente	INTEGER
AS
BEGIN
	DECLARE @numeroCompra 	INTEGER
	DECLARE @numeroCaixista INTEGER

	INSERT INTO Cliente (Nome, NIF) VALUES (@nomeCliente, @nifCliente);
		

END
```

private void button_def_add_c_Click(object sender, EventArgs e)
{
    if (!verifySGBDConnection())
    {
        MessageBox.Show("Falha na conexão com o banco de dados.");
        return;
    }

    if (string.IsNullOrWhiteSpace(textBox_nome_c.Text))
    {
        MessageBox.Show("Nome Inválido!");
        return;
    }

    if (textBox_nif_c.Text.Length != 9 || !int.TryParse(textBox_nif_c.Text, out int nif))
    {
        MessageBox.Show("NIF Inválido");
        return;
    }

    try
    {
        cn = getSGBDConnection();
        if (!verifySGBDConnection())
        {
            MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test");
            return;
        }

        using (SqlCommand cmd = new SqlCommand("addCliente", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = textBox_nome_c.Text;
            cmd.Parameters.Add("@nifCliente", SqlDbType.Int).Value = nif;

            int result = cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente adicionado com sucesso!");

            loadClientes();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}");
    }
    finally
    {
        if (cn != null && cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
    }
}

Para o caso do cliente, acabámos por usar um simples select para, com a ajuda de uma uma datagrid, mostrar todos os clientes e o respetivo nif. Para adicionar um cliente utilizámos um stored procedure semelhante ao usado para os empregados.

### Index - Inventário

[Screenshot_Valor_Inventário](screenshots/Index_Inventário.png "AnImage")

```sql
-- udf para calcular o valor de cada secção
CREATE FUNCTION dbo.GetStoreInventoryValueBySection (@SectionType VARCHAR(50))
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @InventoryValue DECIMAL(18, 2);
    
    SELECT @InventoryValue = SUM(p.Preco * p.Unidades)
    FROM Produto p
    INNER JOIN Seccao s ON p.Tipo_Seccao = s.Tipo
    WHERE s.Tipo = @SectionType;
    
    RETURN ISNULL(@InventoryValue, 0);
END;

```

private void comboBox_secção_SelectedIndexChanged(object sender, EventArgs e)
{
    
    if (comboBox_secção.SelectedItem != null)
    {
        string selectedSection = comboBox_secção.SelectedItem.ToString();
        decimal inventoryValue = GetStoreInventoryValueBySection(selectedSection);
        
        textBox_valor_secção.Text = inventoryValue.ToString("C");
    }


}




private decimal GetStoreInventoryValueBySection(string sectionType)
{
    
    
    
    
    
    
    
    
    
    
    string connectionString = "data source= JORDAO-GRAM\\SQLEXPRESS; integrated security=true; initial catalog=MiniMercado";
    string query = "SELECT dbo.GetStoreInventoryValueBySection(@SectionType) AS InventoryValue";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@SectionType", sectionType);

        connection.Open();
        var result = command.ExecuteScalar();
        connection.Close();

        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
    }
}


Para mostrar o valor em produtos presente em cada secção utilizámos uma udf que calcula o preço do produto por número de unidades em stock.

### Inventário

[Screenshot_Inventário](screenshots/Inventário "AnImage")

```sql
-- Store Procedure para repor produtos que estejam em falta no stock de loja

CREATE PROC reporProduto @codigoProduto		INTEGER,
						 @tipoSeccao		VARCHAR(50)
AS 
BEGIN 
	BEGIN TRAN;

	BEGIN TRY
		DECLARE @quantidadeArmazem INTEGER;
		SELECT @quantidadeArmazem=Unidades FROM Armazem WHERE C_Produto=@codigoProduto;

		UPDATE Produto SET Unidades=Unidades+@quantidadeArmazem;

		DELETE FROM Armazem WHERE C_Produto=@codigoProduto;

		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;
	END CATCH
END
```

  private void button_restock_Click(object sender, EventArgs e)
  {










      if (comboBox1.SelectedItem != null)
      {
          try
          {
              if (!int.TryParse(comboBox1.SelectedIndex.ToString(), out int selectedItem))
              {
                  MessageBox.Show("Código Inválido!");
                  return;
              }

              cn = getSGBDConnection();
              if (!verifySGBDConnection())
              {
                  MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test");
                  return;
              }
              SqlCommand command = new SqlCommand("reporProduto", cn);
              command.CommandType = CommandType.StoredProcedure;
              command.Parameters.Add("@codigoProduto", SqlDbType.Int).Value = selectedItem;

              command.ExecuteNonQuery();

              loadArmazem();
              loadProdutosZero();

              MessageBox.Show("Produto reposto com sucesso!");
          }
          catch (Exception ex)
          {
              MessageBox.Show($"An error occurred: {ex.Message}");
          }
      }
      else
      {
          MessageBox.Show("Por favor, selecione um produto.");
      }
  }

  Neste Forms é apresentado ao utilizador todos os produtos assim como os seus atributos através de um simples select. Tem a função ainda de reposição que é ao que as funções acima correspondem.


## Índices/Indexes



```sql
CREATE INDEX idx_empregado_nome ON Empregado(Nome);
CREATE INDEX idx_caixista_empregado ON Caixista(N_Caixista);
CREATE INDEX idx_lojista_empregado ON Lojista(N_Lojista);
```

Os índices são estruturas de dados que melhora a velocidade em operações de pesquisa. Escolhemos estes índices porque a nosso são as operações de pesquisa mais usadas no nosso sistema.

[Indexes File](sql/Indexes.sql "SQLFileQuestion")


## SQL Programming: Stored Procedures, Triggers, UDF

[SQL SPs and Functions File](SQL/sp.sql "SQLFileQuestion")

[SQL Triggers File](SQL/triggers.sql "SQLFileQuestion")

[SQL UDF File](SQL/udf.sql "SQLFileQuestion")

[SQL View File](SQL/Views.sql "SQLFileQuestion")



### Dados iniciais da dabase de dados/Database init data

[SQL Innit File](SQL/db_innit.sql "SQLFileQuestion")





 