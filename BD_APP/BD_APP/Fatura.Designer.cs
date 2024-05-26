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
            // Fatura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 565);
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
    }
}