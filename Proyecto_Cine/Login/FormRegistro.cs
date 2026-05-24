using Proyecto_Cine.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cine.Login
{
    public partial class FormRegistro : Form
    {
        private readonly UsuarioService _service = new UsuarioService();
        public FormRegistro()
        {
            InitializeComponent();
        }

        private async void btnResgistrarseRes_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txbNombreRes.Text) ||
                string.IsNullOrWhiteSpace(txbCorreoRes.Text) ||
                string.IsNullOrWhiteSpace(txbPasswordRes.Text) ||
                string.IsNullOrWhiteSpace(txbConfirmar.Text))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                lblError.Visible = true;
                return;
            }

            // BUG CORREGIDO: comparaba con txbConfirmarRes que no existe en el Designer
            if (txbPasswordRes.Text != txbConfirmar.Text)
            {
                lblError.Text = "Las contraseñas no coinciden.";
                lblError.Visible = true;
                txbConfirmar.Clear();
                txbConfirmar.Focus();
                return;
            }

            if (!txbCorreoRes.Text.Contains("@") || !txbCorreoRes.Text.Contains("."))
            {
                lblError.Text = "Ingresa un correo valido.";
                lblError.Visible = true;
                return;
            }

            btnResgistrarseRes.Enabled = false;
            btnResgistrarseRes.Text = "Registrando...";

            var nuevoUsuario = new ModelUsuario
            {
                Nombre = txbNombreRes.Text.Trim(),
                Email = txbCorreoRes.Text.Trim().ToLower(),
                // BUG CORREGIDO: estaba usando txbNombreRes.Text en lugar de txbPasswordRes.Text
                Password = txbPasswordRes.Text,
                Puntos = 0,
                Membresia = "Normal",
                Activo = true,
                FechaRegistro = DateTime.Now
            };

            bool ok = await _service.AgregarUsuario(nuevoUsuario);

            btnResgistrarseRes.Enabled = true;
            btnResgistrarseRes.Text = "Registrarse";

            if (ok)
            {
                MessageBox.Show(
                    "Registro exitoso!\nYa puedes iniciar sesion con tu correo.",
                    "Bienvenido a CineClub",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblError.Text = "Error al registrar. Intenta de nuevo.";
                lblError.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
