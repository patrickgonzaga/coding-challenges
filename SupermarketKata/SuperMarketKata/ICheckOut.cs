﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMarketKata
{
    interface ICheckOut
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
