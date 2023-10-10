using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Gimpie
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Supply.AddShoe("Nike", "Air Force", "44", "Black", "30", "100");
            Supply NewProduct = new Supply
            {
                Brand = "Nike",
                Type = "AirForce",
                Size = "42",
                Color = "Black",
                Quantity = 50,
                Price = 100,
            };
            Supply NewProduct2 = new Supply
            {
                Brand = "Adidas",
                Type = "One",
                Size = "43",
                Color = "White",
                Quantity = 100,
                Price = 200,
            };
            Supply.productList.Add(NewProduct);
            Supply.productList.Add(NewProduct2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
