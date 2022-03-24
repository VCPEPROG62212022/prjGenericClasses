using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGenericClasses
{
    public class ProductItems<T>
    {
        private static object[] ItemID;
        private static object[] ItemName;
        private static object[] ItemPrice;
        private static int x = 0;

        public ProductItems(int size)
        {
            ItemID = new object[size];
            ItemName = new object[size];
            ItemPrice = new object[size];
        }

        public void Push(object idItem,object nameItem,
            object priceItem)
        {
            ItemID[x] = idItem;
            ItemName[x] = nameItem;
            ItemPrice[x] = priceItem;
            x++;
        }

        public object Display()
        {
            object strDisplay = "";
            for (int i = 0; i < x; i++)
            {
                strDisplay += "Item ID: " + ItemID[i] + "\n" +
                    "Item Name :" + ItemName[i] + "\n" +
                    "Item Price :" + ItemPrice[i] + "\n\n";
            }
            return strDisplay;
        }


    }
}
