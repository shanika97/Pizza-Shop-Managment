namespace Pizza_Shop_Managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(txtUn.Text=="" || txtPw.Text=="" ||!(txtUn.Text== "pizza" && txtPw.Text == "1234"))
            {
                MessageBox.Show("incorrect.!! ,try again,","Login Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string un = txtUn.Text;
                string pw = txtPw.Text;

                UserOrder pt = new UserOrder();
                    pt.Show();
                this.Hide();

                un = "";
                pw = "";

            }
        }
    }
}