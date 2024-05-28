
namespace BD_APP
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            button_empregados = new Button();
            button_clientes = new Button();
            button_inventario = new Button();
            label1 = new Label();
            logo = new Label();
            button_add_client = new Button();
            button_add_lojista = new Button();
            button_rem_employe = new Button();
            textBox_nome_c = new TextBox();
            label_nome_c = new Label();
            label_nif_c = new Label();
            textBox_nif_c = new TextBox();
            label_add_client = new Label();
            button_def_add_c = new Button();
            label_rem_c = new Label();
            label_nif_rem_c = new Label();
            textBox_rem_nif_c = new TextBox();
            button_def_rem_e = new Button();
            list_empregados = new ListBox();
            list_empregados = new ListBox();
            label_add_lojista = new Label();
            button1_add_lojista = new Button();
            label_nome_lojista = new Label();
            label_num_lojista = new Label();
            label_nif_lojista = new Label();
            label_horas_lojista = new Label();
            label_salario_lojista = new Label();
            textBox_nome_lojista = new TextBox();
            textBox_num_lojista = new TextBox();
            textBox_nif_lojista = new TextBox();
            textBox_horas_lojista = new TextBox();
            textBox_sal_lojista = new TextBox();
            button_add_caixista = new Button();
            label_add_caixista = new Label();
            label_sec_lojista = new Label();
            label_name_caixista = new Label();
            textBox_name_caixista = new TextBox();
            label_num_caixista = new Label();
            textBox_num_caixista = new TextBox();
            label_nif_caixista = new Label();
            textBox_nif_caixista = new TextBox();
            label_horas_caixista = new Label();
            textBox_horas_caixista = new TextBox();
            label_sal_caixista = new Label();
            textBox_sal_caixista = new TextBox();
            comboBox_seccoes = new ComboBox();
            dataGridView_empregados = new DataGridView();
            comboBox_caixas = new ComboBox();
            label2 = new Label();
            label_id_rem = new Label();
            textBox_rem_empregado = new TextBox();
            dataGridView_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_empregados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).BeginInit();
            label_caixa_caixista = new Label();
            button1_add_caixista = new Button();
            SuspendLayout();
            // 
            // button_empregados
            // 
            button_empregados.BackColor = Color.IndianRed;
            button_empregados.FlatStyle = FlatStyle.System;
            button_empregados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_empregados.Location = new Point(43, 31);
            button_empregados.Margin = new Padding(6, 4, 4, 4);
            button_empregados.Name = "button_empregados";
            button_empregados.Size = new Size(194, 56);
            button_empregados.TabIndex = 0;
            button_empregados.Text = "Empregados";
            button_empregados.UseVisualStyleBackColor = false;
            button_empregados.Click += button_manager_Click;
            // 
            // button_clientes
            // 
            button_clientes.FlatStyle = FlatStyle.System;
            button_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clientes.Location = new Point(259, 31);
            button_clientes.Margin = new Padding(4);
            button_clientes.Name = "button_clientes";
            button_clientes.Size = new Size(194, 56);
            button_clientes.TabIndex = 1;
            button_clientes.Text = "Clientes";
            button_clientes.UseVisualStyleBackColor = true;
            button_clientes.Click += button_client_Click;
            // 
            // button_inventario
            // 
            button_inventario.FlatStyle = FlatStyle.System;
            button_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_inventario.Location = new Point(484, 31);
            button_inventario.Margin = new Padding(4);
            button_inventario.Name = "button_inventario";
            button_inventario.Size = new Size(194, 56);
            button_inventario.TabIndex = 2;
            button_inventario.Text = "Inventário";
            button_inventario.UseVisualStyleBackColor = true;
            button_inventario.Click += button_inventario_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-39, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 0);
            label1.TabIndex = 3;
            label1.Text = "Mercado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(1048, 145);
            logo.Margin = new Padding(4, 0, 4, 0);
            logo.Name = "logo";
            logo.Size = new Size(649, 512);
            logo.TabIndex = 4;
            logo.Click += logo_Click;
            // 
            // button_add_client
            // 
            button_add_client.FlatStyle = FlatStyle.System;
            button_add_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_client.Location = new Point(43, 145);
            button_add_client.Margin = new Padding(4);
            button_add_client.Name = "button_add_client";
            button_add_client.Size = new Size(302, 76);
            button_add_client.TabIndex = 9;
            button_add_client.Text = "Adicionar Clientes";
            button_add_client.UseVisualStyleBackColor = true;
            button_rem_client.Click += button_rem_client_Click;
            // 
            // button_add_lojista
            // 
            button_add_lojista.FlatStyle = FlatStyle.System;
            button_add_lojista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_lojista.Location = new Point(43, 145);
            button_add_lojista.Margin = new Padding(4);
            button_add_lojista.Name = "button_add_lojista";
            button_add_lojista.Size = new Size(302, 76);
            button_add_lojista.TabIndex = 13;
            button_add_lojista.Text = "Adicionar Lojista";
            button_add_lojista.UseVisualStyleBackColor = true;
            button_add_lojista.Click += button_add_lojista_Click;
            // 
            // button_rem_employe
            // 
            button_rem_employe.FlatStyle = FlatStyle.System;
            button_rem_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rem_employe.Location = new Point(43, 352);
            button_rem_employe.Margin = new Padding(4);
            button_rem_employe.Name = "button_rem_employe";
            button_rem_employe.Size = new Size(302, 76);
            button_rem_employe.TabIndex = 14;
            button_rem_employe.Text = "Remover Empregado";
            button_rem_employe.UseVisualStyleBackColor = true;
            button_rem_employe.Click += button_rem_employe_Click;
            // 
            // textBox_nome_c
            // 
            textBox_nome_c.Location = new Point(558, 300);
            textBox_nome_c.Margin = new Padding(4);
            textBox_nome_c.Name = "textBox_nome_c";
            textBox_nome_c.Size = new Size(352, 39);
            textBox_nome_c.TabIndex = 25;
            // 
            // label_nome_c
            // 
            label_nome_c.AutoSize = true;
            label_nome_c.BackColor = Color.WhiteSmoke;
            label_nome_c.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome_c.Location = new Point(438, 296);
            label_nome_c.Margin = new Padding(4, 0, 4, 0);
            label_nome_c.Name = "label_nome_c";
            label_nome_c.Size = new Size(117, 45);
            label_nome_c.TabIndex = 24;
            label_nome_c.Text = "Nome:";
            // 
            // label_nif_c
            // 
            label_nif_c.AutoSize = true;
            label_nif_c.BackColor = Color.WhiteSmoke;
            label_nif_c.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nif_c.Location = new Point(438, 387);
            label_nif_c.Margin = new Padding(4, 0, 4, 0);
            label_nif_c.Name = "label_nif_c";
            label_nif_c.Size = new Size(78, 45);
            label_nif_c.TabIndex = 23;
            label_nif_c.Text = "NIF:";
            // 
            // textBox_nif_c
            // 
            textBox_nif_c.Location = new Point(558, 390);
            textBox_nif_c.Margin = new Padding(4);
            textBox_nif_c.Name = "textBox_nif_c";
            textBox_nif_c.Size = new Size(352, 39);
            textBox_nif_c.TabIndex = 22;
            // 
            // label_add_client
            // 
            label_add_client.BackColor = Color.WhiteSmoke;
            label_add_client.BorderStyle = BorderStyle.FixedSingle;
            label_add_client.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_add_client.Location = new Point(413, 141);
            label_add_client.Margin = new Padding(4, 0, 4, 0);
            label_add_client.Name = "label_add_client";
            label_add_client.Size = new Size(606, 515);
            label_add_client.TabIndex = 21;
            label_add_client.Text = "Adicionar Cliente";
            label_add_client.Click += label_add_client_Click;
            // 
            // button_def_add_c
            // 
            button_def_add_c.BackColor = Color.OliveDrab;
            button_def_add_c.FlatStyle = FlatStyle.Popup;
            button_def_add_c.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_def_add_c.ForeColor = SystemColors.ButtonFace;
            button_def_add_c.Location = new Point(826, 585);
            button_def_add_c.Margin = new Padding(6, 4, 4, 4);
            button_def_add_c.Name = "button_def_add_c";
            button_def_add_c.Size = new Size(173, 56);
            button_def_add_c.TabIndex = 26;
            button_def_add_c.Text = "Adicionar";
            button_def_add_c.UseVisualStyleBackColor = false;
            button_def_add_c.Click += button_def_add_c_Click;
            // 
            // label_rem_c
            // 
            label_rem_c.BackColor = Color.WhiteSmoke;
            label_rem_c.BorderStyle = BorderStyle.FixedSingle;
            label_rem_c.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_rem_c.Location = new Point(413, 137);
            label_rem_c.Margin = new Padding(4, 0, 4, 0);
            label_rem_c.Name = "label_rem_c";
            label_rem_c.Size = new Size(606, 519);
            label_rem_c.TabIndex = 27;
            label_rem_c.Text = "Remover Cliente";
            label_rem_c.Click += label_rem_c_Click_1;
            // 
            // label_nif_rem_c
            // 
            label_nif_rem_c.AutoSize = true;
            label_nif_rem_c.BackColor = Color.WhiteSmoke;
            label_nif_rem_c.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nif_rem_c.Location = new Point(432, 273);
            label_nif_rem_c.Margin = new Padding(4, 0, 4, 0);
            label_nif_rem_c.Name = "label_nif_rem_c";
            label_nif_rem_c.Size = new Size(83, 47);
            label_nif_rem_c.TabIndex = 28;
            label_nif_rem_c.Text = "NIF:";
            // 
            // textBox_rem_nif_c
            // 
            textBox_rem_nif_c.Location = new Point(526, 273);
            textBox_rem_nif_c.Margin = new Padding(4);
            textBox_rem_nif_c.Name = "textBox_rem_nif_c";
            textBox_rem_nif_c.Size = new Size(352, 39);
            textBox_rem_nif_c.TabIndex = 29;
            // 
            button_def_rem_e.BackColor = Color.IndianRed;
            button_def_rem_e.FlatStyle = FlatStyle.Popup;
            button_def_rem_e.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_def_rem_e.Location = new Point(621, 438);
            button_def_rem_e.Margin = new Padding(5, 3, 3, 3);
            button_def_rem_e.Name = "button_def_rem_e";
            button_def_rem_e.Size = new Size(133, 48);
            button_def_rem_e.TabIndex = 30;
            button_def_rem_e.Text = "Remover";
            button_def_rem_e.UseVisualStyleBackColor = false;
            button_def_rem_e.Click += button_def_rem_e_Click;
            // 
            list_empregados.TabIndex = 31;
            // 
            // label_add_lojista
            // 
            label_add_lojista.BackColor = Color.WhiteSmoke;
            label_add_lojista.BorderStyle = BorderStyle.FixedSingle;
            label_add_lojista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_add_lojista.Location = new Point(413, 137);
            label_add_lojista.Margin = new Padding(4, 0, 4, 0);
            label_add_lojista.Name = "label_add_lojista";
            label_add_lojista.Size = new Size(606, 519);
            label_add_lojista.TabIndex = 32;
            label_add_lojista.Text = "Adicionar Lojista";
            label_add_lojista.Click += label_add_employe_Click;
            // 
            // button1_add_lojista
            // 
            button1_add_lojista.BackColor = Color.OliveDrab;
            button1_add_lojista.FlatStyle = FlatStyle.Popup;
            button1_add_lojista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_add_lojista.ForeColor = SystemColors.ButtonFace;
            button1_add_lojista.Location = new Point(826, 584);
            button1_add_lojista.Margin = new Padding(6, 4, 4, 4);
            button1_add_lojista.Name = "button1_add_lojista";
            button1_add_lojista.Size = new Size(173, 56);
            button1_add_lojista.TabIndex = 33;
            button1_add_lojista.Text = "Adicionar";
            button1_add_lojista.UseVisualStyleBackColor = false;
            button1_add_lojista.Click += button1_add_lojista_Click;
            // 
            // label_nome_lojista
            // 
            label_nome_lojista.AutoSize = true;
            label_nome_lojista.BackColor = Color.WhiteSmoke;
            label_nome_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nome_lojista.Location = new Point(438, 228);
            label_nome_lojista.Margin = new Padding(4, 0, 4, 0);
            label_nome_lojista.Name = "label_nome_lojista";
            label_nome_lojista.Size = new Size(99, 37);
            label_nome_lojista.TabIndex = 34;
            label_nome_lojista.Text = "Nome:";
            // 
            // label_num_lojista
            // 
            label_num_lojista.AutoSize = true;
            label_num_lojista.BackColor = Color.WhiteSmoke;
            label_num_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_num_lojista.Location = new Point(438, 296);
            label_num_lojista.Size = new Size(37, 28);
            label_num_lojista.Name = "label_num_lojista";
            label_num_lojista.Size = new Size(92, 28);
            label_num_lojista.TabIndex = 35;
            label_num_lojista.Text = "ID:";
            // 
            // label_nif_lojista
            // 
            label_nif_lojista.AutoSize = true;
            label_nif_lojista.BackColor = Color.WhiteSmoke;
            label_nif_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nif_lojista.Location = new Point(438, 352);
            label_nif_lojista.Margin = new Padding(4, 0, 4, 0);
            label_nif_lojista.Name = "label_nif_lojista";
            label_nif_lojista.Size = new Size(67, 37);
            label_nif_lojista.TabIndex = 36;
            label_nif_lojista.Text = "NIF:";
            label_nif_lojista.Click += label3_Click;
            // 
            // label_horas_lojista
            // 
            label_horas_lojista.AutoSize = true;
            label_horas_lojista.BackColor = Color.WhiteSmoke;
            label_horas_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_horas_lojista.Location = new Point(438, 411);
            label_horas_lojista.Margin = new Padding(4, 0, 4, 0);
            label_horas_lojista.Name = "label_horas_lojista";
            label_horas_lojista.Size = new Size(308, 37);
            label_horas_lojista.TabIndex = 37;
            label_horas_lojista.Text = "Horas de Trabalho (dia):";
            // 
            // label_salario_lojista
            // 
            label_salario_lojista.AutoSize = true;
            label_salario_lojista.BackColor = Color.WhiteSmoke;
            label_salario_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_salario_lojista.Location = new Point(438, 472);
            label_salario_lojista.Margin = new Padding(4, 0, 4, 0);
            label_salario_lojista.Name = "label_salario_lojista";
            label_salario_lojista.Size = new Size(107, 37);
            label_salario_lojista.TabIndex = 38;
            label_salario_lojista.Text = "Salário:";
            // 
            // textBox_nome_lojista
            // 
            textBox_nome_lojista.Location = new Point(541, 228);
            textBox_nome_lojista.Margin = new Padding(4);
            textBox_nome_lojista.Name = "textBox_nome_lojista";
            textBox_nome_lojista.Size = new Size(421, 39);
            textBox_nome_lojista.TabIndex = 39;
            // 
            // textBox_num_lojista
            // 
            textBox_num_lojista.Location = new Point(588, 297);
            textBox_num_lojista.Margin = new Padding(4);
            textBox_num_lojista.Name = "textBox_num_lojista";
            textBox_num_lojista.Size = new Size(207, 39);
            textBox_num_lojista.TabIndex = 40;
            textBox_num_lojista.TextChanged += textBox_num_employe_TextChanged;
            // 
            // textBox_nif_lojista
            // 
            textBox_nif_lojista.Location = new Point(520, 352);
            textBox_nif_lojista.Margin = new Padding(4);
            textBox_nif_lojista.Name = "textBox_nif_lojista";
            textBox_nif_lojista.Size = new Size(207, 39);
            textBox_nif_lojista.TabIndex = 41;
            // 
            // textBox_horas_lojista
            // 
            textBox_horas_lojista.Location = new Point(744, 411);
            textBox_horas_lojista.Margin = new Padding(4);
            textBox_horas_lojista.Name = "textBox_horas_lojista";
            textBox_horas_lojista.Size = new Size(176, 39);
            textBox_horas_lojista.TabIndex = 42;
            // 
            // textBox_sal_lojista
            // 
            textBox_sal_lojista.Location = new Point(546, 472);
            textBox_sal_lojista.Margin = new Padding(4);
            textBox_sal_lojista.Name = "textBox_sal_lojista";
            textBox_sal_lojista.Size = new Size(148, 39);
            textBox_sal_lojista.TabIndex = 43;
            // 
            // button_add_caixista
            // 
            button_add_caixista.Location = new Point(33, 197);
            button_add_caixista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_caixista.Location = new Point(33, 191);
            button_add_caixista.Name = "button_add_caixista";
            button_add_caixista.Size = new Size(302, 76);
            button_add_caixista.TabIndex = 44;
            button_add_caixista.Text = "Adicionar Caixista";
            button_add_caixista.UseVisualStyleBackColor = true;
            button_add_caixista.Click += button_add_caixista_Click;
            // 
            // label_add_caixista
            // 
            label_add_caixista.BackColor = Color.WhiteSmoke;
            label_add_caixista.BorderStyle = BorderStyle.FixedSingle;
            label_add_caixista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_add_caixista.Location = new Point(413, 137);
            label_add_caixista.Margin = new Padding(4, 0, 4, 0);
            label_add_caixista.Name = "label_add_caixista";
            label_add_caixista.Size = new Size(606, 519);
            label_add_caixista.TabIndex = 45;
            label_add_caixista.Text = "Adicionar Caixista";
            // 
            // label_sec_lojista
            // 
            label_sec_lojista.AutoSize = true;
            label_sec_lojista.BackColor = Color.WhiteSmoke;
            label_sec_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_sec_lojista.Location = new Point(438, 530);
            label_sec_lojista.Margin = new Padding(4, 0, 4, 0);
            label_sec_lojista.Name = "label_sec_lojista";
            label_sec_lojista.Size = new Size(207, 37);
            label_sec_lojista.TabIndex = 46;
            label_sec_lojista.Text = "Tipo de Secção:";
            list_sec_lojista.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label_name_caixista
            // 
            label_name_caixista.AutoSize = true;
            label_name_caixista.BackColor = Color.WhiteSmoke;
            label_name_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_name_caixista.Location = new Point(438, 228);
            label_name_caixista.Margin = new Padding(4, 0, 4, 0);
            label_name_caixista.Name = "label_name_caixista";
            label_name_caixista.Size = new Size(99, 37);
            label_name_caixista.TabIndex = 48;
            label_name_caixista.Text = "Nome:";
            // 
            // textBox_name_caixista
            // 
            textBox_name_caixista.Location = new Point(558, 228);
            textBox_name_caixista.Margin = new Padding(4);
            textBox_name_caixista.Name = "textBox_name_caixista";
            textBox_name_caixista.Size = new Size(421, 39);
            textBox_name_caixista.TabIndex = 49;
            textBox_name_caixista.TextChanged += textBox_name_caixista_TextChanged;
            // 
            // label_num_caixista
            // 
            label_num_caixista.AutoSize = true;
            label_num_caixista.BackColor = Color.WhiteSmoke;
            label_num_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_num_caixista.Location = new Point(438, 292);
            label_num_caixista.Size = new Size(37, 28);
            label_num_caixista.Name = "label_num_caixista";
            label_num_caixista.Size = new Size(92, 28);
            label_num_caixista.TabIndex = 50;
            label_num_caixista.Text = "ID:";
            // 
            // textBox_num_caixista
            // 
            textBox_num_caixista.Location = new Point(566, 292);
            textBox_num_caixista.Margin = new Padding(4);
            textBox_num_caixista.Name = "textBox_num_caixista";
            textBox_num_caixista.Size = new Size(207, 39);
            textBox_num_caixista.TabIndex = 51;
            // 
            // label_nif_caixista
            // 
            label_nif_caixista.AutoSize = true;
            label_nif_caixista.BackColor = Color.WhiteSmoke;
            label_nif_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nif_caixista.Location = new Point(438, 347);
            label_nif_caixista.Margin = new Padding(4, 0, 4, 0);
            label_nif_caixista.Name = "label_nif_caixista";
            label_nif_caixista.Size = new Size(67, 37);
            label_nif_caixista.TabIndex = 52;
            label_nif_caixista.Text = "NIF:";
            // 
            // textBox_nif_caixista
            // 
            textBox_nif_caixista.Location = new Point(526, 347);
            textBox_nif_caixista.Margin = new Padding(4);
            textBox_nif_caixista.Name = "textBox_nif_caixista";
            textBox_nif_caixista.Size = new Size(207, 39);
            textBox_nif_caixista.TabIndex = 53;
            // 
            // label_horas_caixista
            // 
            label_horas_caixista.AutoSize = true;
            label_horas_caixista.BackColor = Color.WhiteSmoke;
            label_horas_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_horas_caixista.Location = new Point(438, 415);
            label_horas_caixista.Margin = new Padding(4, 0, 4, 0);
            label_horas_caixista.Name = "label_horas_caixista";
            label_horas_caixista.Size = new Size(308, 37);
            label_horas_caixista.TabIndex = 54;
            label_horas_caixista.Text = "Horas de Trabalho (dia):";
            // 
            // textBox_horas_caixista
            // 
            textBox_horas_caixista.Location = new Point(755, 415);
            textBox_horas_caixista.Margin = new Padding(4);
            textBox_horas_caixista.Name = "textBox_horas_caixista";
            textBox_horas_caixista.Size = new Size(176, 39);
            textBox_horas_caixista.TabIndex = 55;
            // 
            // label_sal_caixista
            // 
            label_sal_caixista.AutoSize = true;
            label_sal_caixista.BackColor = Color.WhiteSmoke;
            label_sal_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_sal_caixista.Location = new Point(438, 476);
            label_sal_caixista.Margin = new Padding(4, 0, 4, 0);
            label_sal_caixista.Name = "label_sal_caixista";
            label_sal_caixista.Size = new Size(107, 37);
            label_sal_caixista.TabIndex = 56;
            label_sal_caixista.Text = "Salário:";
            // 
            // textBox_sal_caixista
            // 
            textBox_sal_caixista.Location = new Point(546, 476);
            textBox_sal_caixista.Margin = new Padding(4);
            textBox_sal_caixista.Name = "textBox_sal_caixista";
            textBox_sal_caixista.Size = new Size(148, 39);
            textBox_sal_caixista.TabIndex = 57;
            // 
            // label_caixa_caixista
            // 
            label_caixa_caixista.AutoSize = true;
            label_caixa_caixista.Location = new Point(337, 419);
            label_caixa_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_caixa_caixista.Location = new Point(337, 422);
            label_caixa_caixista.Name = "label_caixa_caixista";
            label_caixa_caixista.Size = new Size(235, 37);
            label_caixa_caixista.TabIndex = 58;
            listBox_caixa_caxista.TabIndex = 59;
            // 
            // button1_add_caixista
            // 
            button1_add_caixista.BackColor = Color.OliveDrab;
            button1_add_caixista.FlatStyle = FlatStyle.Popup;
            button1_add_caixista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_add_caixista.ForeColor = SystemColors.ButtonFace;
            button1_add_caixista.Location = new Point(826, 585);
            button1_add_caixista.Margin = new Padding(6, 4, 4, 4);
            button1_add_caixista.Name = "button1_add_caixista";
            button1_add_caixista.Size = new Size(173, 56);
            button1_add_caixista.TabIndex = 60;
            button1_add_caixista.Text = "Adicionar";
            button1_add_caixista.UseVisualStyleBackColor = false;
            button1_add_caixista.Click += button1_add_caixista_Click;
            // 
            // comboBox_seccoes
            // 
            comboBox_seccoes.FormattingEnabled = true;
            comboBox_seccoes.Location = new Point(523, 414);
            comboBox_seccoes.Name = "comboBox_seccoes";
            comboBox_seccoes.Size = new Size(185, 33);
            comboBox_seccoes.TabIndex = 61;
            // 
            // dataGridView_empregados
            // 
            dataGridView_empregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_empregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_empregados.Location = new Point(33, 530);
            dataGridView_empregados.Name = "dataGridView_empregados";
            dataGridView_empregados.RowHeadersWidth = 62;
            dataGridView_empregados.Size = new Size(1253, 225);
            dataGridView_empregados.TabIndex = 62;
            // 
            // comboBox_caixas
            // 
            comboBox_caixas.FormattingEnabled = true;
            comboBox_caixas.Location = new Point(523, 414);
            comboBox_caixas.Name = "comboBox_caixas";
            comboBox_caixas.Size = new Size(185, 33);
            comboBox_caixas.TabIndex = 63;
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 110);
            label2.Name = "label2";
            label2.Size = new Size(467, 403);
            label2.TabIndex = 64;
            label2.Text = "Remover Empregado";
            // 
            // label_id_rem
            // 
            label_id_rem.AutoSize = true;
            label_id_rem.BackColor = Color.WhiteSmoke;
            label_id_rem.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_id_rem.Location = new Point(337, 220);
            label_id_rem.Name = "label_id_rem";
            label_id_rem.Size = new Size(108, 36);
            label_id_rem.TabIndex = 65;
            // textBox_rem_empregado
            // 
            textBox_rem_empregado.Location = new Point(452, 228);
            textBox_rem_empregado.Name = "textBox_rem_empregado";
            textBox_rem_empregado.Size = new Size(274, 31);
            textBox_rem_empregado.TabIndex = 66;
            // 
            // dataGridView_clientes
            // 
            dataGridView_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_clientes.Location = new Point(33, 530);
            dataGridView_clientes.Name = "dataGridView_clientes";
            dataGridView_clientes.RowHeadersWidth = 62;
            dataGridView_clientes.Size = new Size(1253, 225);
            dataGridView_clientes.TabIndex = 67;
            // 
            label_id_rem.Text = "Código:";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            ClientSize = new Size(1322, 779);
            Controls.Add(dataGridView_clientes);
            Controls.Add(textBox_rem_empregado);
            Controls.Add(label_id_rem);
            Controls.Add(button_def_rem_e);
            Controls.Add(label2);
            Controls.Add(comboBox_caixas);
            Controls.Add(dataGridView_empregados);
            Controls.Add(comboBox_seccoes);
            BackColor = Color.White;
            ClientSize = new Size(1322, 779);
            Controls.Add(button_add_caixista);
            Controls.Add(button_rem_employe);
            Controls.Add(button_add_lojista);
            Controls.Add(button_add_client);
            Controls.Add(label1);
            Controls.Add(button_inventario);
            Controls.Add(button_clientes);
            Controls.Add(button_empregados);
            Controls.Add(label_nif_rem_c);
            Controls.Add(textBox_rem_nif_c);
            Controls.Add(label_sec_lojista);
            Controls.Add(button1_add_caixista);
            Controls.Add(label_caixa_caixista);
            Controls.Add(textBox_sal_caixista);
            Controls.Add(label_sal_caixista);
            Controls.Add(textBox_horas_caixista);
            Controls.Add(label_horas_caixista);
            Controls.Add(textBox_nif_caixista);
            Controls.Add(label_nif_caixista);
            Controls.Add(textBox_num_caixista);
            Controls.Add(label_num_caixista);
            Controls.Add(textBox_name_caixista);
            Controls.Add(label_name_caixista);
            Controls.Add(textBox_sal_lojista);
            Controls.Add(textBox_horas_lojista);
            Controls.Add(textBox_nif_lojista);
            Controls.Add(textBox_num_lojista);
            Controls.Add(textBox_nome_lojista);
            Controls.Add(label_salario_lojista);
            Controls.Add(label_horas_lojista);
            Controls.Add(label_nif_lojista);
            Controls.Add(label_num_lojista);
            Controls.Add(label_nome_lojista);
            Controls.Add(button1_add_lojista);
            Controls.Add(logo);
            Controls.Add(label_nome_c);
            Controls.Add(textBox_nome_c);
            Controls.Add(label_nif_c);
            Controls.Add(textBox_nif_c);
            Controls.Add(button_def_add_c);
            Controls.Add(label_add_client);
            Controls.Add(label_add_caixista);
            Controls.Add(label_add_lojista);
            Controls.Add(label_rem_c);
            Name = "Welcome";
            ((System.ComponentModel.ISupportInitialize)dataGridView_empregados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).EndInit();
            Text = "Index";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void list_empregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_empregados;
        private Button button_clientes;
        private Button button_inventario;
        private Label label1;
        private Label logo;
        private Button button_add_client;
        private Button button_add_lojista;
        private Button button_rem_employe;
        private TextBox textBox_nome_c;
        private Label label_nome_c;
        private Label label_nif_c;
        private TextBox textBox_nif_c;
        private Label label_add_client;
        private Button button_def_add_c;
        private Label label_rem_c;
        private Label label_nif_rem_c;
        private TextBox textBox_rem_nif_c;
        private Button button_def_rem_c;
        private Label label_add_lojista;
        private Button button1_add_lojista;
        private Label label_nome_lojista;
        private Label label_num_lojista;
        private Label label_nif_lojista;
        private Label label_horas_lojista;
        private Label label_salario_lojista;
        private TextBox textBox_nome_lojista;
        private TextBox textBox_num_lojista;
        private TextBox textBox_nif_lojista;
        private TextBox textBox_horas_lojista;
        private TextBox textBox_sal_lojista;
        private Button button_add_caixista;
        private Label label2;
        private Label label_sec_lojista;
        private Label label_name_caixista;
        private TextBox textBox_name_caixista;
        private Label label_num_caixista;
        private TextBox textBox_num_caixista;
        private Label label_nif_caixista;
        private TextBox textBox_nif_caixista;
        private Label label_horas_caixista;
        private TextBox textBox_horas_caixista;
        private Label label_sal_caixista;
        private TextBox textBox_sal_caixista;
        private Label label_caixa_caixista;
        private ComboBox comboBox_seccoes;
        private DataGridView dataGridView_empregados;
        private ComboBox comboBox_caixas;
        private Button button_def_rem_e;
        private Label label_id_rem;
        private TextBox textBox_rem_empregado;
        private DataGridView dataGridView1;
        private DataGridView dataGridView_clientes;
        private Button button1_add_caixista;
        private Label label_add_caixista;
    }
}
