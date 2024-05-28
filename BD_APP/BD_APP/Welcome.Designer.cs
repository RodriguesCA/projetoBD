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
            button_rem_client = new Button();
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
            button_def_rem_c = new Button();
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
            list_sec_lojista = new ListBox();
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
            label_caixa_caixista = new Label();
            listBox_caixa_caxista = new ListBox();
            button1_add_caixista = new Button();
            SuspendLayout();
            // 
            // button_empregados
            // 
            button_empregados.BackColor = Color.IndianRed;
            button_empregados.FlatStyle = FlatStyle.System;
            button_empregados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_empregados.Location = new Point(33, 24);
            button_empregados.Margin = new Padding(5, 3, 3, 3);
            button_empregados.Name = "button_empregados";
            button_empregados.Size = new Size(149, 44);
            button_empregados.TabIndex = 0;
            button_empregados.Text = "Empregados";
            button_empregados.UseVisualStyleBackColor = false;
            button_empregados.Click += button_manager_Click;
            // 
            // button_clientes
            // 
            button_clientes.FlatStyle = FlatStyle.System;
            button_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clientes.Location = new Point(199, 24);
            button_clientes.Name = "button_clientes";
            button_clientes.Size = new Size(149, 44);
            button_clientes.TabIndex = 1;
            button_clientes.Text = "Clientes";
            button_clientes.UseVisualStyleBackColor = true;
            button_clientes.Click += button_client_Click;
            // 
            // button_inventario
            // 
            button_inventario.FlatStyle = FlatStyle.System;
            button_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_inventario.Location = new Point(372, 24);
            button_inventario.Name = "button_inventario";
            button_inventario.Size = new Size(149, 44);
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
            label1.Location = new Point(-30, -2);
            label1.Name = "label1";
            label1.Size = new Size(0, 0);
            label1.TabIndex = 3;
            label1.Text = "Mercado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(806, 113);
            logo.Name = "logo";
            logo.Size = new Size(499, 400);
            logo.TabIndex = 4;
            logo.Click += logo_Click;
            // 
            // button_add_client
            // 
            button_add_client.FlatStyle = FlatStyle.System;
            button_add_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_client.Location = new Point(33, 113);
            button_add_client.Name = "button_add_client";
            button_add_client.Size = new Size(232, 59);
            button_add_client.TabIndex = 9;
            button_add_client.Text = "Adicionar Clientes";
            button_add_client.UseVisualStyleBackColor = true;
            button_add_client.Click += button_add_client_Click_1;
            // 
            // button_rem_client
            // 
            button_rem_client.FlatStyle = FlatStyle.System;
            button_rem_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rem_client.Location = new Point(33, 190);
            button_rem_client.Name = "button_rem_client";
            button_rem_client.Size = new Size(232, 59);
            button_rem_client.TabIndex = 10;
            button_rem_client.Text = "Remover Clientes";
            button_rem_client.UseVisualStyleBackColor = true;
            button_rem_client.Click += button_rem_client_Click;
            // 
            // button_add_lojista
            // 
            button_add_lojista.FlatStyle = FlatStyle.System;
            button_add_lojista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_lojista.Location = new Point(33, 113);
            button_add_lojista.Name = "button_add_lojista";
            button_add_lojista.Size = new Size(232, 59);
            button_add_lojista.TabIndex = 13;
            button_add_lojista.Text = "Adicionar Lojista";
            button_add_lojista.UseVisualStyleBackColor = true;
            button_add_lojista.Click += button_add_lojista_Click;
            // 
            // button_rem_employe
            // 
            button_rem_employe.FlatStyle = FlatStyle.System;
            button_rem_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rem_employe.Location = new Point(33, 275);
            button_rem_employe.Name = "button_rem_employe";
            button_rem_employe.Size = new Size(232, 59);
            button_rem_employe.TabIndex = 14;
            button_rem_employe.Text = "Remover Empregado";
            button_rem_employe.UseVisualStyleBackColor = true;
            button_rem_employe.Click += button_rem_employe_Click;
            // 
            // textBox_nome_c
            // 
            textBox_nome_c.Location = new Point(429, 234);
            textBox_nome_c.Name = "textBox_nome_c";
            textBox_nome_c.Size = new Size(272, 31);
            textBox_nome_c.TabIndex = 25;
            // 
            // label_nome_c
            // 
            label_nome_c.AutoSize = true;
            label_nome_c.BackColor = Color.WhiteSmoke;
            label_nome_c.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome_c.Location = new Point(337, 231);
            label_nome_c.Name = "label_nome_c";
            label_nome_c.Size = new Size(86, 32);
            label_nome_c.TabIndex = 24;
            label_nome_c.Text = "Nome:";
            // 
            // label_nif_c
            // 
            label_nif_c.AutoSize = true;
            label_nif_c.BackColor = Color.WhiteSmoke;
            label_nif_c.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nif_c.Location = new Point(337, 302);
            label_nif_c.Name = "label_nif_c";
            label_nif_c.Size = new Size(57, 32);
            label_nif_c.TabIndex = 23;
            label_nif_c.Text = "NIF:";
            // 
            // textBox_nif_c
            // 
            textBox_nif_c.Location = new Point(429, 305);
            textBox_nif_c.Name = "textBox_nif_c";
            textBox_nif_c.Size = new Size(272, 31);
            textBox_nif_c.TabIndex = 22;
            // 
            // label_add_client
            // 
            label_add_client.BackColor = Color.WhiteSmoke;
            label_add_client.BorderStyle = BorderStyle.FixedSingle;
            label_add_client.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_add_client.Location = new Point(318, 110);
            label_add_client.Name = "label_add_client";
            label_add_client.Size = new Size(467, 403);
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
            button_def_add_c.Location = new Point(635, 457);
            button_def_add_c.Margin = new Padding(5, 3, 3, 3);
            button_def_add_c.Name = "button_def_add_c";
            button_def_add_c.Size = new Size(133, 44);
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
            label_rem_c.Location = new Point(318, 107);
            label_rem_c.Name = "label_rem_c";
            label_rem_c.Size = new Size(467, 406);
            label_rem_c.TabIndex = 27;
            label_rem_c.Text = "Remover Cliente";
            label_rem_c.Click += label_rem_c_Click_1;
            // 
            // label_nif_rem_c
            // 
            label_nif_rem_c.AutoSize = true;
            label_nif_rem_c.BackColor = Color.WhiteSmoke;
            label_nif_rem_c.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nif_rem_c.Location = new Point(332, 213);
            label_nif_rem_c.Name = "label_nif_rem_c";
            label_nif_rem_c.Size = new Size(62, 36);
            label_nif_rem_c.TabIndex = 28;
            label_nif_rem_c.Text = "NIF:";
            // 
            // textBox_rem_nif_c
            // 
            textBox_rem_nif_c.Location = new Point(405, 213);
            textBox_rem_nif_c.Name = "textBox_rem_nif_c";
            textBox_rem_nif_c.Size = new Size(272, 31);
            textBox_rem_nif_c.TabIndex = 29;
            // 
            // button_def_rem_c
            // 
            button_def_rem_c.BackColor = Color.IndianRed;
            button_def_rem_c.FlatStyle = FlatStyle.Popup;
            button_def_rem_c.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button_def_rem_c.Location = new Point(635, 452);
            button_def_rem_c.Margin = new Padding(5, 3, 3, 3);
            button_def_rem_c.Name = "button_def_rem_c";
            button_def_rem_c.Size = new Size(133, 48);
            button_def_rem_c.TabIndex = 30;
            button_def_rem_c.Text = "Remove";
            button_def_rem_c.UseVisualStyleBackColor = false;
            // 
            // list_empregados
            // 
            list_empregados.FormattingEnabled = true;
            list_empregados.ItemHeight = 25;
            list_empregados.Location = new Point(33, 536);
            list_empregados.Name = "list_empregados";
            list_empregados.Size = new Size(1272, 229);
            list_empregados.TabIndex = 31;
            // 
            // label_add_lojista
            // 
            label_add_lojista.BackColor = Color.WhiteSmoke;
            label_add_lojista.BorderStyle = BorderStyle.FixedSingle;
            label_add_lojista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_add_lojista.Location = new Point(318, 107);
            label_add_lojista.Name = "label_add_lojista";
            label_add_lojista.Size = new Size(467, 406);
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
            button1_add_lojista.Location = new Point(635, 456);
            button1_add_lojista.Margin = new Padding(5, 3, 3, 3);
            button1_add_lojista.Name = "button1_add_lojista";
            button1_add_lojista.Size = new Size(133, 44);
            button1_add_lojista.TabIndex = 33;
            button1_add_lojista.Text = "Adicionar";
            button1_add_lojista.UseVisualStyleBackColor = false;
            // 
            // label_nome_lojista
            // 
            label_nome_lojista.AutoSize = true;
            label_nome_lojista.BackColor = Color.WhiteSmoke;
            label_nome_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nome_lojista.Location = new Point(337, 178);
            label_nome_lojista.Name = "label_nome_lojista";
            label_nome_lojista.Size = new Size(73, 28);
            label_nome_lojista.TabIndex = 34;
            label_nome_lojista.Text = "Nome:";
            // 
            // label_num_lojista
            // 
            label_num_lojista.AutoSize = true;
            label_num_lojista.BackColor = Color.WhiteSmoke;
            label_num_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_num_lojista.Location = new Point(337, 231);
            label_num_lojista.Name = "label_num_lojista";
            label_num_lojista.Size = new Size(92, 28);
            label_num_lojista.TabIndex = 35;
            label_num_lojista.Text = "Número:";
            // 
            // label_nif_lojista
            // 
            label_nif_lojista.AutoSize = true;
            label_nif_lojista.BackColor = Color.WhiteSmoke;
            label_nif_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nif_lojista.Location = new Point(337, 275);
            label_nif_lojista.Name = "label_nif_lojista";
            label_nif_lojista.Size = new Size(48, 28);
            label_nif_lojista.TabIndex = 36;
            label_nif_lojista.Text = "NIF:";
            label_nif_lojista.Click += label3_Click;
            // 
            // label_horas_lojista
            // 
            label_horas_lojista.AutoSize = true;
            label_horas_lojista.BackColor = Color.WhiteSmoke;
            label_horas_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_horas_lojista.Location = new Point(337, 321);
            label_horas_lojista.Name = "label_horas_lojista";
            label_horas_lojista.Size = new Size(229, 28);
            label_horas_lojista.TabIndex = 37;
            label_horas_lojista.Text = "Horas de Trabalho (dia):";
            // 
            // label_salario_lojista
            // 
            label_salario_lojista.AutoSize = true;
            label_salario_lojista.BackColor = Color.WhiteSmoke;
            label_salario_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_salario_lojista.Location = new Point(337, 369);
            label_salario_lojista.Name = "label_salario_lojista";
            label_salario_lojista.Size = new Size(77, 28);
            label_salario_lojista.TabIndex = 38;
            label_salario_lojista.Text = "Salário:";
            // 
            // textBox_nome_lojista
            // 
            textBox_nome_lojista.Location = new Point(416, 178);
            textBox_nome_lojista.Name = "textBox_nome_lojista";
            textBox_nome_lojista.Size = new Size(325, 31);
            textBox_nome_lojista.TabIndex = 39;
            // 
            // textBox_num_lojista
            // 
            textBox_num_lojista.Location = new Point(452, 232);
            textBox_num_lojista.Name = "textBox_num_lojista";
            textBox_num_lojista.Size = new Size(160, 31);
            textBox_num_lojista.TabIndex = 40;
            textBox_num_lojista.TextChanged += textBox_num_employe_TextChanged;
            // 
            // textBox_nif_lojista
            // 
            textBox_nif_lojista.Location = new Point(400, 275);
            textBox_nif_lojista.Name = "textBox_nif_lojista";
            textBox_nif_lojista.Size = new Size(160, 31);
            textBox_nif_lojista.TabIndex = 41;
            // 
            // textBox_horas_lojista
            // 
            textBox_horas_lojista.Location = new Point(572, 321);
            textBox_horas_lojista.Name = "textBox_horas_lojista";
            textBox_horas_lojista.Size = new Size(136, 31);
            textBox_horas_lojista.TabIndex = 42;
            // 
            // textBox_sal_lojista
            // 
            textBox_sal_lojista.Location = new Point(420, 369);
            textBox_sal_lojista.Name = "textBox_sal_lojista";
            textBox_sal_lojista.Size = new Size(115, 31);
            textBox_sal_lojista.TabIndex = 43;
            // 
            // button_add_caixista
            // 
            button_add_caixista.FlatStyle = FlatStyle.System;
            button_add_caixista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_caixista.Location = new Point(33, 191);
            button_add_caixista.Name = "button_add_caixista";
            button_add_caixista.Size = new Size(232, 59);
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
            label_add_caixista.Location = new Point(318, 107);
            label_add_caixista.Name = "label_add_caixista";
            label_add_caixista.Size = new Size(467, 406);
            label_add_caixista.TabIndex = 45;
            label_add_caixista.Text = "Adicionar Caixista";
            // 
            // label_sec_lojista
            // 
            label_sec_lojista.AutoSize = true;
            label_sec_lojista.BackColor = Color.WhiteSmoke;
            label_sec_lojista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_sec_lojista.Location = new Point(337, 414);
            label_sec_lojista.Name = "label_sec_lojista";
            label_sec_lojista.Size = new Size(154, 28);
            label_sec_lojista.TabIndex = 46;
            label_sec_lojista.Text = "Tipo de Secção:";
            label_sec_lojista.Click += label3_Click_1;
            // 
            // list_sec_lojista
            // 
            list_sec_lojista.FormattingEnabled = true;
            list_sec_lojista.ItemHeight = 25;
            list_sec_lojista.Location = new Point(497, 414);
            list_sec_lojista.Name = "list_sec_lojista";
            list_sec_lojista.Size = new Size(164, 29);
            list_sec_lojista.TabIndex = 47;
            list_sec_lojista.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label_name_caixista
            // 
            label_name_caixista.AutoSize = true;
            label_name_caixista.BackColor = Color.WhiteSmoke;
            label_name_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_name_caixista.Location = new Point(337, 178);
            label_name_caixista.Name = "label_name_caixista";
            label_name_caixista.Size = new Size(73, 28);
            label_name_caixista.TabIndex = 48;
            label_name_caixista.Text = "Nome:";
            // 
            // textBox_name_caixista
            // 
            textBox_name_caixista.Location = new Point(429, 178);
            textBox_name_caixista.Name = "textBox_name_caixista";
            textBox_name_caixista.Size = new Size(325, 31);
            textBox_name_caixista.TabIndex = 49;
            textBox_name_caixista.TextChanged += textBox_name_caixista_TextChanged;
            // 
            // label_num_caixista
            // 
            label_num_caixista.AutoSize = true;
            label_num_caixista.BackColor = Color.WhiteSmoke;
            label_num_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_num_caixista.Location = new Point(337, 228);
            label_num_caixista.Name = "label_num_caixista";
            label_num_caixista.Size = new Size(92, 28);
            label_num_caixista.TabIndex = 50;
            label_num_caixista.Text = "Número:";
            // 
            // textBox_num_caixista
            // 
            textBox_num_caixista.Location = new Point(435, 228);
            textBox_num_caixista.Name = "textBox_num_caixista";
            textBox_num_caixista.Size = new Size(160, 31);
            textBox_num_caixista.TabIndex = 51;
            // 
            // label_nif_caixista
            // 
            label_nif_caixista.AutoSize = true;
            label_nif_caixista.BackColor = Color.WhiteSmoke;
            label_nif_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_nif_caixista.Location = new Point(337, 271);
            label_nif_caixista.Name = "label_nif_caixista";
            label_nif_caixista.Size = new Size(48, 28);
            label_nif_caixista.TabIndex = 52;
            label_nif_caixista.Text = "NIF:";
            // 
            // textBox_nif_caixista
            // 
            textBox_nif_caixista.Location = new Point(405, 271);
            textBox_nif_caixista.Name = "textBox_nif_caixista";
            textBox_nif_caixista.Size = new Size(160, 31);
            textBox_nif_caixista.TabIndex = 53;
            // 
            // label_horas_caixista
            // 
            label_horas_caixista.AutoSize = true;
            label_horas_caixista.BackColor = Color.WhiteSmoke;
            label_horas_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_horas_caixista.Location = new Point(337, 324);
            label_horas_caixista.Name = "label_horas_caixista";
            label_horas_caixista.Size = new Size(229, 28);
            label_horas_caixista.TabIndex = 54;
            label_horas_caixista.Text = "Horas de Trabalho (dia):";
            // 
            // textBox_horas_caixista
            // 
            textBox_horas_caixista.Location = new Point(581, 324);
            textBox_horas_caixista.Name = "textBox_horas_caixista";
            textBox_horas_caixista.Size = new Size(136, 31);
            textBox_horas_caixista.TabIndex = 55;
            // 
            // label_sal_caixista
            // 
            label_sal_caixista.AutoSize = true;
            label_sal_caixista.BackColor = Color.WhiteSmoke;
            label_sal_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_sal_caixista.Location = new Point(337, 372);
            label_sal_caixista.Name = "label_sal_caixista";
            label_sal_caixista.Size = new Size(77, 28);
            label_sal_caixista.TabIndex = 56;
            label_sal_caixista.Text = "Salário:";
            // 
            // textBox_sal_caixista
            // 
            textBox_sal_caixista.Location = new Point(420, 372);
            textBox_sal_caixista.Name = "textBox_sal_caixista";
            textBox_sal_caixista.Size = new Size(115, 31);
            textBox_sal_caixista.TabIndex = 57;
            // 
            // label_caixa_caixista
            // 
            label_caixa_caixista.AutoSize = true;
            label_caixa_caixista.BackColor = Color.WhiteSmoke;
            label_caixa_caixista.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label_caixa_caixista.Location = new Point(337, 422);
            label_caixa_caixista.Name = "label_caixa_caixista";
            label_caixa_caixista.Size = new Size(173, 28);
            label_caixa_caixista.TabIndex = 58;
            label_caixa_caixista.Text = "Número da Caixa:";
            // 
            // listBox_caixa_caxista
            // 
            listBox_caixa_caxista.FormattingEnabled = true;
            listBox_caixa_caxista.ItemHeight = 25;
            listBox_caixa_caxista.Location = new Point(516, 421);
            listBox_caixa_caxista.Name = "listBox_caixa_caxista";
            listBox_caixa_caxista.Size = new Size(164, 29);
            listBox_caixa_caxista.TabIndex = 59;
            // 
            // button1_add_caixista
            // 
            button1_add_caixista.BackColor = Color.OliveDrab;
            button1_add_caixista.FlatStyle = FlatStyle.Popup;
            button1_add_caixista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_add_caixista.ForeColor = SystemColors.ButtonFace;
            button1_add_caixista.Location = new Point(635, 457);
            button1_add_caixista.Margin = new Padding(5, 3, 3, 3);
            button1_add_caixista.Name = "button1_add_caixista";
            button1_add_caixista.Size = new Size(133, 44);
            button1_add_caixista.TabIndex = 60;
            button1_add_caixista.Text = "Adicionar";
            button1_add_caixista.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 779);
            Controls.Add(button_add_caixista);
            Controls.Add(list_empregados);
            Controls.Add(button_rem_employe);
            Controls.Add(button_add_lojista);
            Controls.Add(button_rem_client);
            Controls.Add(button_add_client);
            Controls.Add(label1);
            Controls.Add(button_inventario);
            Controls.Add(button_clientes);
            Controls.Add(button_empregados);
            Controls.Add(label_nif_rem_c);
            Controls.Add(textBox_rem_nif_c);
            Controls.Add(button_def_rem_c);
            Controls.Add(list_sec_lojista);
            Controls.Add(label_sec_lojista);
            Controls.Add(button1_add_caixista);
            Controls.Add(listBox_caixa_caxista);
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
            Controls.Add(label_add_caixista);
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
            Controls.Add(label_add_lojista);
            Controls.Add(label_rem_c);
            Name = "Welcome";
            Text = "Index";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_empregados;
        private Button button_clientes;
        private Button button_inventario;
        private Label label1;
        private Label logo;
        private Button button_add_client;
        private Button button_rem_client;
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
        private ListBox list_empregados;
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
        private ListBox list_sec_lojista;
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
        private ListBox listBox_caixa_caxista;
        private Button button1_add_caixista;
        private Label label_add_caixista;
    }
}
