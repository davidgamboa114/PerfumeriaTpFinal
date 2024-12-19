using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfumeriaServices.Models;
using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Services;

namespace PerfumeriaTpDesktop.View.tpAreaDeVenta
{
    public partial class AreaDeVentaView : Form
    {
        private readonly IAreaDeVentaService AreaDeVentaService = new AreaDeVentaService();
        private BindingSource ListAreaDeVenta = new BindingSource();
        private List<pAreaDeVenta> FilterList = new List<pAreaDeVenta>();
        private pAreaDeVenta? AreaDeVentaActual;
        private bool mostrandoEliminados = false;

        public AreaDeVentaView()
        {
            InitializeComponent();
            dataGridViewAreaDeVentas.DataSource = ListAreaDeVenta;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            var areas = await AreaDeVentaService.GetAllAsync();
            ListAreaDeVenta.DataSource = areas?.Where(a => !a.IsDeleted).ToList();
            FilterList = (List<pAreaDeVenta>)ListAreaDeVenta.DataSource;

            // Ocultar columnas innecesarias
            dataGridViewAreaDeVentas.Columns[0].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            tabControl1.SelectTab(AgregarEditar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AreaDeVentaActual = (pAreaDeVenta)ListAreaDeVenta.Current;

            txtNombre.Text = AreaDeVentaActual.Nombre;
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListAreaDeVenta.Current is pAreaDeVenta area)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el área de venta {area.Nombre}?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    area.IsDeleted = true;
                    await AreaDeVentaService.UpdateAsync(area);
                    await CargarGrilla();
                    MessageBox.Show("Área de venta eliminada correctamente.");
                }
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            var areaDeVenta = new pAreaDeVenta
            {
                Nombre = txtNombre.Text
            };

            if (AreaDeVentaActual != null)
            {
                AreaDeVentaActual.Nombre = txtNombre.Text;
                await AreaDeVentaService.UpdateAsync(AreaDeVentaActual);
                MessageBox.Show("Área de venta modificada correctamente.");
                AreaDeVentaActual = null;
            }
            else
            {
                await AreaDeVentaService.AddAsync(areaDeVenta);
                MessageBox.Show("Área de venta agregada correctamente.");
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl1.SelectTab(Lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada.");
            tabControl1.SelectTab(Lista);
        }

        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (mostrandoEliminados)
            {
                var activos = await AreaDeVentaService.GetAllAsync();
                ListAreaDeVenta.DataSource = activos?.Where(a => !a.IsDeleted).ToList();

                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                var eliminados = await AreaDeVentaService.GetAllDeletedAsync();
                ListAreaDeVenta.DataSource = eliminados?.Where(a => a.IsDeleted).ToList();

                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightSkyBlue;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }

            mostrandoEliminados = !mostrandoEliminados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarAreaDeVenta();
        }

        private void FiltrarAreaDeVenta()
        {
            var filtrados = FilterList.Where(a => a.Nombre.Contains(txtFiltro.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            ListAreaDeVenta.DataSource = new BindingSource(filtrados, null);
        }
    }
}
