using CRUD_1.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_1.Front
{
    public partial class Carrito : Form
    {

        private Productos carritoProd = new Productos();
        public Carrito(Productos ListaArg)
        {

            carritoProd = ListaArg;


            InitializeComponent();

            foreach (DataRow row in carritoProd.Lista.Rows)
            {
                string nombre = row["Nombre"].ToString();
                string codigo = row["Codigo"].ToString();
                string precio = row["Precio"].ToString();

                lblCarrito.Text = lblCarrito.Text + "\n\r"
                                                  + " - "
                                                  + codigo
                                                  + nombre
                                                  + precio;

                lblTotal.Text = Convert.ToInt32 (lblTotal.Text) + Convert.ToInt32(precio) + "";

            }

        }
    }
        
}
