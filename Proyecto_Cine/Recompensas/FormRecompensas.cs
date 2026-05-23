using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cine.Recompensas
{
    public partial class FormRecompensas : Form
    {
        RecompensasService service = new RecompensasService();
        public FormRecompensas()
        {
            InitializeComponent();

        }

        private async void CargarDatos()
        {
            DgDatosRecom.DataSource = null;
            DgDatosRecom.DataSource = await service.ObtenerRecompensas();
        }

        private void LimpiarCampos()
        {
            txbIDR.Clear();
            txbNombreR.Clear();
            txbDescripcionR.Clear();
            txbPuntosR.Clear();
            txbStockR.Clear();
            textBox1.Clear();

            cbTipoR.SelectedIndex = -1;

            Disponible.Checked = false;
        }


        private void FormRecompensas_Load(object sender, EventArgs e)
        {
            CargarDatos();

            // COMBOBOX TIPO
            cbTipoR.Items.Add("Snack");
            cbTipoR.Items.Add("VIP");
            cbTipoR.Items.Add("Combo");
            cbTipoR.Items.Add("Boleto");
        }

        private async void btnActualizarR_Click(object sender, EventArgs e)
        {
            // VALIDACIONES
            if (txbIDR.Text == "" ||
                txbNombreR.Text == "" ||
                txbDescripcionR.Text == "" ||
                txbPuntosR.Text == "" ||
                txbStockR.Text == "" ||
                cbTipoR.Text == "" ||
                txbCategoriaR.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // CREAR OBJETO
            ModelRecompensas recompensa = new ModelRecompensas()
            {
                Id = int.Parse(txbIDR.Text),
                Nombre = txbNombreR.Text,
                Descripcion = txbDescripcionR.Text,
                PuntosNecesarios = int.Parse(txbPuntosR.Text),
                Stock = int.Parse(txbStockR.Text),
                Tipo = cbTipoR.Text,
                Imagen = textBox1.Text,
                Disponible = Disponible.Checked,
                CategoriaId = int.Parse(txbCategoriaR.Text)
            };

            // ENVIAR A LA API
            bool respuesta = await service.ActualizarRecompensa(recompensa.Id, recompensa);

            // RESPUESTA
            if (respuesta)
            {
                MessageBox.Show("Recompensa actualizada correctamente");

                // RECARGAR GRID
                CargarDatos();

                // LIMPIAR CAMPOS
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la recompensa");
            }
        }

        private void lbCostoR_Click(object sender, EventArgs e)
        {

        }

        private async void btnAgregarR_Click(object sender, EventArgs e)
        {
            // VALIDACIONES
            if (txbIDR.Text == "" ||
                txbNombreR.Text == "" ||
                txbDescripcionR.Text == "" ||
                txbPuntosR.Text == "" ||
                txbStockR.Text == "" ||
                cbTipoR.Text == ""||
                txbCategoriaR.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // CREAR OBJETO
            ModelRecompensas recompensa = new ModelRecompensas()
            {
                Id = int.Parse(txbIDR.Text),
                Nombre = txbNombreR.Text,
                Descripcion = txbDescripcionR.Text,
                PuntosNecesarios = int.Parse(txbPuntosR.Text),
                Stock = int.Parse(txbStockR.Text),
                Tipo = cbTipoR.Text,
                Imagen = textBox1.Text,
                Disponible = Disponible.Checked,
                CategoriaId = int.Parse(txbCategoriaR.Text)
            };

            // ENVIAR A LA API
            bool respuesta = await service.AgregarRecompensa(recompensa);

            // RESPUESTA
            if (respuesta)
            {
                MessageBox.Show("Recompensa agregada correctamente");

                // RECARGAR GRID
                CargarDatos();

                // LIMPIAR CAMPOS
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar la recompensa");
            }
        }

        private async void btnEliminarR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbIDR.Text);

            bool respuesta = await service.EliminarRecompensa(id);

            if (respuesta)
            {
                MessageBox.Show("Eliminado");

                CargarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void DgDatosRecom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgDatosRecom.CurrentRow != null)
            {
                txbIDR.Text = DgDatosRecom.CurrentRow.Cells[0].Value.ToString();
                txbNombreR.Text = DgDatosRecom.CurrentRow.Cells[1].Value.ToString();
                txbDescripcionR.Text = DgDatosRecom.CurrentRow.Cells[2].Value.ToString();
                txbPuntosR.Text = DgDatosRecom.CurrentRow.Cells[3].Value.ToString();
                txbStockR.Text = DgDatosRecom.CurrentRow.Cells[4].Value.ToString();
                cbTipoR.Text = DgDatosRecom.CurrentRow.Cells[5].Value.ToString();
                textBox1.Text = DgDatosRecom.CurrentRow.Cells[6].Value.ToString();

                Disponible.Checked =
                    Convert.ToBoolean(DgDatosRecom.CurrentRow.Cells[7].Value);
            }
        }



        private void btnLimpiarR_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private async void btnbuscarR_Click(object sender, EventArgs e)
        {
            // VALIDAR ID
            if (txbIDR.Text == "")
            {
                MessageBox.Show("Ingrese un ID");

                return;
            }

            int id = int.Parse(txbIDR.Text);

            // BUSCAR
            ModelRecompensas? recompensa =
                await service.ObtenerPorId(id);

            // VALIDAR RESULTADO
            if (recompensa != null)
            {
                txbNombreR.Text = recompensa.Nombre;

                txbDescripcionR.Text = recompensa.Descripcion;

                txbPuntosR.Text =
                    recompensa.PuntosNecesarios.ToString();

                txbStockR.Text =
                    recompensa.Stock.ToString();

                cbTipoR.Text =
                    recompensa.Tipo;

                textBox1.Text =
                    recompensa.Imagen;

                Disponible.Checked =
                    recompensa.Disponible;
            }
            else
            {
                MessageBox.Show("Recompensa no encontrada");
            }
        }
    }
}