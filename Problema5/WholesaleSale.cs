using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalcularTotal()
        {
            return base.GetAmount() * 0.9m;
        }
    }
}
