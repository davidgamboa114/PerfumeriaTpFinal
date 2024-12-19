using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Models;
using PerfumeriaServices.Services;
namespace PerfumeriaTpDesktop.View.tpVentaView
{
    public partial class VentaView : Form
    {

        IVentaService VentaService = new VentaService();
        IClienteService ClienteService = new ClienteService();
        IProductoService ProductoService = new ProductoService();
        IMetodoDePagoService MetodoDePagoService = new MetodoDePagoService();


        // BindingSource y listas para manejar datos
        BindingSource ListVentas = new BindingSource();
        List<pVenta> FilterList = new List<pVenta>();
        pVenta? VentaCurrent;
        private bool showingDeleted = false;

        public VentaView()
        {
            InitializeComponent();

            // Inicializar el DataGridView y cargar datos
            dataGridViewVentas.DataSource = ListVentas;
            LoadGrid();
            LoadComboBoxes();
        }

        #region Métodos de carga de datos
        private async Task LoadGrid()
        {
            var ventas = await VentaService.GetAllAsync(); // Obtener datos desde el servicio
            ListVentas.DataSource = ventas?.Where(v => !v.IsDeleted).ToList();
            FilterList = (List<pVenta>)ListVentas.DataSource;

            dataGridViewVentas.Columns["Id"].Visible = false;
            dataGridViewVentas.Columns["IsDeleted"].Visible = false;
        }

        private async Task LoadComboBoxes()
        {
            // Llenar ComboBox de clientes
            CBoxCliente.DataSource = await ClienteService.GetAllAsync();
            CBoxCliente.DisplayMember = "Nombre";
            CBoxCliente.ValueMember = "Id";

            // Llenar ComboBox de productos
            CBoxProducto.DataSource = await ProductoService.GetAllAsync();
            CBoxProducto.DisplayMember = "Nombre";
            CBoxProducto.ValueMember = "Id";

            // Llenar ComboBox de métodos de pago
            CBoxMetodoPago.DataSource = await MetodoDePagoService.GetAllAsync();
            CBoxMetodoPago.DisplayMember = "Nombre";
            CBoxMetodoPago.ValueMember = "Id";
        }
        #endregion

        #region Botones CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar campos y preparar para agregar
            txtCantidad.Text = string.Empty;
            CBoxCliente.SelectedIndex = -1;
            CBoxProducto.SelectedIndex = -1;
            CBoxMetodoPago.SelectedIndex = -1;
            FechaVenta.Value = DateTime.Now;

            VentaCurrent = null;
            tabControl1.SelectTab(AgregarEditar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Cargar datos en los controles para modificar
            VentaCurrent = (pVenta)ListVentas.Current;

            txtCantidad.Text = VentaCurrent.Cantidad.ToString();
            CBoxCliente.SelectedValue = VentaCurrent.ClienteId;
            CBoxProducto.SelectedValue = VentaCurrent.ProductoId;
            CBoxMetodoPago.SelectedValue = VentaCurrent.MetodoPagoId;
            FechaVenta.Value = VentaCurrent.Fecha;

            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear o modificar una venta
            var nuevaVenta = new pVenta
            {
                Fecha = FechaVenta.Value,
                ClienteId = (long)CBoxCliente.SelectedValue,
                ProductoId = (long)CBoxProducto.SelectedValue,
                MetodoPagoId = (long)CBoxMetodoPago.SelectedValue,
                Cantidad = int.Parse(txtCantidad.Text)
            };

            if (VentaCurrent != null)
            {
                VentaCurrent.Fecha = nuevaVenta.Fecha;
                VentaCurrent.ClienteId = nuevaVenta.ClienteId;
                VentaCurrent.ProductoId = nuevaVenta.ProductoId;
                VentaCurrent.MetodoPagoId = nuevaVenta.MetodoPagoId;
                VentaCurrent.Cantidad = nuevaVenta.Cantidad;

                await VentaService.UpdateAsync(VentaCurrent);
                MessageBox.Show("Venta modificada correctamente.");
            }
            else
            {
                await VentaService.AddAsync(nuevaVenta);
                MessageBox.Show("Venta agregada correctamente.");
            }

            await LoadGrid();
            tabControl1.SelectTab(Lista);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListVentas.Current is pVenta venta)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar la venta #{venta.Id}?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    venta.IsDeleted = true;
                    await VentaService.UpdateAsync(venta);
                    await LoadGrid();
                    MessageBox.Show("Venta eliminada correctamente.");
                }
            }
        }
        #endregion

        #region Botón para alternar entre eliminados y activos
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                var activeVentas = await VentaService.GetAllAsync();
                ListVentas.DataSource = activeVentas?.Where(v => !v.IsDeleted).ToList();
                btnSeeEliminated.Text = "eliminados";
            }
            else
            {
                var deletedVentas = await VentaService.GetAllDeletedAsync();
                ListVentas.DataSource = deletedVentas?.Where(v => v.IsDeleted).ToList();
                btnSeeEliminated.Text = "Activos";
            }

            FilterList = (List<pVenta>)ListVentas.DataSource;
            showingDeleted = !showingDeleted;
        }
        #endregion

        #region Filtro dinámico
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            var filtro = FilterList.Where(v =>
                v.Cliente.Nombre.Contains(txtFiltro.Text) ||
                v.Producto.Nombre.Contains(txtFiltro.Text)).ToList();

            ListVentas.DataSource = new BindingSource(filtro, null);
        }
        #endregion

        #region Botón de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada.");
            tabControl1.SelectTab(Lista);
        }
        #endregion


        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
