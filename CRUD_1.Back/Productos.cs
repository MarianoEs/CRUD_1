using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_1.Back
{
    public class Productos
    {
        public DataTable Lista { get; set; }

        public Productos()
        {
            Lista = new DataTable();
            Lista.TableName = "Productos";
            Lista.Columns.Add("Codigo", typeof(string));
            Lista.Columns.Add("Nombre", typeof(string));
            Lista.Columns.Add("Precio", typeof(int));

            LeerArchivos();
        }

        private void LeerArchivos()
        {
            if (System.IO.File.Exists("Productos.xml"))
            {
                Lista.ReadXml("Productos.xml");
            }
        }
        
        public void Insertar(Producto producto)
        {
            Lista.Rows.Add();
            int NuevoReglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoReglon]["Codigo"] = producto.Codigo;
            Lista.Rows[NuevoReglon]["Nombre"] = producto.Nombre;
            Lista.Rows[NuevoReglon]["Precio"] = producto.Precio;
            

            Lista.WriteXml("Productos.xml");

        }

        public void Vaciar(Producto Producto)
        {
           
            Lista.Rows.Clear();
           
            Lista.WriteXml("Productos.xml");
        }
    }
}
