using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmCorreo : Form
    {
        public FrmCorreo(string texto)
        {
            InitializeComponent();
            this.richTextBoxCorreo.Text = texto;
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
        /// Guardara el correo en pantalla en un archivo tipo .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivo de texto|*.txt";
                saveFileDialog1.ShowDialog();
                GestorDeRegistros.GuardarCorreo(saveFileDialog1.FileName, this.richTextBoxCorreo.Text);
            }
            catch (RegistrosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Abrira otro correo de tipo txt y lo mostrara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.richTextBoxCorreo.Text = GestorDeRegistros.AbrirCorreo(openFileDialog.FileName);
                }
                catch (RegistrosException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
