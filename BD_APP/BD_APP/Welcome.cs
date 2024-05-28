using System;
using System.Data;
using System.Data.SqlClient;

namespace BD_APP
{
    public partial class Welcome : Form
    {
        private SqlConnection cn;

        public Welcome()
        {
            InitializeComponent();

            button_add_client.Hide();               // Hide Client menu
            button_rem_client.Hide();


            button_rem_employe.Hide();
            button_add_lojista.Hide();

            logo.Location = new Point(385, 130);    // Logo to the middle

            button_def_add_c.Hide();                // Hide add client
            label_add_client.Hide();
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_nome_c.Hide();
            label_nif_c.Hide();

            button_def_rem_c.Hide();                // Hide remove client
            label_rem_c.Hide();
            label_nif_rem_c.Hide();
            textBox_rem_nif_c.Hide();

            button_add_caixista.Hide();            // Hide Empregado menu
            button_add_lojista.Hide();

            button1_add_caixista.Hide();           // Hide Caixista menu
            label_caixa_caixista.Hide();
            label_nif_caixista.Hide();
            label_name_caixista.Hide();
            label_num_caixista.Hide();
            label_horas_caixista.Hide();
            label_sal_caixista.Hide();
            textBox_horas_caixista.Hide();
            textBox_name_caixista.Hide();
            textBox_nif_caixista.Hide();
            textBox_sal_caixista.Hide();
            textBox_num_caixista.Hide();
            listBox_caixa_caxista.Hide();
            label_add_caixista.Hide();



            button1_add_lojista.Hide();            // Hide Lojista menu
            label_salario_lojista.Hide();
            label_horas_lojista.Hide();
            label_nif_lojista.Hide();
            label_nome_lojista.Hide();
            label_add_lojista.Hide();
            label_num_lojista.Hide();
            label_sec_lojista.Hide();
            textBox_horas_lojista.Hide();
            textBox_nif_lojista.Hide();
            textBox_nome_lojista.Hide();
            textBox_sal_lojista.Hide();
            textBox_num_lojista.Hide();
            list_sec_lojista.Hide();

            dataGridView_empregados.Hide();                 // Hide lista de Empregados




            label1.Hide();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            loadEmpregados();
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

        private void loadEmpregados()
        {
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE");
                return;
            }

            try {
                cn = getSGBDConnection();
                if (!verifySGBDConnection())
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test");
                    return;
                }
                string query = "SELECT * FROM Empregado";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView_empregados.DataSource = dataTable;
            } catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        private void button_manager_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(385, 130);// Logo to the middle
            button_add_client.Hide();
            button_rem_client.Hide();           // Hide Client Menu
            button_def_add_c.Hide();
            label_add_client.Hide();            // Hide add client
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_nome_c.Hide();
            label_nif_c.Hide();
            button_def_rem_c.Hide();            // Hide remove client
            label_rem_c.Hide();
            label_nif_rem_c.Hide();
            textBox_rem_nif_c.Hide();
            button_rem_employe.Show();          // Show Employe Menu
            button_add_lojista.Show();
            button_add_caixista.Show();
            dataGridView_empregados.Show();             // Hide lista de Empregados

        }

        private void button_client_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            logo.Location = new Point(385, 130);     // Logo the middle            
            button_rem_client.Show();                // Show Client Menu
            button_rem_client.Enabled = true;
            button_add_client.Show();
            button_add_client.Enabled = true;
            button_def_add_c.Hide();
            label_add_client.Hide();
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_nome_c.Hide();
            label_nif_c.Hide();
            button_def_rem_c.Hide();                // Hide remove client
            label_rem_c.Hide();
            label_nif_rem_c.Hide();
            textBox_rem_nif_c.Hide();
            button_rem_employe.Hide();              // Hide Employe Menu
            button_add_lojista.Hide();
            button_add_caixista.Hide();

            button1_add_caixista.Hide();           // Hide Caixista menu
            label_caixa_caixista.Hide();
            label_nif_caixista.Hide();
            label_name_caixista.Hide();
            label_num_caixista.Hide();
            label_horas_caixista.Hide();
            label_sal_caixista.Hide();
            textBox_horas_caixista.Hide();
            textBox_name_caixista.Hide();
            textBox_nif_caixista.Hide();
            textBox_sal_caixista.Hide();
            textBox_num_caixista.Hide();
            listBox_caixa_caxista.Hide();
            label_add_caixista.Hide();



            button1_add_lojista.Hide();            // Hide Lojista menu
            label_salario_lojista.Hide();
            label_horas_lojista.Hide();
            label_nif_lojista.Hide();
            label_nome_lojista.Hide();
            label_add_lojista.Hide();
            label_num_lojista.Hide();
            label_sec_lojista.Hide();
            textBox_horas_lojista.Hide();
            textBox_nif_lojista.Hide();
            textBox_nome_lojista.Hide();
            textBox_sal_lojista.Hide();
            textBox_num_lojista.Hide();
            list_sec_lojista.Hide();

