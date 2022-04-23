using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulo;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Categorias");
                cboCampo.Items.Add("Precio");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulo.DataSource = listaArticulo;
            ocultarColumnas();
            
            cargarImagen(listaArticulo[0].ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder-1024x683.png");

            }
        }
        private void ocultarColumnas()
        {
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo Alta = new frmAltaArticulo();
            Alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloModificado;
            articuloModificado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(articuloModificado);
            modificar.ShowDialog();
            cargar();
        }

        

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo eliminarArticulo;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quiere eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == respuesta)
                {
                    eliminarArticulo = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(eliminarArticulo.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();    
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);
                validarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro.Length >=3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categorias.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Empresa.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Es mayor que");
                cboCriterio.Items.Add("Es menor que");
                cboCriterio.Items.Add("Es igual que");

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex == -1)
            {
                lblValidarFiltro.Text = "Debe seleccionar un campo\n" +
                    " para realizar la busqueda.";
                return true;
            }
            if (cboCriterio.SelectedIndex == -1)
            {
                lblValidarFiltro.Text = "Debe seleccionar un criterio\n" + "para realizar la busqueda.";
                return true;
            }
            
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    lblValidarFiltro.Text = "Debe ingresar un número\n" +
                        "para realizar la busqueda.";
                    return true;
                }
                
                
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    lblValidarFiltro.Text = "Ingrese solo números,\n" +
                        " por favor.";
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {

            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void dgvArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetalleCodigo.Text = dgvArticulo.CurrentRow.Cells["Codigo"].Value.ToString();
            txtDetalleNombre.Text = dgvArticulo.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDetalleDescripcion.Text = dgvArticulo.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtDetalleEmpresa.Text = dgvArticulo.CurrentRow.Cells["Empresa"].Value.ToString();
            txtDetalleCategorias.Text = dgvArticulo.CurrentRow.Cells["Categorias"].Value.ToString();
            txtDetallePrecio.Text = dgvArticulo.CurrentRow.Cells["Precio"].Value.ToString();
        }

       
    }
}
