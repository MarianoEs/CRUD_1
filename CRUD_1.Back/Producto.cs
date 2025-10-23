using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_1.Back
{
    public class Producto 
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }


        public Producto (string codigo, string nombre, string precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = int.Parse(precio);

        }

        public string Descripcion()
        {
            string res;
            res = Codigo 
                + " - " + Nombre 
                + " - " + Precio.ToString();

            return res;
        }
    }
}
