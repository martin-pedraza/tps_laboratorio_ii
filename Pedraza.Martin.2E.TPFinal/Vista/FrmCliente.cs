using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmCliente : Form
    {
        private Centro<Cliente> centro;
        private string jacuzzi;
        private string sauna;
        private string masaje;

        public FrmCliente(Centro<Cliente> centro, string jacuzzi, string sauna, string masaje)
        {
            InitializeComponent();
            this.centro = centro;
            this.jacuzzi = jacuzzi;
            this.sauna = sauna;
            this.masaje = masaje;
        }
        /// <summary>
        /// Luego de validar los campos necesarios agregará un cliente y un servicio con la informacion brindada si los mismos no existian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.txtApellido.Text)
                || string.IsNullOrWhiteSpace(this.txtNombre.Text)
                || string.IsNullOrWhiteSpace(this.txtTelefono.Text)
                || string.IsNullOrWhiteSpace(this.txtDni.Text)
                || string.IsNullOrWhiteSpace(this.txtDuracion.Text)))
            {
                int dni = int.Parse(this.txtDni.Text);
                string nombre = this.txtNombre.Text.ToUpper();
                string apellido = this.txtApellido.Text.ToUpper();
                string telefono = this.txtTelefono.Text;
                Cliente nuevoCliente = new Cliente(dni, nombre, apellido, telefono);

                int duracion = int.Parse(this.txtDuracion.Text);
                double costo = double.Parse(this.txtCosto.Text.PrimerizarPalabra());
                DateTime fecha = DateTime.Parse(this.dtpFecha.Text);
                ETipo tipo = (ETipo)Enum.Parse(typeof(ETipo), this.cboTipo.Text);
                bool pago = this.chboPago.Checked;
                Servicio servicio = new Servicio(duracion, costo, fecha, tipo, pago);

                if (this.centro + nuevoCliente && nuevoCliente + servicio)
                {
                    MessageBox.Show("Cliente agregado");
                }
                else
                {
                    MessageBox.Show("Cliente ya existe");
                }
                LimpiarCampos();
            }
            else
            {
                txtTelefono_Leave(sender, e);
                txtApellido_Leave(sender, e);
                txtDni_Leave(sender, e);
                txtNombre_Leave(sender, e);
                txtDuracion_Leave(sender, e);
            }
        }
        /// <summary>
        /// Limpiará todos los campos para agregar otra informacion
        /// </summary>
        private void LimpiarCampos()
        {
            this.txtApellido.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.txtDni.Text = String.Empty;
            this.lblApellidoError.Text = String.Empty;
            this.lblDniError.Text = String.Empty;
            this.lblNombreError.Text = String.Empty;
            this.lblTelefonoError.Text = String.Empty;
        }
        /// <summary>
        /// Cerrara el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista sino muestra por label el error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtDni.Text, out int dni) || dni < 1000000 || dni > 100000000)
            {
                this.txtDni.Text = String.Empty;
                this.lblDniError.Text = "El DNI debe ser mayor a 1.000.000 y menor a 100.000.000";
            }
            else
            {
                this.lblDniError.Text = string.Empty;
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista sino muestra por label el error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.LengthWord(3) || this.txtNombre.Text.NoNumber())
            {
                this.txtNombre.Text = String.Empty;
                this.lblNombreError.Text = "Nombre no valido";
            }
            else
            {
                this.lblNombreError.Text = string.Empty;
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista sino muestra por label el error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (this.txtApellido.Text.LengthWord(3) || this.txtApellido.Text.NoNumber())
            {
                this.txtApellido.Text = String.Empty;
                this.lblApellidoError.Text = "Apellido no valido";
            }
            else
            {
                this.lblApellidoError.Text = string.Empty;
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista sino muestra por label el error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (this.txtTelefono.Text.LengthWord(8))
            {
                this.txtTelefono.Text = String.Empty;
                this.lblTelefonoError.Text = "Telefono muy corto";
            }
            else
            {
                this.lblTelefonoError.Text = string.Empty;
            }
        }
        /// <summary>
        /// Cargara y seleccionará los valores del ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.cboTipo.Items.Add("Jacuzzi");
            this.cboTipo.Items.Add("Sauna");
            this.cboTipo.Items.Add("Masaje");
            this.cboTipo.SelectedIndex = 0;
            this.txtCosto.Text = this.jacuzzi;
        }
        /// <summary>
        /// Cada vez que se cambie el indice del ComboBox cambiará los valores del costo segun el tipo del Servicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboTipo.SelectedItem.ToString())
            {
                case "Masaje":
                    this.txtCosto.Text = this.masaje + " -> " + int.Parse(this.masaje) * 0.9;
                    this.lblPromo.Text = "Miercoles con descuento: 10%";
                    break;
                case "Sauna":
                    this.txtCosto.Text = this.sauna + " -> " + int.Parse(this.sauna) * 0.85;
                    this.lblPromo.Text = "Miercoles con descuento: 15%";
                    break;
                default:
                    this.txtCosto.Text = this.jacuzzi + " -> " + int.Parse(this.jacuzzi) * 0.75;
                    this.lblPromo.Text = "Miercoles con descuento: 25%";
                    break;
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista sino muestra por label el error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDuracion_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtDuracion.Text, out int duracion) || duracion <= 0)
            {
                this.txtDuracion.Text = String.Empty;
                this.lblDuracionError.Text = "Valor no valido";
            }
            else
            {
                this.lblDuracionError.Text = string.Empty;
            }
        }
    }
}
