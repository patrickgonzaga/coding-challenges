using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/* Class Name: ItemInveotry
 * Description: Using DataTable to store the Items, Price, and Special Offer Quantity and Price.
 */

namespace SuperMarketKata
{
    public class ItemInventory
    {
        DataTable smDB;

        public ItemInventory()
        {
            smDB = new DataTable();
            smDB.Clear();
            smDB.Columns.Add("SKU");
            smDB.Columns.Add("UnitPrice");
            smDB.Columns.Add("SpecialPriceUnit");
            smDB.Columns.Add("SpecialPrice");
            DataRow drow = smDB.NewRow();
            drow["SKU"] = "A";
            drow["UnitPrice"] = 50;
            drow["SpecialPriceUnit"] = 3;
            drow["SpecialPrice"] = 130;
            smDB.Rows.Add(drow);

            drow = smDB.NewRow();
            drow["SKU"] = "B";
            drow["UnitPrice"] = 30;
            drow["SpecialPriceUnit"] = 2;
            drow["SpecialPrice"] = 45;
            smDB.Rows.Add(drow);

            drow = smDB.NewRow();
            drow["SKU"] = "C";
            drow["UnitPrice"] = 20;
            drow["SpecialPriceUnit"] = 0;
            drow["SpecialPrice"] = 0;
            smDB.Rows.Add(drow);

            drow = smDB.NewRow();
            drow["SKU"] = "D";
            drow["UnitPrice"] = 15;
            drow["SpecialPriceUnit"] = 0;
            drow["SpecialPrice"] = 0;
            smDB.Rows.Add(drow);
        }
    
        public DataRow[] GetSKUDetail(string sku)
        {
            DataRow[] found = smDB.Select("SKU='" + sku + "'");
            return found;
        }

    }
}
