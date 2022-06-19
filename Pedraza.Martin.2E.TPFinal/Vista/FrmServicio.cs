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
    public partial class FrmServicio : Form
    {
        private Centro<Cliente> centro;
        private string jacuzzi;
        private string sauna;
        private string masaje;
        public FrmServicio(Centro<Cliente> centro, string jacuzzi, string sauna, string masaje)
        {
            InitializeComponent();
            this.centro = centro;
            this.jacuzzi = jacuzzi;
            this.sauna = sauna;
            this.masaje = masaje;
        }
        /// <summary>
        /// Cargara los valores del ListBox y del ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmServicio_Load(object sender, EventArgs e)
        {
            foreach (Cliente item in this.centro.Lista)
            {
                this.listboxClientes.Items.Add(item.Dni);
            }
            this.cboTipo.Items.Add("Jacuzzi");
            this.cboTipo.Items.Add("Sauna");
            this.cboTipo.Items.Add("Masaje");
            this.cboTipo.SelectedIndex = 0;
            this.txtCosto.Text = this.jacuzzi;
        }
        /// <summary>
        /// Cada vez que cambie el elemento, mostrara el valor segun el tipo seleccionado
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
        /// Luego de validar los campos agregar un servicio nuevo al Cliente seleccionado en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtDuracion.Text))
            {
                int duracion = int.Parse(this.txtDuracion.Text);
                double costo = double.Parse(this.txtCosto.Text.PrimerizarPalabra());
                DateTime fecha = DateTime.Parse(this.dtpFecha.Text);
                ETipo tipo = (ETipo)Enum.Parse(typeof(ETipo), this.cboTipo.Text);
                bool pago = this.chboPago.Checked;
                Servicio servicio = new Servicio(duracion, costo, fecha, tipo, pago);

                int indice = this.centro.BuscarIndice(this.listboxClientes.Text);
                if (indice != int.MinValue)
                {
                    if (this.centro.Lista[indice] + servicio)
                    {
                        Cliente c = this.centro.Lista[indice];
                        MessageBox.Show($"Servicio agregado a {c.Nombre} {c.Apellido}");
                        this.txtDuracion.Text = string.Empty;
                        this.lblDuracionError.Text = string.Empty;
                        this.chboPago.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("El servicio ya habia sido registrado");
                    }
                }
                else
                {
                    txtDuracion_Leave(sender, e);
                    this.lblNombre.ForeColor = Color.Red;
                    this.lblNombre.Text = "No se eligio ningun cliente";
                }
            }
            else
            {
                this.txtDuracion_Leave(sender, e);
            }
        }
        private void listboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.centro.BuscarIndice(this.listboxClientes.Text);
            this.lblNombre.ForeColor = Color.Black;
            this.lblNombre.Text = $"{this.centro.Lista[indice].Nombre} {this.centro.Lista[indice].Apellido}";
        }
        /// <summary>
        /// Cierra el form
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
