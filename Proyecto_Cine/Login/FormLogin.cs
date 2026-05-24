using Proyecto_Cine.Login;
using Proyecto_Cine.Usuarios;

namespace Proyecto_Cine
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _service = new UsuarioService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RecordarSesion)
            {
                txbEmail.Text = Properties.Settings.Default.EmailGuardado;
                txbPassword.Text = Properties.Settings.Default.PasswordGuardado;
            }
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Ingresa email y contraseña.";
                lblError.Visible = true;
                return;
            }

            btnEntrar.Enabled = false;
            btnEntrar.Text = "Entrando...";
            lblError.Visible = false;

            var usuario = await _service.Login(email, password);

            btnEntrar.Enabled = true;
            btnEntrar.Text = "Entrar";

            if (usuario != null)
            {
                Properties.Settings.Default.RecordarSesion = false;
                Properties.Settings.Default.EmailGuardado = "";
                Properties.Settings.Default.PasswordGuardado = "";
                Properties.Settings.Default.Save();

                SesionActual.Usuario = usuario;

                var formUsuarios = new FormUsuarios();
                formUsuarios.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Email o contraseña incorrectos.";
                lblError.Visible = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var formReg = new FormRegistro();
            formReg.ShowDialog();
        }
    }
}
