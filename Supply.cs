using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Gimpie
{
    public class Supply
    {
        

        public string Brand { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public static List<Supply> productList = new List<Supply>();
        //public  static List<Shoes>subItem { get; set; }










        //public static List<string[]> shoes = new List<string[]>();
        //public static void AddShoe(string Brand, string Type, string Size, string Color, string Quantity, string Price)
        //{
        //    shoes.Add(new string[] { Brand, Type, Size, Color, Quantity, Price });
        //}





        //public static list<string[]> shoes = new list<string[]>();

        //public static void AddShoe(string brand, string type, string size, string colour, string quantity, string price);
        //{
        //    shoes.Add(new string[] { brand, type, size, colour, quantity, price});
        //}
    }
}
