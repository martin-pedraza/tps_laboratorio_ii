using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add("");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
            this.cmbOperador.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperador.Text == string.Empty)
            {
                this.cmbOperador.SelectedIndex = 1;
            }
            this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} {this.cmbOperador.Text} {this.txtNumero2.Text} = {this.lblResultado.Text}");
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador[0]);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Conversion a Binario: {new Operando().DecimalBinario(lblResultado.Text)}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Conversion a Decimal: {new Operando().BinarioDecimal(lblResultado.Text)}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
