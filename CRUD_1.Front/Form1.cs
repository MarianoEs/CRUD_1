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
            lblSalida.Text = lblSalida.Text + "\r\n"
                                            + " - " + txtNombre.Text
                                            + " - " + txtCodigo.Text
                                            + " - " + txtPrecio.Text;        

        }
    }
}
