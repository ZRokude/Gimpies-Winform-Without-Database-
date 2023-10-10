using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Gimpie
{
    public partial class Account : Form
    {
        bool IsAdminAc;
        bool IsManagerAc;
       
        public Account ()
        {
            InitializeComponent();
            
        }
        public Account(bool IsAdminM, bool IsManagerM)
        {
            InitializeComponent();
            IsAdminAc = IsAdminM;
            IsManagerAc = IsManagerM;

            
        }
        
        private void Account_Load_1(object sender, EventArgs e)
        {
            if (IsAdminAc)
            {
                lblPermS.Visible = true;
                
                lblPermS.Text = "Permission: Administrator"; lblName.Text = "Name: Admin ";
            }
            else if (IsManagerAc)
            {
                lblPermS.Visible = true;
                lblPermS.Text = "Permission: Manager"; lblName.Text = "Name: Manager ";
            }
            else
            {
                lblPermS.Visible = true;
                lblPermS.Text = "Permission: Sales Management"; lblName.Text = "Name: Sales";
            }
        }
        //private void Account_Load(object sender, EventArgs e)

        //{

        //    //if (IsAdminAc)
        //    //{
        //    //    if(lblPermA.Visible == false)
        //    //    {

        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    if (lblPermS.Visible == false)
        //    //    {
        //    //        lblPermS.Visible = true;
        //    //    }
        //    //}
        //}
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (IsAdminAc || IsManagerAc)
            {
                Menu menu = new Menu(IsAdminAc, IsManagerAc);
                this.Hide();
                menu.ShowDialog();
                this.Close();

                //if (ProductListMen.Count >= 1)
                //{
                //    Menu Mform = new Menu(ProductListMen);
                //    this.Hide();
                //    Mform.ShowDialog();
                //    this.Close();
                //}
                //else
                //{
                //    Menu menu = new Menu(IsAdminAc, IsManagerAc);
                //    this.Hide();
                //    menu.ShowDialog();
                //    this.Close();
                //}

            }
            else
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();

                //if (ProductListMen.Count >= 1)
                //{
                //    Menu Mform = new Menu(ProductListMen);
                //    this.Hide();
                //    Mform.ShowDialog();
                //    this.Close();
                //}
                //else
                //{
                //    Menu menu = new Menu();
                //    this.Hide();
                //    menu.ShowDialog();
                //    this.Close();
                //}
                
            }

        }

        private void NameS_Click(object sender, EventArgs e)
        {

        }

        private void Perm_Click(object sender, EventArgs e)
        {

        }

        private void createD_Click(object sender, EventArgs e)
        {

        }

        private void AccI_Click(object sender, EventArgs e)
        {

        }
    }
}
