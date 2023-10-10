using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Gimpie
{
    public partial class Login : Form
    {
        //public static string userManager = "Manager";
        //public static string passManager = "manager";
        //public static string userVerkoper = "Verkoop";
        //public static  string passVerkoper = "verkoper";
        //  Per user een array maken.
        //  Eerste record, ook in de database is vaak de admin.
        string[] AdminLoginData = { "admin", "admin" };
        string[] SalesPersonData = { "sales", "sales"};
        string[] ManagerLoginData = { "manager", "manager" };
        int loginattempts = 0;
        public const string messageC = "Are you sure want to proceed?";
        public const string Title = "Gimpies";
        List<Supply> ProductListLog = Supply.productList;
        
        public Login()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        

        private void W_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        public void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            if ((usernameInput.Text == AdminLoginData[0] && passwordInput.Text == AdminLoginData[1]) || (usernameInput.Text == SalesPersonData[0] && passwordInput.Text == SalesPersonData[1]
                || usernameInput.Text == ManagerLoginData[0] && passwordInput.Text == ManagerLoginData[1]))
            {
                //if (usernameInput.Text == userName[0] && passwordInput.Text == pass[0])
                //{
                //    MessageBox.Show("Login successful!");
                //    Menu Mform = new Menu();
                //    this.Hide();
                //    Mform.ShowDialog();
                //    this.Close();

                //}
                //if (usernameInput.Text == userName[1] && passwordInput.Text == pass[1])
                //{
                //    MessageBox.Show("Login successful!");
                //    Menu Mform = new Menu(usernameInput.Text);
                //    this.Hide();
                //    Mform.ShowDialog();
                //    this.Close();
                //}
                MessageBox.Show("Login successful!");
                bool isAdmin = usernameInput.Text == AdminLoginData[0] && passwordInput.Text == AdminLoginData[1];
                bool isManager = usernameInput.Text == ManagerLoginData[0] && passwordInput.Text == ManagerLoginData[1];
                bool isSales = usernameInput.Text == SalesPersonData[0] && passwordInput.Text == SalesPersonData[1];
                if (isAdmin || isManager)
                {
                    Menu Mform = new Menu(isAdmin, isManager);
                    this.Hide();
                    Mform.ShowDialog();
                    this.Close();
                    //Statement ProductList
                    //if (ProductListMen.Count > 0)
                    //{
                    //    Menu Mform = new Menu(isAdmin, isManager, ProductListMen);
                    //    this.Hide();
                    //    Mform.ShowDialog();
                    //    this.Close();
                    //}
                    //else
                    //{
                    //    Menu Mform = new Menu(isAdmin, isManager);
                    //    this.Hide();
                    //    Mform.ShowDialog();
                    //    this.Close();
                    //}
                }


                else
                {
                    Menu Mform = new Menu();
                    this.Hide();
                    Mform.ShowDialog();
                    this.Close();
                    //Statement productList
                    //if (ProductListMen.Count >= 0)
                    //{
                    //    Menu Mform = new Menu(ProductListMen);
                    //    this.Hide();
                    //    Mform.ShowDialog();
                    //    this.Close();
                    //}
                    //else
                    //{
                    //    Menu Mform = new Menu();
                    //    this.Hide();
                    //    Mform.ShowDialog();
                    //    this.Close();
                    //}

                }
                //else if(isManager)
                //{
                //    Menu Mform = new Menu(isManager);
                //    this.Hide();
                //    Mform.ShowDialog();
                //    this.Close();
                //}


            }
            else if (loginattempts >= 3)
            {
                MessageBox.Show("You've tried more than 3 times, wait for 10 minutes to try to login again.");
                btnLogin.Refresh();
                btnLogin.Enabled = false;
                await Task.Delay(60000);
                btnLogin.Enabled = true;


            }

            else
            {
                loginattempts++;
                MessageBox.Show("Username or Password doesn't matched", "Gimpies");
            }
            

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            var LogO = MessageBox.Show(messageC, Title,
                             MessageBoxButtons.OKCancel);
            
            if (LogO == DialogResult.OK)
            {
               Environment.Exit(0);
            }
            
        }
    }
}
