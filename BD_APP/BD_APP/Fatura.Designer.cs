namespace BD_APP
{
    partial class Fatura
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
            label_title = new Label();
            button_ok = new Button();
            label_nome_cliente = new Label();
            label_nif = new Label();
            label_caixa = new Label();
            label_nome_employe = new Label();
            label_n_employe = new Label();
            label_produtos = new Label();
            label_total = new Label();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(152, 25);
            label_title.Name = "label_title";
            label_title.Size = new Size(134, 51);
            label_title.TabIndex = 0;
            label_title.Text = "Fatura";
            // 
            // button_ok
            // 
            button_ok.BackColor = Color.OliveDrab;
            button_ok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ok.Location = new Point(164, 508);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(112, 34);
            button_ok.TabIndex = 1;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = false;
            // 
            // label_nome_cliente
            // 
            label_nome_cliente.AutoSize = true;
            label_nome_cliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome_cliente.Location = new Point(12, 117);
            label_nome_cliente.Name = "label_nome_cliente";
            label_nome_cliente.Size = new Size(131, 25);
            label_nome_cliente.TabIndex = 2;
            label_nome_cliente.Text = "Nome Cliente:";
            // 
            // label_nif
            // 
            label_nif.AutoSize = true;
            label_nif.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nif.Location = new Point(12, 155);
            label_nif.Name = "label_nif";
            label_nif.Size = new Size(44, 25);
            label_nif.TabIndex = 3;
            label_nif.Text = "NIF:";
            // 
            // label_caixa
            // 
            label_caixa.AutoSize = true;
            label_caixa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_caixa.Location = new Point(12, 191);
            label_caixa.Name = "label_caixa";
            label_caixa.Size = new Size(59, 25);
            label_caixa.TabIndex = 4;
            label_caixa.Text = "Caixa:";
            // 
            // label_nome_employe
            // 
            label_nome_employe.AutoSize = true;
            label_nome_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nome_employe.Location = new Point(12, 232);
            label_nome_employe.Name = "label_nome_employe";
            label_nome_employe.Size = new Size(142, 25);
            label_nome_employe.TabIndex = 5;
            label_nome_employe.Text = "Nome do Caixa:";
            // 
            // label_n_employe
            // 
            label_n_employe.AutoSize = true;
            label_n_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_n_employe.Location = new Point(12, 274);
            label_n_employe.Name = "label_n_employe";
            label_n_employe.Size = new Size(138, 25);
            label_n_employe.TabIndex = 6;
            label_n_employe.Text = "Nº Empregado:";
            // 
            // label_produtos
            // 
            label_produtos.AutoSize = true;
            label_produtos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_produtos.Location = new Point(16, 319);
            label_produtos.Name = "label_produtos";
            label_produtos.Size = new Size(93, 25);
            label_produtos.TabIndex = 7;
            label_produtos.Text = "Produtos:";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total.Location = new Point(16, 361);
            label_total.Name = "label_total";
            label_total.Size = new Size(105, 25);
            label_total.TabIndex = 8;
            label_total.Text = "Valor Pago:";
            // 
            // Fatura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 565);
            Controls.Add(label_total);
            Controls.Add(label_produtos);
            Controls.Add(label_n_employe);
            Controls.Add(label_nome_employe);
            Controls.Add(label_caixa);
            Controls.Add(label_nif);
            Controls.Add(label_nome_cliente);
            Controls.Add(button_ok);
            Controls.Add(label_title);
            Name = "Fatura";
            Text = "Fatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Button button_ok;
        private Label label_nome_cliente;
        private Label label_nif;
        private Label label_caixa;
        private Label label_nome_employe;
        private Label label_n_employe;
        private Label label_produtos;
        private Label label_total;
    }
}