using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using System.Data.SqlClient;



namespace Pizza_Shop_Managment
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();

            
        }

      
        string size = "";
        string eattype = "";
        string category = "";
        string choice = "";

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 fm =new Form1();
            fm.Show();
           Hide(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /* cmbCategory.Items.Add("Classic");
             cmbCategory.Items.Add("Signature");
             cmbCategory.Items.Add("Favourite");
             cmbCategory.Items.Add("Supreme");
             */
             
        }

        private void lstBoxchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = lstBoxchoice.GetItemText(lstBoxchoice.SelectedItem);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxchoice.Items.Clear();
           string category = cmbCategory.Text;
             
            if (cmbCategory.Text == "Classic")
            {
                lstBoxchoice.Items.Add("Devilled Chicken");
                lstBoxchoice.Items.Add("Cheese Lovers");
                lstBoxchoice.Items.Add("Tandoori Chicken");
                lstBoxchoice.Items.Add("Sausage Delight");
            }
            else if (cmbCategory.Text == "Signature")
            {
                lstBoxchoice.Items.Add("Spicy Veggie");
                lstBoxchoice.Items.Add("Black Chicken");
                lstBoxchoice.Items.Add("BBQ Chicken");
                lstBoxchoice.Items.Add("Chicken Hawaiian");
                lstBoxchoice.Items.Add("Chicken Masala");
                lstBoxchoice.Items.Add("Cheese Fiesta");
                lstBoxchoice.Items.Add("Spicy Chicken");
            }
            else if (cmbCategory.Text == "Favourite")
            {
                lstBoxchoice.Items.Add("Sri Lankan Spicy");
                lstBoxchoice.Items.Add("Butter Cuttlefish");
                lstBoxchoice.Items.Add("Prawn with Chicken");
                lstBoxchoice.Items.Add("Veggie Supreme");
                lstBoxchoice.Items.Add("Beef Pepperoni");
                lstBoxchoice.Items.Add("Meat Lovers");
            }
            else if (cmbCategory.Text == "Supreme")
            {
                lstBoxchoice.Items.Add("Chicken Treat");
                lstBoxchoice.Items.Add("Garlic Prawns");
                lstBoxchoice.Items.Add("Spicy Seafood");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsubmitorder_Click(object sender, EventArgs e)
        {
            if (txtcontac.Text == "" || txtdate.Text == "" || txtName.Text == "" || txtOrderId.Text == "")
            {

                MessageBox.Show("Fill all require blanks (*) ,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                int contac=Convert.ToInt32(txtcontac.Text);
                string Date = txtdate.Text;
                string name=txtName.Text;
                string orderid=txtOrderId.Text;


                double topingcost = 0;
                if (chkCheese.Checked)
                {
                    topingcost = 80;
                }
                else if (chkMushrooms.Checked)
                {
                    topingcost = 40;
                }
                else if (chkOnions.Checked)
                {
                    topingcost = 40;

                }
                else if (chksosages.Checked)
                {
                    topingcost = 60;

                }
                
          

                double categorycost = 0;
                double servicecost = 0;
              
                double totalcost = 0;


                double sizepizza = 0;
                if (size == "Small")
                {
                    sizepizza = 1;
                }
                else if (size == "Medium")
                {
                    //size cost=140/100=1.4
                    sizepizza = 1.4;
                }
                else if (size == "Large")
                {
                    sizepizza = 1.8;
                }


                if (category == "Classic")
                {
                    categorycost = 850;
                }
                else if (category == "Signature")
                {
                    categorycost = 780;
                }
                else if (category == "Favourite")
                {
                    categorycost = 950;
                }
                else if (category == "Supreme")
                {
                    categorycost = 1030;
                }

                if (eattype == "Delivery")
                {
                    servicecost = 200;
                }
               

                
                totalcost = (categorycost * sizepizza)  + servicecost + topingcost;


                //connection


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\course\\c#\\course assignment\\Pizza Shop\\Pizza Shop Managment\\Pizza Shop Managment\\OrderDB.mdf\";Integrated Security=True");
                sc.Open();

                //insertto values tables 

                SqlCommand cmd = new SqlCommand("insert into student( OrderID, Name, ContacNo, Date, Pizzatype, Size, Taken, Cost)values (@OrderID, @Name ,@ContacNo,@Date,@Pizzatype,@Size,@Taken,@Cost)", sc);
                
                cmd.ExecuteNonQuery();


                labelstatus.Text = "Raw Data Deleted Successfully...";



                txtcontac.Text = "";
                name = "";
                Date = "";
                orderid = "";

                OrderDetails od = new OrderDetails();
                od.Show();
                this.Hide();

                sc.Close();

            }





        }

        private void rdbsmall_CheckedChanged(object sender, EventArgs e)
        {
            size = rdbsmall.Text;
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            size = rdbMedium.Text;
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            size = rdbLarge.Text;
        }

        private void rdbTake_CheckedChanged(object sender, EventArgs e)
        {
            eattype= rdbTake.Text;
        }

        private void rdbDine_CheckedChanged(object sender, EventArgs e)
        {
            eattype= rdbDine.Text;
        }

        private void rdbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            eattype= rdbDelivery.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
            txtcontac.Text = "";
            txtdate.Text = "";
            txtName.Text = "";
            txtOrderId.Text = "";
           



        }

        private void UserOrder_Load(object sender, EventArgs e)
        {

        }

        private void labelstatus_Click(object sender, EventArgs e)
        {

        }
    }
    }

