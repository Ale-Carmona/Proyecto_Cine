using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cine.Logros
{
    public partial class FormLogro : Form
    {
        private readonly LogroService _service = new LogroService();

        private int logroSeleccionadoId = 0;
        public FormLogro()
        {
            InitializeComponent();
        }

        // =========================================
        // CARGAR LOGROS
        // =========================================
        private async Task CargarLogros()
        {
            dgvLogros.DataSource = null;

            var logros = await _service.ObtenerLogros();

            dgvLogros.DataSource = logros;

            cbLogro.DataSource = logros;
            cbLogro.DisplayMember = "Nombre";
            cbLogro.ValueMember = "Id";
        }

        // =========================================
        // CARGAR CATEGORIAS
        // =========================================
        private void CargarCategorias()
        {
            cbCategoria.Items.Clear();

            cbCategoria.Items.Add("Asistencia");
            cbCategoria.Items.Add("Canjes");
            cbCategoria.Items.Add("VIP");
            cbCategoria.Items.Add("Especiales");
        }

        // =========================================
        // CARGAR LOGROS USUARIO
        // =========================================
        private async Task CargarLogrosUsuarios()
        {
            dgvLogrosUsuarios.DataSource = null;

            var lista = await _service.ObtenerLogrosUsuario();

            dgvLogrosUsuarios.DataSource = lista;
        }

        // =========================================
        // LIMPIAR
        // =========================================
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPuntos.Clear();
            txtRequisitos.Clear();

            chkActivo.Checked = false;

            cbCategoria.SelectedIndex = -1;

            logroSeleccionadoId = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgregarL_Click(object sender, EventArgs e)
        {
            ModelLogro logro = new ModelLogro()
            {
                Nombre = txbNombreL.Text,
                Descripcion = txbDescripcionL.Text,
                Puntos = Convert.ToInt32(txbPuntosL.Text),
                Requisitos = txbRequisitosL.Text,
                CategoriaId = cmbCategoriaL.SelectedIndex + 1,
                Activo = cbActivoL.Checked,
                FechaCreacion = DateTime.Now
            };

            bool resultado =
                await _service.AgregarLogro(logro);

            if (resultado)
            {
                MessageBox.Show("Logro agregado");

                await CargarLogros();

                Limpiar();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private async void btnActualizarL_Click(object sender, EventArgs e)
        {
            if (logroSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Selecciona un logro"
                );

                return;
            }

            ModelLogro logro = new ModelLogro()
            {
                Id = logroSeleccionadoId,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Puntos = Convert.ToInt32(txtPuntos.Text),
                Requisitos = txtRequisitos.Text,
                CategoriaId = cbCategoria.SelectedIndex + 1,
                Activo = chkActivo.Checked
            };

            bool resultado =
                await _service.ActualizarLogro(
                    logroSeleccionadoId,
                    logro
                );

            if (resultado)
            {
                MessageBox.Show("Actualizado");

                await CargarLogros();

                Limpiar();
            }
        }

        private async void btnEliminarL_Click(object sender, EventArgs e)
        {
            if (logroSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Selecciona un logro"
                );

                return;
            }

            bool resultado =
                await _service.EliminarLogro(
                    logroSeleccionadoId
                );

            if (resultado)
            {
                MessageBox.Show("Eliminado");

                await CargarLogros();

                Limpiar();
            }
        }

        private void btnLimpiarL_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private async void btnAsignarL_Click(object sender, EventArgs e)
        {
            ModelUsuario logroUsuario =new ModelUsuario()
    {
        UsuarioId =
            Convert.ToInt32(txbUsuarioL.Text),

        LogroId =
            Convert.ToInt32(
                cbLogro.SelectedValue
            ),

        FechaObtencion = DateTime.Now
    };

            bool resultado =
                await _service.AsignarLogro(
                    logroUsuario
                );

            if (resultado)
            {
                MessageBox.Show(
                    "Logro asignado"
                );

                await CargarLogrosUsuarios();
            }
            else
            {
                MessageBox.Show(
                    "Error al asignar"
                );
            }
        }
    }
}
