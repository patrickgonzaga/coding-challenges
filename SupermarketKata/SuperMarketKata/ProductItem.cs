using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/* Class Name: ProductItem
 * Description: Check the Item and get the amount based on the special price quantity / unit price quantity
 */

namespace SuperMarketKata
{
    public class ProductItem
    {
        public int Quantity { get; set; }
        public string SKU { get; set; }
        ItemInventory myDB;

        public ProductItem(string item, ItemInventory db)
        {
            Quantity = 0;
            SKU = "";
            myDB = db;
            SKU = item;
            Quantity = 1;
        }

        public int GetAmount()
        {
            DataRow[] myRow = myDB.GetSKUDetail(SKU);

            if ((int.Parse(myRow[0]["SpecialPriceUnit"].ToString()) == 0) || (Quantity < int.Parse(myRow[0]["SpecialPriceUnit"].ToString())))
                return (Quantity * int.Parse(myRow[0]["UnitPrice"].ToString()));
            else
            {
                int NoDiscountItems = Quantity  % int.Parse(myRow[0]["SpecialPriceUnit"].ToString());
                int DiscountItems = (Quantity - NoDiscountItems) / int.Parse(myRow[0]["SpecialPriceUnit"].ToString());

                int  amount = DiscountItems * int.Parse(myRow[0]["SpecialPrice"].ToString());
                if (NoDiscountItems > 0)
                    amount += NoDiscountItems * int.Parse(myRow[0]["UnitPrice"].ToString());

                return amount;
            }
        }

    }
}
