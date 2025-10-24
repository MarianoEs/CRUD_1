namespace CRUD_1.Front
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btCarrito = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.BurlyWood;
            this.btAgregar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregar.Location = new System.Drawing.Point(499, 102);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(130, 29);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(8, 102);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(172, 29);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 102);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(382, 102);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 29);
            this.txtPrecio.TabIndex = 6;
            // 
            // btCarrito
            // 
            this.btCarrito.BackColor = System.Drawing.Color.BurlyWood;
            this.btCarrito.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarrito.ForeColor = System.Drawing.Color.Black;
            this.btCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btCarrito.Image")));
            this.btCarrito.Location = new System.Drawing.Point(499, 151);
            this.btCarrito.Name = "btCarrito";
            this.btCarrito.Size = new System.Drawing.Size(130, 66);
            this.btCarrito.TabIndex = 8;
            this.btCarrito.UseVisualStyleBackColor = false;
            this.btCarrito.Click += new System.EventHandler(this.btCarrito_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.BackColor = System.Drawing.Color.BurlyWood;
            this.btVaciar.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVaciar.Location = new System.Drawing.Point(499, 249);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(130, 52);
            this.btVaciar.TabIndex = 9;
            this.btVaciar.Text = "VACIAR COMPRA";
            this.btVaciar.UseVisualStyleBackColor = false;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(8, 139);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(464, 162);
            this.DGV.TabIndex = 10;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(963, 372);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btCarrito);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btCarrito;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.DataGridView DGV;
    }
}

