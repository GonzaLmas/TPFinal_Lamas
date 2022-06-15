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
    public partial class frmDetalles : Form
    {
        private Articulo articulo = null;
        
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbxDetMarca.DataSource = marcaNegocio.listar();
            cbxDetMarca.ValueMember = "Id";
            cbxDetMarca.DisplayMember = "Descripcion";
            cbxDetDisp.DataSource = categoriaNegocio.listar();
            cbxDetDisp.ValueMember = "Id";
            cbxDetDisp.DisplayMember = "Descripcion";          

            tbxDetCod.Text = articulo.Codigo;
            tbxDetNom.Text = articulo.Nombre;
            tbxDetDesc.Text = articulo.Descripcion;              
            tbxDetImag.Text = articulo.ImagenUrl;
            tbxDetPrecio.Text = articulo.Precio.ToString();
            cbxDetMarca.SelectedValue = articulo.Marca.Id;
            cbxDetDisp.SelectedValue = articulo.Dispositivo.Id;

            cargarImagen(articulo.ImagenUrl);           
        }

        private void cargarImagen(string imagenUrl)
        {
            try
            {
                pbxDetalles.Load(imagenUrl);
            }
            catch (Exception ex)
            {
                pbxDetalles.Load("https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg");
            }
        }
    }
}
