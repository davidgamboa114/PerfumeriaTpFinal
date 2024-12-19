using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Models;
using PerfumeriaServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfumeriaTpDesktop.View.tpProductoView
{
    public partial class ProductoVIew : Form
    {
        IProductoService ProductoService = new ProductoService();
        IAreaDeVentaService AreaDeVentaService = new AreaDeVentaService();
        // BindingSource para manejar los datos
        BindingSource ListProductos = new BindingSource();
        List<pProducto> FilterList = new List<pProducto>();
        pProducto? ProductoCurrent;
        private bool showingDeleted = false;
        public ProductoVIew()
        {
            InitializeComponent();

            // Configurar el DataGridView y cargar los datos iniciales
            dataGridViewProductos.DataSource = ListProductos;
            LoadGrid();
            loadCBoxAreaDeVenta();
        }

        #region Métodos de carga de datos
        private async Task LoadGrid()
        {
            var productos = await ProductoService.GetAllAsync(); // Llamada al servicio
            ListProductos.DataSource = productos?.Where(p => !p.IsDeleted).ToList();
            FilterList = (List<pProducto>)ListProductos.DataSource;

            // Ocultar columnas innecesarias
            dataGridViewProductos.Columns["Id"].Visible = false;
            dataGridViewProductos.Columns["IsDeleted"].Visible = false;
            dataGridViewProductos.Columns["AreaDeVenta"].Visible = false;
        }

        private async Task loadCBoxAreaDeVenta()
        {
            var areasDeVenta = await AreaDeVentaService.GetAllAsync(); // Llamada al servicio
            CBoxAreaDeVenta.DataSource = areasDeVenta;
            CBoxAreaDeVenta.DisplayMember = "Nombre";
            CBoxAreaDeVenta.ValueMember = "Id";
            CBoxAreaDeVenta.SelectedIndex = -1;
        }
        #endregion

        #region Botones CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar campos y preparar para agregar
            txtNombre.Text = string.Empty;
            Precio.Text = string.Empty;
            CBoxAreaDeVenta.SelectedIndex = -1;

            ProductoCurrent = null;
            tabControl1.SelectTab(AgregarEditar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Cargar datos en los controles para modificar
            ProductoCurrent = (pProducto)ListProductos.Current;

            txtNombre.Text = ProductoCurrent.Nombre;
            Precio.Text = ProductoCurrent.Precio.ToString("F2");
            CBoxAreaDeVenta.SelectedValue = ProductoCurrent.AreaVentaId;

            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear o modificar un producto
            if (!decimal.TryParse(Precio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            var nuevoProducto = new pProducto
            {
                Nombre = txtNombre.Text,
                Precio = precio,
                AreaVentaId = (long)CBoxAreaDeVenta.SelectedValue
            };

            if (ProductoCurrent != null)
            {
                ProductoCurrent.Nombre = nuevoProducto.Nombre;
                ProductoCurrent.Precio = nuevoProducto.Precio;
                ProductoCurrent.AreaVentaId = nuevoProducto.AreaVentaId;

                await ProductoService.UpdateAsync(ProductoCurrent);
                MessageBox.Show("Producto modificado correctamente.");
            }
            else
            {
                await ProductoService.AddAsync(nuevoProducto);
                MessageBox.Show("Producto agregado correctamente.");
            }

            await LoadGrid();
            tabControl1.SelectTab(Lista);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListProductos.Current is pProducto producto)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el producto {producto.Nombre}?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    producto.IsDeleted = true;
                    await ProductoService.UpdateAsync(producto);
                    await LoadGrid();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
        }
        #endregion

        #region Botón para alternar entre eliminados y activos
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                var activeProductos = await ProductoService.GetAllAsync();
                ListProductos.DataSource = activeProductos?.Where(p => !p.IsDeleted).ToList();
                btnSeeEliminated.Text = "Eliminados";
            }
            else
            {
                var deletedProductos = await ProductoService.GetAllDeletedAsync();
                ListProductos.DataSource = deletedProductos?.Where(p => p.IsDeleted).ToList();
                btnSeeEliminated.Text = "Activos";
            }

            FilterList = (List<pProducto>)ListProductos.DataSource;
            showingDeleted = !showingDeleted;
        }
        #endregion

        #region Filtro dinámico
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            var filtro = FilterList.Where(p =>
                p.Nombre.Contains(txtFiltro.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            ListProductos.DataSource = new BindingSource(filtro, null);
        }
        #endregion

        #region Botón de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada.");
            tabControl1.SelectTab(Lista);
        }
        #endregion
    }
}