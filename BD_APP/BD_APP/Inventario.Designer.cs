namespace BD_APP
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_produto = new Button();
            button_armazem = new Button();
            dataGridView_produtos = new DataGridView();
            panel_produtos = new Panel();
            button_encomendar = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            encomendar = new TextBox();
            label2 = new Label();
            button_restock = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            restock = new TextBox();
            dataGridView_armazem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).BeginInit();
            panel_produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_armazem).BeginInit();
            SuspendLayout();
            // 
            // button_produto
            // 
            button_produto.Location = new Point(36, 24);
            button_produto.Name = "button_produto";
            button_produto.Size = new Size(183, 46);
            button_produto.TabIndex = 0;
            button_produto.Text = "Produtos";
            button_produto.UseVisualStyleBackColor = true;
            button_produto.Click += button_produto_Click;
            // 
            // button_armazem
            // 
            button_armazem.Location = new Point(281, 24);
            button_armazem.Name = "button_armazem";
            button_armazem.Size = new Size(183, 46);
            button_armazem.TabIndex = 1;
            button_armazem.Text = "Armazém";
            button_armazem.UseVisualStyleBackColor = true;
            button_armazem.Click += button_armazem_Click;
            // 
            // dataGridView_produtos
            // 
            dataGridView_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_produtos.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_produtos.Location = new Point(513, 24);
            dataGridView_produtos.Name = "dataGridView_produtos";
            dataGridView_produtos.RowHeadersWidth = 82;
            dataGridView_produtos.Size = new Size(814, 638);
            dataGridView_produtos.TabIndex = 2;
            // 
            // panel_produtos
            // 
            panel_produtos.Controls.Add(button_encomendar);
            panel_produtos.Controls.Add(textBox3);
            panel_produtos.Controls.Add(label4);
            panel_produtos.Controls.Add(textBox2);
            panel_produtos.Controls.Add(label3);
            panel_produtos.Controls.Add(comboBox2);
            panel_produtos.Controls.Add(encomendar);
            panel_produtos.Controls.Add(label2);
            panel_produtos.Controls.Add(button_restock);
            panel_produtos.Controls.Add(comboBox1);
            panel_produtos.Controls.Add(label1);
            panel_produtos.Controls.Add(restock);
            panel_produtos.Location = new Point(36, 128);
            panel_produtos.Name = "panel_produtos";
            panel_produtos.Size = new Size(428, 534);
            panel_produtos.TabIndex = 3;
            // 
            // button_encomendar
            // 
            button_encomendar.BackColor = SystemColors.GradientInactiveCaption;
            button_encomendar.FlatAppearance.BorderSize = 0;
            button_encomendar.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button_encomendar.Location = new Point(229, 476);
            button_encomendar.Name = "button_encomendar";
            button_encomendar.Size = new Size(176, 46);
            button_encomendar.TabIndex = 11;
            button_encomendar.Text = "Encomendar";
            button_encomendar.UseVisualStyleBackColor = false;
            button_encomendar.Click += button_encomendar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 420);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(27, 419);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 9;
            label4.Text = "Unidades:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 353);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 39);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(27, 352);
            label3.Name = "label3";
            label3.Size = new Size(105, 37);
            label3.TabIndex = 7;
            label3.Text = "Secção:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 286);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 40);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // encomendar
            // 
            encomendar.BackColor = SystemColors.Control;
            encomendar.BorderStyle = BorderStyle.None;
            encomendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encomendar.ForeColor = SystemColors.ActiveCaptionText;
            encomendar.Location = new Point(17, 223);
            encomendar.Name = "encomendar";
            encomendar.Size = new Size(388, 43);
            encomendar.TabIndex = 5;
            encomendar.Text = "Encomendar Produtos";
            encomendar.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(27, 285);
            label2.Name = "label2";
            label2.Size = new Size(111, 37);
            label2.TabIndex = 4;
            label2.Text = "Código:";
            // 
            // button_restock
            // 
            button_restock.BackColor = SystemColors.GradientInactiveCaption;
            button_restock.FlatAppearance.BorderSize = 0;
            button_restock.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button_restock.Location = new Point(255, 141);
            button_restock.Name = "button_restock";
            button_restock.Size = new Size(150, 46);
            button_restock.TabIndex = 3;
            button_restock.Text = "Restock";
            button_restock.UseVisualStyleBackColor = false;
            button_restock.Click += button_restock_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 40);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(27, 78);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // restock
            // 
            restock.BackColor = SystemColors.Control;
            restock.BorderStyle = BorderStyle.None;
            restock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restock.ForeColor = SystemColors.ActiveCaptionText;
            restock.Location = new Point(17, 16);
            restock.Name = "restock";
            restock.Size = new Size(388, 43);
            restock.TabIndex = 0;
            restock.Text = "Restock de Produtos";
            restock.TextChanged += gestão_produtos_TextChanged;
            // 
            // dataGridView_armazem
            // 
            dataGridView_armazem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_armazem.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_armazem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_armazem.Location = new Point(513, 24);
            dataGridView_armazem.Name = "dataGridView_armazem";
            dataGridView_armazem.RowHeadersWidth = 82;
            dataGridView_armazem.Size = new Size(917, 638);
            dataGridView_armazem.TabIndex = 4;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 684);
            Controls.Add(dataGridView_armazem);
            Controls.Add(panel_produtos);
            Controls.Add(dataGridView_produtos);
            Controls.Add(button_armazem);
            Controls.Add(button_produto);
            Margin = new Padding(4);
            Name = "Inventario";
            Text = "Inventário";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).EndInit();
            panel_produtos.ResumeLayout(false);
            panel_produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_armazem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_produto;
        private Button button_armazem;
        private DataGridView dataGridView_produtos;
        private Panel panel_produtos;
        private TextBox restock;
        private Label label1;
        private ComboBox comboBox1;
        private Button button_restock;
        private TextBox encomendar;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox2;
        private Button button_encomendar;
        private TextBox textBox3;
        private DataGridView dataGridView_armazem;
    }
}