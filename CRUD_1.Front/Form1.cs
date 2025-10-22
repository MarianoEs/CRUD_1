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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();

            prod.Codigo = txtCodigo.Text;
            prod.Nombre = txtNombre.Text;
            prod.Precio = int.Parse(txtPrecio.Text);


            //lblSalida.Text = lblSalida.Text + "\r\n"
            //                                + " - " + txtNombre.Text
            //                                + " - " + txtCodigo.Text
            //                                + " - " + txtPrecio.Text;

            lblSalida.Text = lblSalida.Text + "\r\n" + prod.Descripcion();
            Limpiar();

        }
        private void Limpiar()
        {
            //limpia los campos
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
