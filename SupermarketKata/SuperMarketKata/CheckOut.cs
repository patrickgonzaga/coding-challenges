using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/* Class Name: CheckOut
 * Description: Handles Scanning and putting of Items in Cart and Compute Total Price.
 */

namespace SuperMarketKata
{
    public class CheckOut: ICheckOut
    {
        ItemInventory myDB;
        List<ProductItem> cart;

        public CheckOut()
        {
            myDB = new ItemInventory();
            cart = new List<ProductItem>();
        }

        public void Scan(string item)
        {
            DataRow[] myRow = myDB.GetSKUDetail(item);

            if (myRow.Length > 0)
            {
                ProductItem pItem = new ProductItem(item, myDB);
                var exists = cart.FirstOrDefault(x => x.SKU == item);
                if (exists != null)
                {
                    exists.Quantity++;
                }
                else
                    cart.Add(pItem);
            }
            else
            {
                Console.WriteLine("Sorry, " + item + " is a new delivery cannot add to cart");
            }                   
        }

        public int GetTotalPrice()
        {
            int total = 0;
            foreach (ProductItem p in cart)
            {
                Console.WriteLine("SKU     QTY     Amount");
                Console.WriteLine(p.SKU.ToString() + "        " + p.Quantity.ToString() + "        " + p.GetAmount().ToString());
                total += p.GetAmount();
            }
            return total;
        }

    }
}
