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
using System.Configuration;
using System.IO;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio(); 
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboEmpresa.DataSource = marcaNegocio.listar();
                cboEmpresa.ValueMember = "Id";
                cboEmpresa.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboEmpresa.SelectedValue = articulo.Empresa.Id;
                    cboCategoria.SelectedValue = articulo.Categorias.Id;
                    
                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (validarTextos())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Empresa = (Marca)cboEmpresa.SelectedItem;
                    articulo.Categorias = (Categoria)cboCategoria.SelectedItem;
                    articulo.ImagenUrl = txtImagenUrl.Text;

                if (string.IsNullOrEmpty(txtPrecio.Text))
                    MessageBox.Show("Debe ingresar un número por favor.");
                else
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado correctamente.");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado correctamente.");
                    
                }
                if(archivo !=null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxAltaArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder-1024x683.png");

            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; |png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
               
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private bool validarTextos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo Código no puede estar vacio.\n" +
                    "Ingrese el código del artículo por favor.", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio.\n" +
                    "Ingrese el nombre del artículo por favor.", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción no puede estar vacio.\n" +
                    "Ingrese la descripción del artículo por favor.", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
             {
                MessageBox.Show("El campo Precio no puede estar vacio.\n" +
                    "Ingrese el precio del artículo por favor.","Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
             }
            return false;
        }
    }
}
