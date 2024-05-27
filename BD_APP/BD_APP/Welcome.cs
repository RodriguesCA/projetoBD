namespace BD_APP
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            button_billing.Hide();                  // Hide Manager menu
            button_staff.Hide();
            button_new_product.Hide();

            button_add_client.Hide();               // Hide Client menu
            button_rem_client.Hide();
            button_up_client.Hide();

            button_up_employe.Hide();               // Hide Employe menu
            button_rem_employe.Hide();
            button_add_employe.Hide();

            logo.Location = new Point(285, 130);    // Logo to the middle

            billing_container.Hide();               // Hide billing
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();

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


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_manager_Click(object sender, EventArgs e)
        {
            button_billing.Show();             // Show Manager menu
            button_billing.Enabled = true;
            button_staff.Show();
            button_staff.Enabled = true;
            button_new_product.Show();
            button_new_product.Enabled = true;
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();
            billing_container.Hide();
            logo.Location = new Point(285, 130); // Logo to the middle
            button_add_client.Hide();
            button_rem_client.Hide();           // Hide Client Menu
            button_up_client.Hide();
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
            button_up_employe.Hide();           // Hide Employe Menu
            button_rem_employe.Hide();
            button_add_employe.Hide();

        }

        private void button_client_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(285, 130);        // Logo the middle
            button_up_client.Show();
            button_up_client.Enabled = true;            // Show Client Menu
            button_rem_client.Show();
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
            button_up_employe.Hide();                   // Hide Employe Menu
            button_rem_employe.Hide();
            button_add_employe.Hide();
            billing_container.Hide();
            button_new_product.Hide();                  // Hide Manager Menu
            button_billing.Hide();
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();




        }

        private void button_employe_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(285, 130);    // Logo to the middle
            button_staff.Hide();
            button_new_product.Hide();
            button_billing.Hide();                  // Hide Manager Menu
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();
            billing_container.Hide();
            button_add_client.Hide();                // Hide Client Menu
            button_rem_client.Hide();
            button_up_client.Hide();
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
            button_add_employe.Show();              // Show Employee Menu
            button_rem_employe.Show();
            button_up_employe.Show();
            button_add_employe.Enabled = true;
            button_rem_employe.Enabled = true;
            button_up_employe.Enabled = true;


        }



        private void button_billing_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(669, 130);
            n_purchases_value.Show();
            n_purchases.Show();
            revenue_value.Show();
            total_revenue.Show();
            billing_container.Show();

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
            button_billing.Hide();
            button_staff.Hide();
            button_new_product.Hide();
        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            logo.Location = new Point(285, 130);    // Logo to the middle
            Secções frm = new();
            frm.Show();
        }

        private void button_add_client_Click_1(object sender, EventArgs e)
        {
            logo.Location = new Point(669, 130);
            label_nif_c.Show();
            button_def_add_c.Show();
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
            logo.Location = new Point(669, 130);
            button_def_rem_c.Show();
            label_nif_rem_c.Show();
            textBox_rem_nif_c.Show();
            label_rem_c.Show();
            label_nif_c.Hide();
            label_nome_c.Hide();
            textBox_nif_c.Hide();
            textBox_nome_c.Hide();
            label_add_client.Hide();
        }
    }
}