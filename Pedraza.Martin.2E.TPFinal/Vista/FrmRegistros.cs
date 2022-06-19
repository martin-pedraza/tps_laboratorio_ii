using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmRegistros : Form
    {
        private Centro<Cliente> centro;
        private Centro<Servicio> servicios;
        CancellationTokenSource cancellation;

        public FrmRegistros(Centro<Cliente> centro)
        {
            InitializeComponent();
            this.centro = centro;
            this.servicios = new Centro<Servicio>();
        }
        /// <summary>
        /// Por medio del GestorDeRegistros se serializa el centro para ser guardado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchivar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivo de Json|*.json";
                saveFileDialog1.ShowDialog();
                GestorDeRegistros.Serializar_JSON(saveFileDialog1.FileName, this.centro);
            }
            catch (RegistrosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Se agregar los Clientes del Centro en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            foreach (Cliente item in this.centro.Lista)
            {
                this.listBoxUsuarios.Items.Add(item.MostrarCliente());
            }
        }
        /// <summary>
        /// Cada vez que se selecciona un cliente, mostrará los Servicios impagos del Cliente en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.centro.BuscarIndice(this.listBoxUsuarios.Text.PrimerizarPalabra());
            if (indice != int.MinValue)
            {
                this.listBoxPagos.Items.Clear();
                foreach (var item in this.centro.Lista[indice].Sevicios)
                {
                    if (!item.EstaPagado)
                    {
                        this.listBoxPagos.Items.Add(item.MostrarPagoPendiente());
                    }
                }
            }
        }
        /// <summary>
        /// Se marcara como pago el Servicio seleccionado y lo hace desaparecer del ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            int indiceCliente = this.centro.BuscarIndice(this.listBoxUsuarios.Text.PrimerizarPalabra());
            int id = int.Parse(this.listBoxPagos.Text.PrimerizarPalabra());

            foreach (var item in this.centro.Lista[indiceCliente].Sevicios)
            {
                if (item.Equals(id))
                {
                    item.EstaPagado = true;
                }
            }
            listBoxUsuarios_SelectedIndexChanged(sender, e);
        }
        /// <summary>
        /// Creará un form de Correo pasando un correo que contiene los servicios sin pagar del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCorreo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Querido cliente: ");
            sb.AppendLine();
            sb.AppendLine("Nos comunicamos con usted con el fin de informar que aun no recibimos el pago de los siguientes servicios prestados: ");
            int indice = this.centro.BuscarIndice(this.listBoxUsuarios.Text.PrimerizarPalabra());
            if (indice != int.MinValue)
            {
                this.listBoxPagos.Items.Clear();
                foreach (var item in this.centro.Lista[indice].Sevicios)
                {
                    if (!item.EstaPagado)
                    {
                        sb.AppendLine(item.MostrarInfoCorreo());
                    }
                }
            }
            sb.AppendLine("Esperamos su respuesta.Recuerde que de otra forma, será debitado automaticamente de su recibo de sueldo en el siguiente mes.");
            sb.AppendLine();
            sb.AppendLine("Atentamente el centro de Spa Greenwood.");
            FrmCorreo frmCorreo = new FrmCorreo(sb.ToString());
            frmCorreo.ShowDialog();
        }
        /// <summary>
        /// Deserealiza un archivo .json en un Centro para ser mostrado en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivo de Json|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.centro = GestorDeRegistros.DesSerializar_JSON(openFileDialog.FileName, this.centro);
                    this.centro.OrdenarPorIndice();
                    this.listBoxUsuarios.Items.Clear();
                    FrmRegistros_Load(sender, e);
                }
            }
            catch (RegistrosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// A partir del Centro creará un form de Correo con un texto con toda la informacion de los Servicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGanancia_Click(object sender, EventArgs e)
        {
            int contadorTodo = 0;
            int contadorJ = 0;
            int contadorM = 0;
            int contadorS = 0;
            double sumadorTodo = 0;
            double sumadorJ = 0;
            double sumadorM = 0;
            double sumadorS = 0;
            double deuda = 0;
            foreach (Cliente item1 in this.centro.Lista)
            {
                foreach (Servicio item2 in item1.Sevicios)
                {
                    if (this.servicios + item2)
                    {
                        contadorTodo++;
                        sumadorTodo += item2.PrecioFinal;
                        if (!item2.EstaPagado)
                        {
                            deuda += item2.PrecioFinal;
                        }
                        switch (item2.Tipo)
                        {
                            case ETipo.Jacuzzi:
                                sumadorJ += item2.PrecioFinal;
                                contadorJ++;
                                break;
                            case ETipo.Sauna:
                                sumadorS += item2.PrecioFinal;
                                contadorS++;
                                break;
                            default:
                                sumadorM += item2.PrecioFinal;
                                contadorM++;
                                break;
                        }
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informe de ganancia.");
            sb.AppendLine("");
            sb.AppendLine($"Se han registrado {contadorTodo} servicios por un total de ${Math.Round(sumadorTodo, 2)}");
            sb.AppendLine("Servicios de Jacuzzi brindados: " + contadorJ);
            sb.AppendLine("Servicios de Sauna brindados: " + contadorS);
            sb.AppendLine("Servicios de Masaje brindados: " + contadorM);
            sb.AppendLine($"La deuda por pagos pendientes es de ${Math.Round(deuda, 2)} dando como una ganancia neta de ${Math.Round(sumadorTodo - deuda, 2)}");
            sb.AppendLine("Atentamente, el centro de Spa Greenwood.");
            FrmCorreo frmCorreo = new FrmCorreo(sb.ToString());
            frmCorreo.Show();
        }
        /// <summary>
        /// Por medio del GestorDeRegistros se conecta a la base de datos para mostrar la informacion en el ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea continuar?", "Solo debes conectar una vez", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.centro = GestorDeRegistros.ConectarBase(this.centro);
                    this.centro.OrdenarPorIndice();
                    this.listBoxUsuarios.Items.Clear();
                    FrmRegistros_Load(sender, e);
                }
            }
            catch (RegistrosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Implementacion del hilo/evento para agregar un servicio impago del dia al Cliente seleccionado a cada segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            int indice = this.centro.BuscarIndice(this.listBoxUsuarios.Text.PrimerizarPalabra());
            if (indice != int.MinValue)
            {
                int indiceImagen = this.btnAutomatico.ImageIndex;
                if (indiceImagen == 0)
                {
                    this.cancellation = new CancellationTokenSource();
                    CancellationToken token = cancellation.Token;
                    Cliente c = this.centro.Lista[indice];
                    c.OnServicioAgregado += MostrarServicioAgregado;
                    c.AgregarAutomatico(cancellation, token);
                    indiceImagen++;
                }
                else
                {
                    this.cancellation.Cancel();
                    indiceImagen--;
                }
                this.btnAutomatico.ImageIndex = indiceImagen;
            }
            else
            {
                MessageBox.Show("Agregará servicios sin pagar del dia", "Primero elegir cliente");
            }
        }
        /// <summary>
        /// Metodo implementado en el hilo/evento para mostrar el cambio por el servicio agregado
        /// </summary>
        /// <param name="c"></param>
        private void MostrarServicioAgregado(Cliente c)
        {
            if (this.listBoxPagos.InvokeRequired)
            {
                Action<Cliente> delegado = new Action<Cliente>(MostrarServicioAgregado);
                this.listBoxPagos.BeginInvoke(delegado, c);
            }
            else
            {
                if (this.btnAutomatico.ImageIndex == 1)
                {
                    this.listBoxPagos.Items.Add(c.Sevicios[c.Sevicios.Count - 1].MostrarPagoPendiente());
                }
            }
        }
    }
}
