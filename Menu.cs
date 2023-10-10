using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Winform_Gimpie
{
    public partial class Menu : Form
    {
        public const string messageC = "Are you sure want to proceed?";
        public const string Title = "Gimpies";
        bool IsAdminM; // Admin data
        bool IsManagerM; // Manager data
        public List<Supply> ProductListMen{ get; set; }
       
        public Menu()
        {

            InitializeComponent();

        }
        
        public Menu(bool isAdmin, bool isManager)
        {
            InitializeComponent();
            
            IsAdminM = isAdmin;

            IsManagerM = isManager;

            ProductListMen = Supply.productList;
            //ListItemMen.Items.AddRange(itemsMaF.ToArray());
            //ListItemMen.Items.AddRange((from ListViewItem item in ListItemMen.Items select (ListViewItem)item.Clone()).ToArray());

        }
       
       
        private void Menu_Load(object sender, EventArgs e)
        {
            if (ProductListMen.Count > 0)
            {
                foreach (var item in ProductListMen)
                {
                    ListViewItem ListItem = new ListViewItem(item.Brand);
                    ListItem.SubItems.Add(item.Type);
                    ListItem.SubItems.Add(item.Size);
                    ListItem.SubItems.Add(item.Color);
                    ListItem.SubItems.Add(item.Quantity.ToString());
                    ListItem.SubItems.Add(item.Price.ToString());

                    ListItemMen.Items.Add(ListItem);

                }
            }


        }

        private void btnLogO_Click(object sender, EventArgs e)
        {

            var LogO = MessageBox.Show(messageC, Title,
                            MessageBoxButtons.OKCancel);
            
            if (LogO == DialogResult.OK)
            {
                Login FForm = new Login();
                this.Hide();
                FForm.ShowDialog();
                this.Close();

            }
        }

        public void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            //public static bool IsAdminM = IsAdminL;
            //public static bool IsManagerM = IsManagerL;
            Account AdForm = new Account(IsAdminM, IsManagerM);
            this.Hide();
            AdForm.ShowDialog();
            this.Close();
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
       
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (IsAdminM)
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false && btnAdmin.Visible == false && btnM.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true; btnAdmin.Visible = true; btnM.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true && btnAdmin.Visible == true && btnM.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false; btnAdmin.Visible = false; btnM.Visible = false;
                }
            }
            else if (IsManagerM)
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false && btnM.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true; btnM.Visible = true; btnM.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true && btnM.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false; btnAdmin.Visible = false; btnM.Visible = false;
                }
            }
            else
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false;
                }

            }
           
        }

        private void btnM_Click(object sender, EventArgs e)
        {

            ManagerF ManagerForm = new ManagerF(IsAdminM, IsManagerM) ;
            this.Hide();
            ManagerForm.ShowDialog();
            this.Close();
        }

        private void listItemMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int OutputValue = 0;
            if (ListItemMen.SelectedItems.Count > 0 && int.TryParse(ValueMen.Text, out OutputValue))
            {
                // to prevent textbox is 0 or empty and not selected
                
                if (ProductListMen[ListItemMen.SelectedItems[0].Index].Quantity - int.Parse(ValueMen.Text) >= 0)
                {
                    ProductListMen[ListItemMen.SelectedItems[0].Index].Quantity = ProductListMen[ListItemMen.SelectedItems[0].Index].Quantity - int.Parse(ValueMen.Text);
                    ListItemMen.Items.Clear();
                    foreach (var item in ProductListMen)
                    {
                        ListViewItem ListItem = new ListViewItem(item.Brand);
                        ListItem.SubItems.Add(item.Type);
                        ListItem.SubItems.Add(item.Size);
                        ListItem.SubItems.Add(item.Color);
                        ListItem.SubItems.Add(item.Quantity.ToString());
                        ListItem.SubItems.Add(item.Price.ToString());

                        ListItemMen.Items.Add(ListItem);

                    }
                }
                else
                {
                    MessageBox.Show("THE ITEM YOU HAVE IS EXCEEDED THE NUMBER OF QUANTITY");
                }
            }
            else
            {
                
                MessageBox.Show("PLEASE PUT THE RIGHT NUMBER OR SELECT THE ITEM!");
            }
        }

        private void ValueMen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListItemMen_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
