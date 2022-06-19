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
    public partial class FrmMenu : Form
    {
        Centro<Cliente> centro;
        public FrmMenu()
        {
            InitializeComponent();
            centro = new Centro<Cliente>();
        }
        /// <summary>
        /// Luego de validar los campos, crea un form de Cliente con los costos de los Servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.txtJacuzzi.Text) 
                || string.IsNullOrWhiteSpace(this.txtSauna.Text) 
                || string.IsNullOrWhiteSpace(this.txtMasaje.Text)))
            {
                if (this.btnLock.ImageIndex == 1)
                {
                    this.lblValidador.Text = String.Empty;
                    string jacuzzi = this.txtJacuzzi.Text;
                    string sauna = this.txtSauna.Text;
                    string masaje = this.txtMasaje.Text;
                    FrmCliente frmCliente = new FrmCliente(this.centro, jacuzzi, sauna, masaje);
                    frmCliente.ShowDialog();
                }
                else
                {
                    this.lblValidador.Text = "Es necesario trabar el candado";
                }
            }
        }
        /// <summary>
        /// Luego de validar campos se creara un form de Servicio pasando la informacion de costos de los Servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.txtJacuzzi.Text) 
                || string.IsNullOrWhiteSpace(this.txtSauna.Text) 
                || string.IsNullOrWhiteSpace(this.txtMasaje.Text)))
            {
                if (this.btnLock.ImageIndex == 1)
                {
                    this.lblValidador.Text = String.Empty;
                    string jacuzzi = this.txtJacuzzi.Text;
                    string sauna = this.txtSauna.Text;
                    string masaje = this.txtMasaje.Text;
                    FrmServicio frmServicio = new FrmServicio(this.centro, jacuzzi, sauna, masaje);
                    frmServicio.ShowDialog();
                }
                else
                {
                    this.lblValidador.Text = "Es necesario trabar el candado";
                }
            }
        }
        /// <summary>
        /// Luego de validar campos cambiará el estado del candado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.txtJacuzzi.Text) 
                || string.IsNullOrWhiteSpace(this.txtSauna.Text) 
                || string.IsNullOrWhiteSpace(this.txtMasaje.Text)))
            {
                this.lblValidador.Text = String.Empty;
                int indiceImagen = this.btnLock.ImageIndex;
                if (indiceImagen == 0)
                {
                    indiceImagen++;
                }
                else
                {
                    indiceImagen--;
                }
                BloqueoPrecio(indiceImagen);
                this.btnLock.ImageIndex = indiceImagen;
            }
        }
        /// <summary>
        /// Si se recibe 1 entonces los txt se deshabilitan sino vuelven a habilitarse
        /// </summary>
        /// <param name="indiceImagen">indice que hace referencia al candado donde 1 esta cerrado o 0 si esta abierto</param>
        private void BloqueoPrecio(int indiceImagen)
        {
            if (indiceImagen == 1)
            {
                this.txtJacuzzi.Enabled = false;
                this.txtSauna.Enabled = false;
                this.txtMasaje.Enabled = false;
            }
            else
            {
                this.txtJacuzzi.Enabled = true;
                this.txtSauna.Enabled = true;
                txtMasaje.Enabled = true;
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtJacuzzi_Leave(object sender, EventArgs e)
        {
            if (!Double.TryParse(this.txtJacuzzi.Text, out double costo))
            {
                this.txtJacuzzi.Text = String.Empty;
                this.lblValidador.Text = "Antes de continua agregando servicios validar costos";
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSauna_Leave(object sender, EventArgs e)
        {
            if (!Double.TryParse(this.txtSauna.Text, out double costo))
            {
                this.txtSauna.Text = String.Empty;
                this.lblValidador.Text = "Antes de continua agregando servicios validar costos";
            }
        }
        /// <summary>
        /// Valida que el string cumple con los requisitos de informacion realista 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMasaje_Leave(object sender, EventArgs e)
        {
            if (!Double.TryParse(this.txtMasaje.Text, out double costo))
            {
                this.txtMasaje.Text = String.Empty;
                this.lblValidador.Text = "Antes de continua agregando servicios validar costos";
            }
        }
        /// <summary>
        /// Abre el form de Registros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FrmRegistros frmRegistros = new FrmRegistros(this.centro);
            frmRegistros.ShowDialog();
        }
    }
}
