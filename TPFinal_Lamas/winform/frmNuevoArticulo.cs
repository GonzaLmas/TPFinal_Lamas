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

namespace winform
{
    public partial class frmNuevoArticulo : Form
    {
        private Articulo articulo = null;
        public frmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {          
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;                
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Dispositivo = (Categoria)cbxDispositivo.SelectedItem;
                articulo.ImagenUrl = tbxImagen.Text;
                articulo.Precio = float.Parse(tbxPrecio.Text);

                if (validarArticulo())
                    return;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("El artículo fue modificado exitosamente.");
                    Close();
                }
                if(articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("El artículo fue agregado correctamente.");
                    Close();
                }                             
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede agregar el artículo SIN código, nombre o precio (solamente números). Intente de nuevo.");                
            }
        }

        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxDispositivo.DataSource = categoriaNegocio.listar();
                cbxDispositivo.ValueMember = "Id";
                cbxDispositivo.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagen.Text = articulo.ImagenUrl;
                    tbxPrecio.Text = articulo.Precio.ToString("C3");
                    cargarImagen(articulo.ImagenUrl);
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxDispositivo.SelectedValue = articulo.Dispositivo.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tbxImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                pbxNuevoArticulo.Load(tbxImagen.Text);
            }
            catch (Exception ex)
            {
                pbxNuevoArticulo.Load("https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg");
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxNuevoArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxNuevoArticulo.Load("https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg");
            }
        }

        public bool validarArticulo()
        {
            if(string.IsNullOrEmpty(tbxCodigo.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(tbxPrecio.Text))
            {
                return true;
            }           
            return false;   
        }
    }
}
