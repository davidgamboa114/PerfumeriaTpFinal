namespace PerfumeriaTpDesktop.View.tpAreaDeVenta
{
    partial class AreaDeVentaView
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
            AgregarEditar = new TabPage();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dataGridViewAreaDeVentas = new DataGridView();
            txtFiltro = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            AgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAreaDeVentas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(0, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 402);
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
            Lista.Controls.Add(dataGridViewAreaDeVentas);
            Lista.Controls.Add(txtFiltro);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(795, 374);
            Lista.TabIndex = 0;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Controls.Add(txtNombre);
            AgregarEditar.Controls.Add(label2);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(795, 374);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "Agregar/Editar";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(686, 308);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 74;
            btnSeeEliminated.UseVisualStyleBackColor = true;
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
            iconButtonSalir.Location = new Point(681, 234);
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
            btnEliminar.Location = new Point(681, 182);
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
            btnModificar.Location = new Point(680, 132);
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
            btnAgregar.Location = new Point(680, 82);
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
            BtnBuscar.Location = new Point(681, 12);
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
            label3.Location = new Point(30, 25);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 68;
            label3.Text = "Buscar:";
            // 
            // dataGridViewAreaDeVentas
            // 
            dataGridViewAreaDeVentas.AllowUserToAddRows = false;
            dataGridViewAreaDeVentas.AllowUserToDeleteRows = false;
            dataGridViewAreaDeVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAreaDeVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAreaDeVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAreaDeVentas.Location = new Point(5, 64);
            dataGridViewAreaDeVentas.Margin = new Padding(1);
            dataGridViewAreaDeVentas.Name = "dataGridViewAreaDeVentas";
            dataGridViewAreaDeVentas.ReadOnly = true;
            dataGridViewAreaDeVentas.RowHeadersWidth = 62;
            dataGridViewAreaDeVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAreaDeVentas.Size = new Size(668, 299);
            dataGridViewAreaDeVentas.TabIndex = 67;
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltro.Location = new Point(126, 22);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 23);
            txtFiltro.TabIndex = 66;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(578, 188);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 43);
            btnCancelar.TabIndex = 18;
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
            btnGuardar.Location = new Point(578, 143);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 43);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(233, 163);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 23);
            txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(111, 166);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // AreaDeVentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AreaDeVentaView";
            Text = "AreaDeVentaView";
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAreaDeVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Lista;
        private TabPage AgregarEditar;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        public FontAwesome.Sharp.IconButton iconButtonSalir;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnModificar;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton BtnBuscar;
        private Label label3;
        public DataGridView dataGridViewAreaDeVentas;
        public TextBox txtFiltro;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        public TextBox txtNombre;
        private Label label2;
    }
}