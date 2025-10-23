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

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        public void btVaciar_Click(object sender, EventArgs e)
        {
            //DGV.Rows.Clear();
            //this.Producto.Clear();
            //this.DGV.DataSource = this.Producto;

            // Pide confirmación al usuario antes de vaciar

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que quieres vaciar el DataGridView y el archivo XML?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {

                Vaciar();

                // Paso 1: Desvincula el DataGridView
                //DGV.DataSource = null;

                // Paso 2: Limpia los datos del DataSet subyacente
                //if (Producto.Lista.Count > 0)
                //{
                //    Producto.Lista.Clear();
                //}

                // Paso 3: Guarda el DataSet vacío en el archivo XML
               // try
                //{
                //    Lista.WriteXml("Productos.xml");
                //    MessageBox.Show("El DataGridView y el archivo XML han sido vaciados exitosamente.");
                //}
                //catch (Exception ex)
                //{
               //     MessageBox.Show("Error al guardar el archivo XML: " + ex.Message);
               // }
            }
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            

           
        }
    }
}
