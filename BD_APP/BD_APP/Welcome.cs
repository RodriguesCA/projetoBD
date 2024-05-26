namespace BD_APP
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            button_billing.Hide();
            button_staff.Hide();
            button_new_product.Hide();
            button_add_client.Hide();
            button_rem_client.Hide();
            button_up_client.Hide();
            button_up_employe.Hide();
            button_rem_employe.Hide();
            button_add_employe.Hide();
            logo.Location = new Point(285, 130);    // Logo to the middle
            billing_container.Hide();
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();
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
            billing_container.Hide();
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
            // Hide Manager Menu
            button_billing.Hide();
            n_purchases.Hide();
            n_purchases_value.Hide();
            revenue_value.Hide();
            total_revenue.Hide();
            billing_container.Hide();
            button_add_client.Hide();
            button_rem_client.Hide();               // Hide Client Menu
            button_up_client.Hide();
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
            Secções frm = new();
            frm.Show();
        }
    }
}