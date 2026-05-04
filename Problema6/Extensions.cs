using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string value)
        {
            if (value == null)
            {
                return "SIN-CODIGO";
            }

            return value.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
