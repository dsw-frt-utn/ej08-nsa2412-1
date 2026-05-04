using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    public class Product
    {
        private string _Description = "";

        public Product (string desription)
        {
            _Description = desription;
        }
        public void SetDescription (string description)
        {
            _Description = description;
        }
        public string GetDescription()
        {
            return _Description;
        }

        public void ModificarDescripcion(string nuevaDescripcion)
        {
            _Description = nuevaDescripcion;
        }
    }
}
