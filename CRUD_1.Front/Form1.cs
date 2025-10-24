using CRUD_1.Back;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_1.Front
{
    public partial class Form1 : Form
    {


        private Productos productos = new Productos();

        public Form1()
        {
            InitializeComponent();
            DGV.DataSource = productos.Lista;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto (
                txtCodigo.Text, txtNombre.Text,txtPrecio.Text
                );


            productos.Insertar(Producto);   

            Limpiar();

        }
        private void Limpiar()
        {

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            

            txtCodigo.Focus();
        }

        

        public void btVaciar_Click(object sender, EventArgs e)
        {
            
        }

        

        

        private void btCarrito_Click(object sender, EventArgs e)
        {
            Carrito carritoForm = new Carrito();
            carritoForm.Show();
        }
    }
}
