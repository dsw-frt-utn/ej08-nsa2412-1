using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int?[] notasEntrada = {nota1, nota2, nota3};

            var notasValidas = new List<int?>();

            foreach (var nota in notasEntrada)
            {
                if (nota.HasValue && nota.Value >=0 && nota.Value <= 10)
                {
                    notasValidas.Add(nota.Value);
                }
            }

            if(notasValidas.Count == 0)
            {
                return 0;
            }
            
            double suma = 0;
            foreach(int n in notasValidas)
            {
                suma += n;
            }
            return suma / notasValidas.Count;
    }
}
