using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfumeriaServices.Models;
using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Services;


namespace PerfumeriaTpDesktop.View.tpClienteView
{
    public partial class ClienteView : Form
    {
        IClienteService ClienteService = new ClienteService();
        // BindingSource para manejar los datos
        BindingSource ListClientes = new BindingSource();
        List<pCliente> FilterList = new List<pCliente>();
        pCliente? ClienteCurrent;
        private bool showingDeleted = false;

        public ClienteView()
        {
            InitializeComponent();

            // Configurar el DataGridView y cargar los datos iniciales
            dataGridViewClientes.DataSource = ListClientes;
            LoadGrid();
        }

        #region Métodos de carga de datos
        private async Task LoadGrid()
        {
            var clientes = await ClienteService.GetAllAsync(); // Llamada al servicio
            ListClientes.DataSource = clientes?.Where(c => !c.IsDeleted).ToList();
            FilterList = (List<pCliente>)ListClientes.DataSource;

            // Ocultar columnas innecesarias
            dataGridViewClientes.Columns["Id"].Visible = false;
            dataGridViewClientes.Columns["IsDeleted"].Visible = false;
        }
        #endregion

        #region Botones CRUD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Limpiar campos y preparar para agregar
            txtName.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNumber.Text = string.Empty;

            ClienteCurrent = null;
            tabControl1.SelectTab(AgregarEditar);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // Cargar datos en los controles para modificar
            ClienteCurrent = (pCliente)ListClientes.Current;

            txtName.Text = ClienteCurrent.Nombre;
            txtMail.Text = ClienteCurrent.Correo;
            txtNumber.Text = ClienteCurrent.Telefono;

            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Crear o modificar un cliente
            var nuevoCliente = new pCliente
            {
                Nombre = txtName.Text,
                Correo = txtMail.Text,
                Telefono = txtNumber.Text
            };

            if (ClienteCurrent != null)
            {
                ClienteCurrent.Nombre = nuevoCliente.Nombre;
                ClienteCurrent.Correo = nuevoCliente.Correo;
                ClienteCurrent.Telefono = nuevoCliente.Telefono;

                await ClienteService.UpdateAsync(ClienteCurrent);
                MessageBox.Show("Cliente modificado correctamente.");
            }
            else
            {
                await ClienteService.AddAsync(nuevoCliente);
                MessageBox.Show("Cliente agregado correctamente.");
            }

            await LoadGrid();
            tabControl1.SelectTab(Lista);
        }

        private async void btnEliminated_Click(object sender, EventArgs e)
        {
            if (ListClientes.Current is pCliente cliente)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar al cliente {cliente.Nombre}?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cliente.IsDeleted = true;
                    await ClienteService.UpdateAsync(cliente);
                    await LoadGrid();
                    MessageBox.Show("Cliente eliminado correctamente.");
                }
            }
        }
        #endregion

        #region Botón para alternar entre eliminados y activos
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                var activeClientes = await ClienteService.GetAllAsync();
                ListClientes.DataSource = activeClientes?.Where(c => !c.IsDeleted).ToList();
                btnSeeEliminated.Text = "Eliminados";
            }
            else
            {
                var deletedClientes = await ClienteService.GetAllDeletedAsync();
                ListClientes.DataSource = deletedClientes?.Where(c => c.IsDeleted).ToList();
                btnSeeEliminated.Text = "Activos";
            }

            FilterList = (List<pCliente>)ListClientes.DataSource;
            showingDeleted = !showingDeleted;
        }
        #endregion

        #region Filtro dinámico
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            var filtro = FilterList.Where(c =>
                c.Nombre.Contains(txtFiltro.Text, StringComparison.OrdinalIgnoreCase) ||
                c.Correo.Contains(txtFiltro.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            ListClientes.DataSource = new BindingSource(filtro, null);
        }
        #endregion

        #region Botón de cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada.");
            tabControl1.SelectTab(Lista);
        }
        #endregion
    }
}
