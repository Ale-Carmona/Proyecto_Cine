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
            dgDatosLog.DataSource = null;

            var logros = await _service.ObtenerLogros();

            dgDatosLog.DataSource = logros;

            comboBox1.DataSource = logros;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
        }

        // =========================================
        // CARGAR CATEGORIAS
        // =========================================
        private void CargarCategorias()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Asistencia");
            comboBox1.Items.Add("Canjes");
            comboBox1.Items.Add("VIP");
            comboBox1.Items.Add("Especiales");
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
            txbNombreL.Clear();
            txbDescripcionL.Clear();
            txbPuntosL.Clear();
            txbRequisitosL.Clear();

            cbActivoL.Checked = false;

            cmbCategoriaL.SelectedIndex = -1;

            logroSeleccionadoId = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgregarL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNombreL.Text) ||
                 cmbCategoriaL.SelectedIndex < 0)
            {
                MessageBox.Show("Nombre y Categoría son obligatorios.");
                return;
            }

            if (!int.TryParse(txbPuntosL.Text, out int puntos))
            {
                MessageBox.Show("Los puntos deben ser un número.");
                return;
            }

            ModelLogro logro = new ModelLogro
            {
                Nombre = txbNombreL.Text.Trim(),
                Descripcion = txbDescripcionL.Text.Trim(),
                Puntos = puntos,
                Requisitos = txbRequisitosL.Text.Trim(),
                CategoriaId = cmbCategoriaL.SelectedIndex + 1,
                Activo = cbActivoL.Checked,
                FechaCreacion = DateTime.Now
            };

            bool resultado = await _service.AgregarLogro(logro);

            if (resultado)
            {
                MessageBox.Show("Logro agregado correctamente.");
                await CargarLogros();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar el logro.");
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
                Nombre = txbNombreL.Text,
                Descripcion = txbDescripcionL.Text,
                Puntos = Convert.ToInt32(txbPuntosL.Text),
                Requisitos = txbRequisitosL.Text,
                CategoriaId = cmbCategoriaL.SelectedIndex + 1,
                Activo = cbActivoL.Checked
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
            if (!int.TryParse(txbUsuarioL.Text, out int usuarioId))
            {
                MessageBox.Show("Ingresa un ID de usuario válido.");
                return;
            }

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un logro.");
                return;
            }

            ModelUsuario logroUsuario = new ModelUsuario
            {
                UsuarioId = usuarioId,
                LogroId = Convert.ToInt32(comboBox1.SelectedValue),
                FechaObtencion = DateTime.Now
            };

            bool resultado = await _service.AsignarLogro(logroUsuario);

            if (resultado)
            {
                MessageBox.Show("Logro asignado correctamente.");
                await CargarLogrosUsuarios();
            }
            else
            {
                MessageBox.Show("Error al asignar (puede que el usuario ya tenga ese logro).");
            }
        }
    }
}
