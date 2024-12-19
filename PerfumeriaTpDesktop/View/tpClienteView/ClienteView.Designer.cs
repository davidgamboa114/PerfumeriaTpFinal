namespace PerfumeriaTpDesktop.View.tpClienteView
{
    partial class ClienteView
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
            btnOut = new FontAwesome.Sharp.IconButton();
            btnEliminated = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dataGridViewClientes = new DataGridView();
            txtFiltro = new TextBox();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            AgregarEditar = new TabPage();
            txtNumber = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            tabControl1.SuspendLayout();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            AgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(Lista);
            tabControl1.Controls.Add(AgregarEditar);
            tabControl1.Location = new Point(-1, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 442);
            tabControl1.TabIndex = 1;
            // 
            // Lista
            // 
            Lista.Controls.Add(btnSeeEliminated);
            Lista.Controls.Add(btnOut);
            Lista.Controls.Add(btnEliminated);
            Lista.Controls.Add(btnModify);
            Lista.Controls.Add(btnAdd);
            Lista.Controls.Add(btnSearch);
            Lista.Controls.Add(label1);
            Lista.Controls.Add(dataGridViewClientes);
            Lista.Controls.Add(txtFiltro);
            Lista.Controls.Add(iconButtonSalir);
            Lista.Controls.Add(btnEliminar);
            Lista.Controls.Add(btnModificar);
            Lista.Controls.Add(btnAgregar);
            Lista.Controls.Add(BtnBuscar);
            Lista.Location = new Point(4, 24);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(795, 414);
            Lista.TabIndex = 0;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOut.BackColor = Color.Red;
            btnOut.ForeColor = Color.White;
            btnOut.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnOut.IconColor = Color.White;
            btnOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOut.IconSize = 44;
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(680, 240);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(108, 54);
            btnOut.TabIndex = 27;
            btnOut.Text = "&Salir";
            btnOut.TextAlign = ContentAlignment.MiddleRight;
            btnOut.UseVisualStyleBackColor = false;
            // 
            // btnEliminated
            // 
            btnEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminated.BackColor = Color.DarkGray;
            btnEliminated.Enabled = false;
            btnEliminated.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminated.IconColor = Color.Black;
            btnEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminated.Location = new Point(680, 188);
            btnEliminated.Margin = new Padding(1);
            btnEliminated.Name = "btnEliminated";
            btnEliminated.Size = new Size(105, 48);
            btnEliminated.TabIndex = 26;
            btnEliminated.Text = "Eliminar";
            btnEliminated.TextAlign = ContentAlignment.MiddleRight;
            btnEliminated.UseVisualStyleBackColor = false;
            btnEliminated.Click += btnEliminated_Click;
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModify.BackColor = Color.LightGray;
            btnModify.Enabled = false;
            btnModify.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModify.IconColor = Color.Black;
            btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModify.ImageAlign = ContentAlignment.MiddleLeft;
            btnModify.Location = new Point(679, 138);
            btnModify.Margin = new Padding(1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(105, 48);
            btnModify.TabIndex = 25;
            btnModify.Text = "Modificar";
            btnModify.TextAlign = ContentAlignment.MiddleRight;
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.DarkGray;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(679, 88);
            btnAdd.Margin = new Padding(1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 48);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(680, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 51);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "&Buscar";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 22;
            label1.Text = "Buscar:";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(4, 70);
            dataGridViewClientes.Margin = new Padding(1);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(668, 292);
            dataGridViewClientes.TabIndex = 21;
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltro.Location = new Point(125, 28);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 23);
            txtFiltro.TabIndex = 20;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
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
            iconButtonSalir.Location = new Point(1272, 242);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(108, 54);
            iconButtonSalir.TabIndex = 19;
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
            btnEliminar.Location = new Point(1272, 190);
            btnEliminar.Margin = new Padding(1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 48);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnModificar.Location = new Point(1271, 140);
            btnModificar.Margin = new Padding(1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 48);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(1271, 90);
            btnAgregar.Margin = new Padding(1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 48);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
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
            BtnBuscar.Location = new Point(1272, 20);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 51);
            BtnBuscar.TabIndex = 15;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // AgregarEditar
            // 
            AgregarEditar.Controls.Add(txtNumber);
            AgregarEditar.Controls.Add(label4);
            AgregarEditar.Controls.Add(txtMail);
            AgregarEditar.Controls.Add(label3);
            AgregarEditar.Controls.Add(txtName);
            AgregarEditar.Controls.Add(label2);
            AgregarEditar.Controls.Add(btnCancel);
            AgregarEditar.Controls.Add(btnSave);
            AgregarEditar.Controls.Add(btnCancelar);
            AgregarEditar.Controls.Add(btnGuardar);
            AgregarEditar.Location = new Point(4, 24);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(795, 414);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "Agregar/Editar";
            AgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            txtNumber.Anchor = AnchorStyles.None;
            txtNumber.Location = new Point(267, 244);
            txtNumber.Margin = new Padding(2);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(249, 23);
            txtNumber.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(148, 244);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefono:";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(267, 167);
            txtMail.Margin = new Padding(2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(249, 23);
            txtMail.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(148, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 17;
            label3.Text = "Correo:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(267, 102);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(249, 23);
            txtName.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(148, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(636, 201);
            btnCancel.Margin = new Padding(1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 43);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.DarkGray;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(636, 156);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 43);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(1420, 177);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.DarkGray;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1420, 132);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 43);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(685, 311);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 64;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 525);
            Controls.Add(tabControl1);
            Name = "ClienteView";
            Text = "ClienteView";
            tabControl1.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Lista;
        public FontAwesome.Sharp.IconButton iconButtonSalir;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnModificar;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton BtnBuscar;
        private TabPage AgregarEditar;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton btnGuardar;
        public FontAwesome.Sharp.IconButton iconButton2;
        public FontAwesome.Sharp.IconButton btnModify;
        public FontAwesome.Sharp.IconButton btnAdd;
        public FontAwesome.Sharp.IconButton btnSearch;
        private Label label1;
        public DataGridView dataGridViewClientes;
        public TextBox txtFiltro;
        public FontAwesome.Sharp.IconButton btnCancel;
        public FontAwesome.Sharp.IconButton btnSave;
        public FontAwesome.Sharp.IconButton btnOut;
        public FontAwesome.Sharp.IconButton btnEliminated;
        public TextBox txtNumber;
        private Label label4;
        public TextBox txtMail;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
    }
}