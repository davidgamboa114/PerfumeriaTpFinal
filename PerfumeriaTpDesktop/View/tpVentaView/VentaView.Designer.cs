namespace PerfumeriaTpDesktop.View.tpVentaView
{
    partial class VentaView
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
            tabControl1 = new TabControl();
            Lista = new TabPage();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dataGridViewVentas = new DataGridView();
            txtFiltro = new TextBox();
            AgregarEditar = new TabPage();
            FechaVenta = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            CBoxMetodoPago = new ComboBox();
            CBoxProducto = new ComboBox();
            CBoxCliente = new ComboBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            AgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(2, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 400);
            tabControl1.TabIndex = 0;
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
            Lista.Controls.Add(dataGridViewVentas);
            Lista.Controls.Add(txtFiltro);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(794, 372);
            Lista.TabIndex = 0;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
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
            iconButtonSalir.Location = new Point(680, 239);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(108, 54);
            iconButtonSalir.TabIndex = 19;
            iconButtonSalir.Text = "&Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleRight;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
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
            btnEliminar.Location = new Point(680, 187);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 48);
            btnEliminar.TabIndex = 18;
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
            btnModificar.Location = new Point(679, 137);
            btnModificar.Margin = new Padding(1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 48);
            btnModificar.TabIndex = 17;
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
            btnAgregar.Location = new Point(679, 87);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 48);
            btnAgregar.TabIndex = 16;
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
            BtnBuscar.Location = new Point(680, 17);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 51);
            BtnBuscar.TabIndex = 15;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 30);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "Buscar:";
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.AllowUserToAddRows = false;
            dataGridViewVentas.AllowUserToDeleteRows = false;
            dataGridViewVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Location = new Point(4, 69);
            dataGridViewVentas.Margin = new Padding(1);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.ReadOnly = true;
            dataGridViewVentas.RowHeadersWidth = 62;
            dataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVentas.Size = new Size(668, 299);
            dataGridViewVentas.TabIndex = 13;
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltro.Location = new Point(125, 27);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 23);
            txtFiltro.TabIndex = 12;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(FechaVenta);
            AgregarEditar.Controls.Add(label6);
            AgregarEditar.Controls.Add(label5);
            AgregarEditar.Controls.Add(label4);
            AgregarEditar.Controls.Add(label1);
            AgregarEditar.Controls.Add(CBoxMetodoPago);
            AgregarEditar.Controls.Add(CBoxProducto);
            AgregarEditar.Controls.Add(CBoxCliente);
            AgregarEditar.Controls.Add(txtCantidad);
            AgregarEditar.Controls.Add(label2);
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(794, 372);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "Agregar/Editar";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // FechaVenta
            // 
            FechaVenta.Format = DateTimePickerFormat.Custom;
            FechaVenta.Location = new Point(233, 272);
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Size = new Size(146, 23);
            FechaVenta.TabIndex = 25;
            FechaVenta.Value = new DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 278);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 24;
            label6.Text = "Fecha de la Venta:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(114, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 16;
            label5.Text = "Producto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(114, 217);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 15;
            label4.Text = "Metodo de Pago";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(114, 105);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 14;
            label1.Text = "Cliente:";
            // 
            // CBoxMetodoPago
            // 
            CBoxMetodoPago.FormattingEnabled = true;
            CBoxMetodoPago.Location = new Point(233, 214);
            CBoxMetodoPago.Name = "CBoxMetodoPago";
            CBoxMetodoPago.Size = new Size(249, 23);
            CBoxMetodoPago.TabIndex = 13;
            // 
            // CBoxProducto
            // 
            CBoxProducto.FormattingEnabled = true;
            CBoxProducto.Location = new Point(233, 154);
            CBoxProducto.Name = "CBoxProducto";
            CBoxProducto.Size = new Size(249, 23);
            CBoxProducto.TabIndex = 12;
            // 
            // CBoxCliente
            // 
            CBoxCliente.FormattingEnabled = true;
            CBoxCliente.Location = new Point(233, 102);
            CBoxCliente.Name = "CBoxCliente";
            CBoxCliente.Size = new Size(249, 23);
            CBoxCliente.TabIndex = 11;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.Location = new Point(233, 51);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(249, 23);
            txtCantidad.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(114, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(618, 174);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.DarkGray;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(618, 129);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 43);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(685, 313);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 65;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            // 
            // VentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(tabControl1);
            Name = "VentaView";
            Text = "VentaView";
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Lista;
        private TabPage AgregarEditar;
        public TextBox txtFiltro;
        public FontAwesome.Sharp.IconButton iconButtonSalir;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnModificar;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton BtnBuscar;
        private Label label3;
        public DataGridView dataGridViewVentas;
        public TextBox txtCantidad;
        private Label label2;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox CBoxCliente;
        private ComboBox CBoxMetodoPago;
        private ComboBox CBoxProducto;
        private Label label5;
        private Label label4;
        private Label label1;
        private DateTimePicker FechaVenta;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
    }
}