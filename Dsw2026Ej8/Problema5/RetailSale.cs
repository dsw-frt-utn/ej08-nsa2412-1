using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class RetailSale : Sale
    {
        public override decimal CalcularTotal()
        {
            return base.GetAmount();
        }
    }
}
