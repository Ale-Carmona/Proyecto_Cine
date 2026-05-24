using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Cine.Logros;
using Proyecto_Cine.Recompensas;

namespace Proyecto_Cine.Usuarios
{
    public partial class FormUsuarios : Form
    {
        private readonly UsuarioService _service = new UsuarioService();
        private int _idSeleccionado = 0;
        public FormUsuarios()
        {
            InitializeComponent();
        }
        // =============================================
        // CARGAR AL ABRIR
        // =============================================
        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
            // Llenar combobox de membresía
            cmbMembresiaU.Items.Clear();
            cmbMembresiaU.Items.AddRange(new[] { "Normal", "VIP", "Premium" });

            await CargarUsuarios();
        }

        // =============================================
        // CARGAR GRID
        // =============================================
        private async Task CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            var lista = await _service.ObtenerUsuarios();
            dgvUsuarios.DataSource = lista;
        }

        // =============================================
        // LIMPIAR CAMPOS
        // =============================================
        private void Limpiar()
        {
            txbIdU.Clear();
            txbNombreU.Clear();
            txbEmailU.Clear();
            txbContraeñaU.Clear();
            txbPuntosU.Clear();
            cmbMembresiaU.SelectedIndex = -1;
            hkActivoU.Checked = false;
            _idSeleccionado = 0;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvUsuarios.Rows[e.RowIndex];

            _idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
            txbIdU.Text = _idSeleccionado.ToString();
            txbNombreU.Text = row.Cells["Nombre"].Value?.ToString();
            txbEmailU.Text = row.Cells["Email"].Value?.ToString();
            txbContraeñaU.Text = row.Cells["Password"].Value?.ToString();
            txbPuntosU.Text = row.Cells["Puntos"].Value?.ToString();
            cmbMembresiaU.Text = row.Cells["Membresia"].Value?.ToString();
            hkActivoU.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
        }

        private void lbMenmbresiaU_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscarU_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbIdU.Text, out int id))
            {
                MessageBox.Show("Ingresa un ID válido.");
                return;
            }

            var u = await _service.ObtenerPorId(id);
            if (u != null)
            {
                _idSeleccionado = u.Id;
                txbNombreU.Text = u.Nombre;
                txbEmailU.Text = u.Email;
                txbContraeñaU.Text = u.Password;
                txbPuntosU.Text = u.Puntos.ToString();
                cmbMembresiaU.Text = u.Membresia;
                hkActivoU.Checked = u.Activo;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private async void btnAgregarU_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var usuario = new ModelUsuario
            {
                Nombre = txbNombreU.Text.Trim(),
                Email = txbEmailU.Text.Trim(),
                Password = txbContraeñaU.Text.Trim(),
                Puntos = int.TryParse(txbPuntosU.Text, out int p) ? p : 0,
                Membresia = cmbMembresiaU.Text,
                Activo = hkActivoU.Checked,
                FechaRegistro = DateTime.Now
            };

            bool ok = await _service.AgregarUsuario(usuario);
            if (ok)
            {
                MessageBox.Show("Usuario agregado correctamente.");
                await CargarUsuarios();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario.");
            }
        }

        private async void btnActualizarU_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }
            if (!ValidarCampos()) return;

            var usuario = new ModelUsuario
            {
                Id = _idSeleccionado,
                Nombre = txbNombreU.Text.Trim(),
                Email = txbEmailU.Text.Trim(),
                Password = txbContraeñaU.Text.Trim(),
                Puntos = int.TryParse(txbPuntosU.Text, out int p) ? p : 0,
                Membresia = cmbMembresiaU.Text,
                Activo = hkActivoU.Checked
            };

            bool ok = await _service.ActualizarUsuario(_idSeleccionado, usuario);
            if (ok)
            {
                MessageBox.Show("Usuario actualizado.");
                await CargarUsuarios();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }

        private async void btnEliminarU_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            var confirm = MessageBox.Show(
                "¿Eliminar este usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            bool ok = await _service.EliminarUsuario(_idSeleccionado);
            if (ok)
            {
                MessageBox.Show("Usuario eliminado.");
                await CargarUsuarios();
                Limpiar();
            }
        }

        private void btnLimpiarU_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIrLogros_Click(object sender, EventArgs e)
        {
            var f = new FormLogro();
            f.Show();
        }

        private void btnIrRecompensas_Click(object sender, EventArgs e)
        {
            var f = new FormRecompensas();
            f.Show();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txbNombreU.Text) ||
                string.IsNullOrWhiteSpace(txbEmailU.Text) ||
                string.IsNullOrWhiteSpace(txbContraeñaU.Text))
            {
                MessageBox.Show("Nombre, email y contraseña son obligatorios.");
                return false;
            }
            return true;
        }
    }

}