            dataGridView_empregados.Hide();                 // Hide lista de Empregados
        }

        private void button_inventario_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(385, 130);    // Logo to the middle
            button_add_client.Hide();                // Hide Client Menu
            button_rem_client.Hide();
            button_def_add_c.Hide();
            label_add_client.Hide();
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_nome_c.Hide();
            label_nif_c.Hide();
            button_def_rem_c.Hide();                // Hide remove client
            label_rem_c.Hide();
            label_nif_rem_c.Hide();
            textBox_rem_nif_c.Hide();
            button_add_lojista.Hide();              // Show Employee Menu
            button_rem_employe.Hide();
            button_add_lojista.Enabled = true;
            button_rem_employe.Enabled = true;
            button_rem_employe.Hide();              // Hide Employe Menu
            button_add_lojista.Hide();
            button_add_caixista.Hide();

            button1_add_caixista.Hide();           // Hide Caixista menu
            label_caixa_caixista.Hide();
            label_nif_caixista.Hide();
            label_name_caixista.Hide();
            label_num_caixista.Hide();
            label_horas_caixista.Hide();
            label_sal_caixista.Hide();
            textBox_horas_caixista.Hide();
            textBox_name_caixista.Hide();
            textBox_nif_caixista.Hide();
            textBox_sal_caixista.Hide();
            textBox_num_caixista.Hide();
            listBox_caixa_caxista.Hide();
            label_add_caixista.Hide();



            button1_add_lojista.Hide();            // Hide Lojista menu
            label_salario_lojista.Hide();
            label_horas_lojista.Hide();
            label_nif_lojista.Hide();
            label_nome_lojista.Hide();
            label_add_lojista.Hide();
            label_num_lojista.Hide();
            label_sec_lojista.Hide();
            textBox_horas_lojista.Hide();
            textBox_nif_lojista.Hide();
            textBox_nome_lojista.Hide();
            textBox_sal_lojista.Hide();
            textBox_num_lojista.Hide();
            list_sec_lojista.Hide();

            dataGridView_empregados.Hide();                 // Hide lista de Empregados

            Inventario frm = new();
            frm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }


        private void Client_Click_1(object sender, EventArgs e)
        {

        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(385, 130);    // Logo to the middle
            Secções frm = new();
            frm.Show();
        }

        private void button_add_client_Click_1(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            logo.Location = new Point(785, 130);
            label_nif_c.Show();
            button_def_add_c.Show();
            button_def_add_c.Enabled = true;
            label_nome_c.Show();
            textBox_nif_c.Show();
            textBox_nome_c.Show();
            label_add_client.Show();
            button_def_rem_c.Hide();                // Hide remove client
            label_rem_c.Hide();
            label_nif_rem_c.Hide();
            textBox_rem_nif_c.Hide();

        }

        private void button_rem_client_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(785, 130);
            button_def_rem_c.Show();
            label_nif_rem_c.Show();
            textBox_rem_nif_c.Show();
            label_rem_c.Show();
            label_nif_c.Hide();
            label_nome_c.Hide();
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_add_client.Hide();
            button_def_add_c.Hide();
        }



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


        private void button_add_lojista_Click(object sender, EventArgs e)
        {
            button1_add_lojista.Show();            // Show Lojista menu
            label_salario_lojista.Show();
            label_horas_lojista.Show();
            label_nif_lojista.Show();
            label_nome_lojista.Show();
            label_add_lojista.Show();
            label_num_lojista.Show();
            label_sec_lojista.Show();
            textBox_horas_lojista.Show();
            textBox_nif_lojista.Show();
            textBox_nome_lojista.Show();
            textBox_sal_lojista.Show();
            textBox_num_lojista.Show();
            list_sec_lojista.Show();


            logo.Location = new Point(785, 130);

            button1_add_caixista.Hide();           // Hide Caixista menu
            label_caixa_caixista.Hide();
            label_nif_caixista.Hide();
            label_name_caixista.Hide();
            label_num_caixista.Hide();
            label_horas_caixista.Hide();
            label_sal_caixista.Hide();
            textBox_horas_caixista.Hide();
            textBox_name_caixista.Hide();
            textBox_nif_caixista.Hide();
            textBox_sal_caixista.Hide();
            textBox_num_caixista.Hide();
            listBox_caixa_caxista.Hide();

            label_add_caixista.Hide();
        }

        private void button_rem_employe_Click(object sender, EventArgs e)
        {

        }

        private void label_add_client_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_num_employe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_add_employe_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_caixista_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_rem_c_Click_1(object sender, EventArgs e)
        {

        }

        private void button_add_caixista_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(785, 130);

            button1_add_lojista.Hide();            // Hide Lojista menu
            label_salario_lojista.Hide();
            label_horas_lojista.Hide();
            label_nif_lojista.Hide();
            label_nome_lojista.Hide();
            label_add_lojista.Hide();
            label_num_lojista.Hide();
            label_sec_lojista.Hide();
            textBox_horas_lojista.Hide();
            textBox_nif_lojista.Hide();
            textBox_nome_lojista.Hide();
            textBox_sal_lojista.Hide();
            textBox_num_lojista.Hide();
            list_sec_lojista.Hide();

            button1_add_caixista.Show();           // Hide Caixista menu
            label_caixa_caixista.Show();
            label_nif_caixista.Show();
            label_name_caixista.Show();
            label_num_caixista.Show();
            label_horas_caixista.Show();
            label_sal_caixista.Show();
            textBox_horas_caixista.Show();
            textBox_name_caixista.Show();
            textBox_nif_caixista.Show();
            textBox_sal_caixista.Show();
            textBox_num_caixista.Show();
            listBox_caixa_caxista.Show();
            label_add_caixista.Show();

        }

        private void button_def_rem_c_Click(object sender, EventArgs e)
        {

        }
    }
}   