namespace PerfumeriaTpDesktop.View.tpProductoView
{
    partial class ProductoVIew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AgregarEditar = new TabPage();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            CBoxAreaDeVenta = new ComboBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label7 = new Label();
            Precio = new NumericUpDown();
            Lista = new TabPage();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dataGridViewProductos = new DataGridView();
            txtFiltro = new TextBox();
            tabControl1 = new TabControl();
            AgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Precio).BeginInit();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(label1);
            AgregarEditar.Controls.Add(CBoxAreaDeVenta);
            AgregarEditar.Controls.Add(txtNombre);
            AgregarEditar.Controls.Add(label2);
            AgregarEditar.Controls.Add(label7);
            AgregarEditar.Controls.Add(Precio);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(792, 371);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "Agregar/Editar";
            AgregarEditar.UseVisualStyleBackColor = true;
            AgregarEditar.UseWaitCursor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.DarkGray;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(608, 119);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 43);
            btnGuardar.TabIndex = 80;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.UseWaitCursor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(608, 178);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 43);
            btnCancelar.TabIndex = 79;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.UseWaitCursor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(122, 195);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 77;
            label1.Text = "Area de venta:";
            label1.UseWaitCursor = true;
            // 
            // CBoxAreaDeVenta
            // 
            CBoxAreaDeVenta.FormattingEnabled = true;
            CBoxAreaDeVenta.Location = new Point(234, 195);
            CBoxAreaDeVenta.Name = "CBoxAreaDeVenta";
            CBoxAreaDeVenta.Size = new Size(249, 23);
            CBoxAreaDeVenta.TabIndex = 76;
            CBoxAreaDeVenta.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(234, 68);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 23);
            txtNombre.TabIndex = 75;
            txtNombre.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(115, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 74;
            label2.Text = "Nombre:";
            label2.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 133);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 73;
            label7.Text = "COSTO:";
            label7.UseWaitCursor = true;
            // 
            // Precio
            // 
            Precio.BackColor = SystemColors.InactiveCaption;
            Precio.DecimalPlaces = 2;
            Precio.Location = new Point(234, 131);
            Precio.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            Precio.Name = "Precio";
            Precio.Size = new Size(60, 23);
            Precio.TabIndex = 72;
            Precio.UseWaitCursor = true;
            // 
            // Lista
            // 
            Lista.Controls.Add(btnSeeEliminated);
            Lista.Controls.Add(iconButtonSalir);
            Lista.Controls.Add(btnEliminar);
            Lista.Controls.Add(btnModificar);
            Lista.Controls.Add(btnAgregar);
            Lista.Controls.Add(BtnBuscar);
            Lista.Controls.Add(label3);
            Lista.Controls.Add(dataGridViewProductos);
            Lista.Controls.Add(txtFiltro);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(792, 371);
            Lista.TabIndex = 0;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(685, 306);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 74;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonSalir.BackColor = Color.Red;
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 44;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(680, 232);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(108, 54);
            iconButtonSalir.TabIndex = 73;
            iconButtonSalir.Text = "&Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleRight;
            iconButtonSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.DarkGray;
            btnEliminar.Enabled = false;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(680, 180);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 48);
            btnEliminar.TabIndex = 72;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.BackColor = Color.LightGray;
            btnModificar.Enabled = false;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(679, 130);
            btnModificar.Margin = new Padding(1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 48);
            btnModificar.TabIndex = 71;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(679, 80);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 48);
            btnAgregar.TabIndex = 70;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.CornflowerBlue;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.White;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(680, 10);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 51);
            BtnBuscar.TabIndex = 69;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 23);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 68;
            label3.Text = "Buscar:";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(4, 62);
            dataGridViewProductos.Margin = new Padding(1);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(668, 299);
            dataGridViewProductos.TabIndex = 67;
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltro.Location = new Point(125, 20);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 23);
            txtFiltro.TabIndex = 66;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(0, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 399);
            tabControl1.TabIndex = 0;
            // 
            // ProductoVIew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ProductoVIew";
            Text = "ProductoVIew";
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Precio).EndInit();
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage AgregarEditar;
        private TabPage Lista;
        private TabControl tabControl1;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        public FontAwesome.Sharp.IconButton iconButtonSalir;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnModificar;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton BtnBuscar;
        private Label label3;
        public DataGridView dataGridViewProductos;
        public TextBox txtFiltro;
        private Label label7;
        private NumericUpDown Precio;
        private Label label1;
        private ComboBox CBoxAreaDeVenta;
        public TextBox txtNombre;
        private Label label2;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton btnGuardar;
    }
}