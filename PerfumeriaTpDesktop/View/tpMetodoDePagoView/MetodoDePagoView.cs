using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfumeriaServices.Models;
using PerfumeriaServices.Interfaces;
using PerfumeriaServices.Services;

namespace PerfumeriaTpDesktop.View.tpMetodoDePago
{
    public partial class MetodoDePagoView : Form
    {
        private readonly IMetodoDePagoService MetodoDePagoService = new MetodoDePagoService();
        private BindingSource ListMetodoDePago = new BindingSource();
        private List<pMetodoDePago> FilterList = new List<pMetodoDePago>();
        private pMetodoDePago? MetodoDePagoActual;
        private bool mostrandoEliminados = false;

        public MetodoDePagoView()
        {
            InitializeComponent();
            dataGridViewMetodosDePago.DataSource = ListMetodoDePago;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            var metodos = await MetodoDePagoService.GetAllAsync();
            ListMetodoDePago.DataSource = metodos?.Where(m => !m.IsDeleted).ToList();
            FilterList = (List<pMetodoDePago>)ListMetodoDePago.DataSource;

            // Ocultar columnas innecesarias
            dataGridViewMetodosDePago.Columns[0].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            tabControl1.SelectTab(AgregarEditar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MetodoDePagoActual = (pMetodoDePago)ListMetodoDePago.Current;

            txtNombre.Text = MetodoDePagoActual.Nombre;
            tabControl1.SelectTab(AgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListMetodoDePago.Current is pMetodoDePago metodo)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el método de pago {metodo.Nombre}?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    metodo.IsDeleted = true;
                    await MetodoDePagoService.UpdateAsync(metodo);
                    await CargarGrilla();
                    MessageBox.Show("Método de pago eliminado correctamente.");
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

            var metodoDePago = new pMetodoDePago
            {
                Nombre = txtNombre.Text
            };

            if (MetodoDePagoActual != null)
            {
                MetodoDePagoActual.Nombre = txtNombre.Text;
                await MetodoDePagoService.UpdateAsync(MetodoDePagoActual);
                MessageBox.Show("Método de pago modificado correctamente.");
                MetodoDePagoActual = null;
            }
            else
            {
                await MetodoDePagoService.AddAsync(metodoDePago);
                MessageBox.Show("Método de pago agregado correctamente.");
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
                var activos = await MetodoDePagoService.GetAllAsync();
                ListMetodoDePago.DataSource = activos?.Where(m => !m.IsDeleted).ToList();

                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                var eliminados = await MetodoDePagoService.GetAllDeletedAsync();
                ListMetodoDePago.DataSource = eliminados?.Where(m => m.IsDeleted).ToList();

                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightSkyBlue;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }

            mostrandoEliminados = !mostrandoEliminados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarMetodoDePago();
        }

        private void FiltrarMetodoDePago()
        {
            var filtrados = FilterList.Where(m => m.Nombre.Contains(txtFiltro.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            ListMetodoDePago.DataSource = new BindingSource(filtrados, null);
        }
    }
}