using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema01
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            if (!ValidarCodigo(code))
            {
                return "Error: codigo invalido";
            }
            string textoPrecio = price.ToString("C");
            return $"[{code}] {description} {guion} {textoPrecio}";
        }
    }
}
