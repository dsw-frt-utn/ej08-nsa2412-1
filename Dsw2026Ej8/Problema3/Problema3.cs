using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valueCopy = originalValue;
            valueCopy++;
            Product productCopy = product;
            productCopy.ModificarDescripcion("Nueva descripcion)");
            return $"{originalValue}-{valueCopy}-{product.GetDescription()}";
        }
    }
}
