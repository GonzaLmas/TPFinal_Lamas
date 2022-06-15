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
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Precio");
            
        }
        private void cargarGrilla()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                pbxArticulo.Load(listaArticulo[0].ImagenUrl);
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg");
            }
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoArticulo nuevo = new frmNuevoArticulo();
            nuevo.ShowDialog();
            cargarGrilla();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo selccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(selccionado.ImagenUrl);
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {           
            Articulo seleccionado;

            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmNuevoArticulo modificar = new frmNuevoArticulo(seleccionado);
                MessageBox.Show("Para poder MODIFICAR CORRECTAMENTE el artículo, tiene que BORRAR el signo $ del precio.");
                modificar.ShowDialog();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo.");
            }                            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el artículo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargarGrilla();
                    MessageBox.Show("Artículo eliminado correctamente.");
                }          
                else
                    MessageBox.Show("No se ha podido eliminar el artículo. Por favor intente de nuevo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el artículo. Por favor intente de nuevo");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (filtroOk())
                    return;
               
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = tbxFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }
        
        private bool filtroOk()
        {
            if(cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Complete campo.");
                return true;
            }

            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Complete criterio.");
                return true;
            }

            if(cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbxFiltro.Text))
                {
                    MessageBox.Show("Por favor, cargue algún número.");
                    return true;
                }
                if (!(filtroPrecio(tbxFiltro.Text)))
                {
                    MessageBox.Show("Solamente se permiten cargar números.");
                    return true;
                }
            }
              
            return false;
        }

        private bool filtroPrecio(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void tbxBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaBusqueda;
            string busqueda = tbxBusquedaRapida.Text;

            if (busqueda != "")
            {
                listaBusqueda = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()));
            }
            else
            {
                listaBusqueda = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaBusqueda;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void lblListaCom_Click(object sender, EventArgs e)
        {
            List<Articulo> listaCompleta;

            listaCompleta = listaArticulo;
            dgvArticulos.DataSource = listaCompleta;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalles selec = new frmDetalles(seleccionado);
                selec.ShowDialog();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Elija un artículo para poder ver los detalles.");
            }
        }   
    }
}
