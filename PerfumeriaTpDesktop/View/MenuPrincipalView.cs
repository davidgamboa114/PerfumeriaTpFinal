using PerfumeriaTpDesktop.View.tpAreaDeVenta;
using PerfumeriaTpDesktop.View.tpClienteView;
using PerfumeriaTpDesktop.View.tpMetodoDePago;
using PerfumeriaTpDesktop.View.tpProductoView;
using PerfumeriaTpDesktop.View.tpVentaView;

namespace PerfumeriaTpDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void btnClientesMain_Click(object sender, EventArgs e)
        {

            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentaView ventaView = new VentaView();
            ventaView.ShowDialog();
        }

        private void btnAreasDeVentaMain_Click(object sender, EventArgs e)
        {
            AreaDeVentaView areaDeVentaView = new AreaDeVentaView();
            areaDeVentaView.ShowDialog();
        }

        private void btnMetodosDePagoMain_Click(object sender, EventArgs e)
        {
            MetodoDePagoView metodoDePagoView = new MetodoDePagoView();
            metodoDePagoView.ShowDialog();
        }

        private void btnProductoMain_Click(object sender, EventArgs e)
        {
            ProductoVIew productoView = new ProductoVIew();
            productoView.ShowDialog();
        }

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del sistema??", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
