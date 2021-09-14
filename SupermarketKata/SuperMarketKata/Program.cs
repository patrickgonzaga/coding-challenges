using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Program Name: SupermarketKata
Date: September 14, 2021
Using either C# or F# and a TDD approach, spent no more than two hours on your solution. There should be an emphasis on clean coding principles.

Requirements
Supermarket items are identified using Stock Keeping Units, or SKUs. In our store, we will use letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multi-priced: buy N of them, and they will cost you Y pence.

For example, item A might cost 50 individually, but this week we have a special offer: buy three As and they’ll cost you 130.

Example items
SKU	Unit Price	Special Price
A	50	3 for 130
B	30	2 for 45
C	20	
D	15	
The checkout accepts items in any order, so that if we scan a B, an A, and another B, we will recognize the two Bs and price them at 45 (for a total price so far of 95). The pricing changes frequently, so pricing should be independent of the checkout. The interface to the checkout could look like:

interface ICheckout
{
    void Scan(string item);
    int GetTotalPrice();
}
*/

namespace SuperMarketKata
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOut POS = new CheckOut();

            Console.WriteLine("Please Start Scanning Products and press Enter: ");
            Console.WriteLine("Press ENTER twice to get Total");
            string scaninput = Console.ReadLine().ToUpper();
            while (!string.IsNullOrEmpty(scaninput))
            {
                POS.Scan(scaninput);
                scaninput = Console.ReadLine().ToUpper();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total: {0}", POS.GetTotalPrice().ToString());
            Console.ReadLine();
        }
    }
}
