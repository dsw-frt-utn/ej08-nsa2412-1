using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class Sale
    {
        private decimal _Amount = 0;
        public void SetAmount (decimal amount)
        {
            _Amount = amount;
        }
        public decimal GetAmount()
        {
            return _Amount;
        }

        public virtual decimal CalcularTotal()
        {
            return _Amount;
        }
    }
}
