using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Gimpie
{
    
    public partial class ManagerF : Form
    {
        //public static DataTable table = new DataTable("Table");
        bool IsAdminMaF;
        bool IsManagerMaF;
        //public string[] dataArray;
        public List<Supply> ProductList { get; set; }
        public ManagerF()
        {
            InitializeComponent();
        }
        public ManagerF(bool IsAdminM, bool IsManagerM)
        {
            InitializeComponent();
            IsAdminMaF = IsAdminM;
            IsManagerMaF = IsManagerM;
            ProductList = Supply.productList;
            //dataArray = new string[listItemMaF.Items.Count];

        }
        private void ManagerF_Load(object sender, EventArgs e)
        {

            foreach (var item in ProductList)
            {
                ListViewItem ListItem = new ListViewItem(item.Brand);
                ListItem.SubItems.Add(item.Type);
                ListItem.SubItems.Add(item.Size);
                ListItem.SubItems.Add(item.Color);
                ListItem.SubItems.Add(item.Quantity.ToString());
                ListItem.SubItems.Add(item.Quantity.ToString());

                listItemMaF.Items.Add(ListItem);

            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (IsAdminMaF || IsManagerMaF)
            {

                Menu menu = new Menu(IsAdminMaF, IsManagerMaF);
                
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                Menu Mform = new Menu();
                this.Hide();
                Mform.ShowDialog();
                this.Close();
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // refresh of the listItemMaF
            listItemMaF.Items.Clear();

            //make the textbox to string and int and decimal
            string brand = txtBrand.Text;
            string type = txtType.Text;
            string size = txtSize.Text;
            string color = txtColor.Text;
            int quantity = int.Parse(txtQua.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            // populate the supply string to ManagerF
                Supply NewProduct = new Supply
                {
                    Brand = brand,
                    Type = type,
                    Size = size,
                    Color = color,
                    Quantity = quantity,
                    Price = price,
                };
                //add product from textbox to list<supply>
                ProductList.Add(NewProduct);

            foreach (var item in ProductList)
            {
                ListViewItem ListItem = new ListViewItem(item.Brand);
                ListItem.SubItems.Add(item.Type);
                ListItem.SubItems.Add(item.Size);
                ListItem.SubItems.Add(item.Color);
                ListItem.SubItems.Add(item.Quantity.ToString());
                ListItem.SubItems.Add(item.Price.ToString());

                listItemMaF.Items.Add(ListItem);

            }
            txtBrand.Clear();
            txtType.Clear();
            txtSize.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtQua.Clear();
            txtBrand.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // i is equal to items index you selected both in the list<supply> and listItemMaF
            for (int i = 0; i < listItemMaF.Items.Count; i++)
            {
                if (listItemMaF.Items[i].Selected)
                {
                    listItemMaF.Items[i].Remove();
                    ProductList.RemoveAt(i);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }
    }
}
