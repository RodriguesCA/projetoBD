using System.Data;
using System.Data.SqlClient;

namespace BD_APP
{
    public partial class Inventario : Form
    {
        private SqlConnection cn;
        public Inventario()
        {
            InitializeComponent();

            panel_produtos.Hide();
            restock.Hide();
            label1.Hide();
            comboBox1.Hide();

            encomendar.Hide();
            label2.Hide();
            comboBox2.Hide();
            label3.Hide();
            textBox2.Hide();
            label4.Hide();
            textBox3.Hide();

            dataGridView_armazem.Hide();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            loadProdutos();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= AFONSOCR; integrated security=true; initial catalog=MiniMercado");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();
            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void loadProdutosZero()
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE");
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

                comboBox1.Items.Clear();

                string query = "SELECT Codigo FROM Produto WHERE Unidades = 0";
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Codigo"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void loadProdutosTotal()
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE");
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

                comboBox2.Items.Clear();

                string query = "SELECT Codigo FROM Produto";
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Codigo"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void loadProdutos()
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE");
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

                string query = "SELECT * FROM Produto";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView_produtos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void loadArmazem()
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE");
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
                string query = "SELECT * FROM Armazem";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView_armazem.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void gestão_produtos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_armazem_Click(object sender, EventArgs e)
        {
            loadProdutosZero();
            loadArmazem();
            loadProdutosTotal();

            panel_produtos.Show();
            restock.Show();
            label1.Show();
            comboBox1.Show();

            encomendar.Show();
            label2.Show();
            comboBox2.Show();
            label3.Show();
            textBox2.Show();
            label4.Show();
            textBox3.Show();

            dataGridView_produtos.Hide();
            dataGridView_armazem.Show();

        }

        private void button_produto_Click(object sender, EventArgs e)
        {
            loadProdutos();

            panel_produtos.Hide();
            restock.Hide();
            label1.Hide();
            comboBox1.Hide();

            encomendar.Hide();
            label2.Hide();
            comboBox2.Hide();
            label3.Hide();
            textBox2.Hide();
            label4.Hide();
            textBox3.Hide();

            dataGridView_produtos.Show();
            dataGridView_armazem.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string query = "SELECT Tipo_Seccao FROM Produto WHERE Codigo = @Codigo";

                if (!int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedItem))
                {
                    MessageBox.Show("Código Inválido!");
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
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.Add("@Codigo", SqlDbType.Int).Value = selectedItem;
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        textBox2.Text = result.ToString();
                    }
                    else
                    {
                        textBox2.Text = "Tipo de secção não encontrado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

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

        private void button_encomendar_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("Falha na conexão com o banco de dados.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Unidades Inválido!");
                return;
            }

            if (comboBox2.SelectedItem != null)
            {
                if (!int.TryParse(comboBox2.SelectedIndex.ToString(), out int selectedItem))
                {
                    MessageBox.Show("Código Inválido!");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int unidades))
                {
                    MessageBox.Show("Unidades Inválido!");
                    return;
                }

                cn = getSGBDConnection();
                if (!verifySGBDConnection())
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test");
                    return;
                }
                SqlCommand command = new SqlCommand("encomendarProduto", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@codigoProduto", SqlDbType.Int).Value = selectedItem;
                command.Parameters.Add("@tipoSeccao", SqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@quantidade", SqlDbType.Int).Value = unidades;

                command.ExecuteNonQuery();

                loadArmazem();
                loadProdutosZero();

                MessageBox.Show("Produto reposto com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto.");
            }
        }
    }
}

