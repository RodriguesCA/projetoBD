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
            button_manager = new Button();
            button_client = new Button();
            button_employe = new Button();
            label1 = new Label();
            logo = new Label();
            button_billing = new Button();
            button_staff = new Button();
            button_new_product = new Button();
            button7 = new Button();
            button_add_client = new Button();
            button_rem_client = new Button();
            button_up_client = new Button();
            billing_container = new Label();
            button_add_employe = new Button();
            button_rem_employe = new Button();
            button_up_employe = new Button();
            revenue_value = new TextBox();
            total_revenue = new Label();
            n_purchases = new Label();
            n_purchases_value = new TextBox();
            SuspendLayout();
            // 
            // button_manager
            // 
            button_manager.BackColor = Color.IndianRed;
            button_manager.FlatStyle = FlatStyle.System;
            button_manager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manager.Location = new Point(33, 24);
            button_manager.Margin = new Padding(5, 3, 3, 3);
            button_manager.Name = "button_manager";
            button_manager.Size = new Size(127, 44);
            button_manager.TabIndex = 0;
            button_manager.Text = "Manager";
            button_manager.UseVisualStyleBackColor = false;
            button_manager.Click += button_manager_Click;
            // 
            // button_client
            // 
            button_client.FlatStyle = FlatStyle.System;
            button_client.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_client.Location = new Point(177, 24);
            button_client.Name = "button_client";
            button_client.Size = new Size(126, 44);
            button_client.TabIndex = 1;
            button_client.Text = "Client";
            button_client.UseVisualStyleBackColor = true;
            button_client.Click += button_client_Click;
            // 
            // button_employe
            // 
            button_employe.FlatStyle = FlatStyle.System;
            button_employe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_employe.Location = new Point(318, 24);
            button_employe.Name = "button_employe";
            button_employe.Size = new Size(138, 44);
            button_employe.TabIndex = 2;
            button_employe.Text = "Employe";
            button_employe.UseVisualStyleBackColor = true;
            button_employe.Click += button_employe_Click;
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
            logo.Location = new Point(675, 113);
            logo.Name = "logo";
            logo.Size = new Size(596, 549);
            logo.TabIndex = 4;
            logo.Click += logo_Click;
            // 
            // button_billing
            // 
            button_billing.FlatStyle = FlatStyle.System;
            button_billing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_billing.Location = new Point(33, 113);
            button_billing.Name = "button_billing";
            button_billing.Size = new Size(149, 59);
            button_billing.TabIndex = 5;
            button_billing.Text = "Billing";
            button_billing.UseVisualStyleBackColor = true;
            button_billing.Click += button_billing_Click;
            // 
            // button_staff
            // 
            button_staff.FlatStyle = FlatStyle.System;
            button_staff.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_staff.Location = new Point(33, 190);
            button_staff.Name = "button_staff";
            button_staff.Size = new Size(149, 59);
            button_staff.TabIndex = 6;
            button_staff.Text = "Manage Staff";
            button_staff.UseVisualStyleBackColor = true;
            // 
            // button_new_product
            // 
            button_new_product.FlatStyle = FlatStyle.System;
            button_new_product.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_new_product.Location = new Point(33, 270);
            button_new_product.Name = "button_new_product";
            button_new_product.Size = new Size(149, 59);
            button_new_product.TabIndex = 7;
            button_new_product.Text = "New Product";
            button_new_product.UseVisualStyleBackColor = true;
            button_new_product.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(1024, 24);
            button7.Margin = new Padding(5, 3, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(127, 44);
            button7.TabIndex = 8;
            button7.Text = "Close";
            button7.UseVisualStyleBackColor = false;
            // 
            // button_add_client
            // 
            button_add_client.FlatStyle = FlatStyle.System;
            button_add_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_client.Location = new Point(33, 113);
            button_add_client.Name = "button_add_client";
            button_add_client.Size = new Size(149, 59);
            button_add_client.TabIndex = 9;
            button_add_client.Text = "Add Client";
            button_add_client.UseVisualStyleBackColor = true;
            // 
            // button_rem_client
            // 
            button_rem_client.FlatStyle = FlatStyle.System;
            button_rem_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rem_client.Location = new Point(33, 190);
            button_rem_client.Name = "button_rem_client";
            button_rem_client.Size = new Size(149, 59);
            button_rem_client.TabIndex = 10;
            button_rem_client.Text = "Remove Client";
            button_rem_client.UseVisualStyleBackColor = true;
            // 
            // button_up_client
            // 
            button_up_client.FlatStyle = FlatStyle.System;
            button_up_client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_up_client.Location = new Point(33, 270);
            button_up_client.Name = "button_up_client";
            button_up_client.Size = new Size(149, 59);
            button_up_client.TabIndex = 11;
            button_up_client.Text = "Update Client";
            button_up_client.UseVisualStyleBackColor = true;
            // 
            // billing_container
            // 
            billing_container.BackColor = Color.WhiteSmoke;
            billing_container.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            billing_container.Location = new Point(243, 113);
            billing_container.Name = "billing_container";
            billing_container.Size = new Size(450, 400);
            billing_container.TabIndex = 12;
            billing_container.Text = "Billing";
            // 
            // button_add_employe
            // 
            button_add_employe.FlatStyle = FlatStyle.System;
            button_add_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_employe.Location = new Point(33, 113);
            button_add_employe.Name = "button_add_employe";
            button_add_employe.Size = new Size(149, 59);
            button_add_employe.TabIndex = 13;
            button_add_employe.Text = "Add Employe";
            button_add_employe.UseVisualStyleBackColor = true;
            // 
            // button_rem_employe
            // 
            button_rem_employe.FlatStyle = FlatStyle.System;
            button_rem_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rem_employe.Location = new Point(33, 190);
            button_rem_employe.Name = "button_rem_employe";
            button_rem_employe.Size = new Size(149, 59);
            button_rem_employe.TabIndex = 14;
            button_rem_employe.Text = "Remove Employe";
            button_rem_employe.UseVisualStyleBackColor = true;
            // 
            // button_up_employe
            // 
            button_up_employe.FlatStyle = FlatStyle.System;
            button_up_employe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_up_employe.Location = new Point(33, 270);
            button_up_employe.Name = "button_up_employe";
            button_up_employe.Size = new Size(149, 59);
            button_up_employe.TabIndex = 15;
            button_up_employe.Text = "Update Employe";
            button_up_employe.UseVisualStyleBackColor = true;
            // 
            // revenue_value
            // 
            revenue_value.Location = new Point(513, 430);
            revenue_value.Name = "revenue_value";
            revenue_value.Size = new Size(101, 31);
            revenue_value.TabIndex = 16;
            // 
            // total_revenue
            // 
            total_revenue.AutoSize = true;
            total_revenue.BackColor = Color.WhiteSmoke;
            total_revenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_revenue.Location = new Point(262, 430);
            total_revenue.Name = "total_revenue";
            total_revenue.Size = new Size(173, 32);
            total_revenue.TabIndex = 17;
            total_revenue.Text = "Total Revenue:";
            // 
            // n_purchases
            // 
            n_purchases.AutoSize = true;
            n_purchases.BackColor = Color.WhiteSmoke;
            n_purchases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n_purchases.Location = new Point(262, 334);
            n_purchases.Name = "n_purchases";
            n_purchases.Size = new Size(193, 32);
            n_purchases.TabIndex = 18;
            n_purchases.Text = "Nº of Purchases:";
            // 
            // n_purchases_value
            // 
            n_purchases_value.Location = new Point(513, 334);
            n_purchases_value.Name = "n_purchases_value";
            n_purchases_value.Size = new Size(101, 31);
            n_purchases_value.TabIndex = 19;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1186, 764);
            Controls.Add(n_purchases_value);
            Controls.Add(n_purchases);
            Controls.Add(total_revenue);
            Controls.Add(revenue_value);
            Controls.Add(button_up_employe);
            Controls.Add(button_rem_employe);
            Controls.Add(button_add_employe);
            Controls.Add(billing_container);
            Controls.Add(button_up_client);
            Controls.Add(button_rem_client);
            Controls.Add(button_add_client);
            Controls.Add(button7);
            Controls.Add(button_new_product);
            Controls.Add(button_staff);
            Controls.Add(button_billing);
            Controls.Add(logo);
            Controls.Add(label1);
            Controls.Add(button_employe);
            Controls.Add(button_client);
            Controls.Add(button_manager);
            Name = "Welcome";
            Text = "Index";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_manager;
        private Button button_client;
        private Button button_employe;
        private Label label1;
        private Label logo;
        private Button button_billing;
        private Button button_staff;
        private Button button_new_product;
        private Button button7;
        private Button button_add_client;
        private Button button_rem_client;
        private Button button_up_client;
        private Label billing_container;
        private Button button_add_employe;
        private Button button_rem_employe;
        private Button button_up_employe;
        private TextBox revenue_value;
        private Label total_revenue;
        private Label n_purchases;
        private TextBox n_purchases_value;
    }
}
