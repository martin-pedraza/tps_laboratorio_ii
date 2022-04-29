namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(118, 53);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 23);
            this.cmbOperador.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(250, 82);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 44);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 132);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(166, 47);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Location = new System.Drawing.Point(184, 132);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(166, 47);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(118, 82);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 44);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 82);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(100, 44);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(12, 53);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 23);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(250, 53);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(300, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 8;
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(356, 25);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(199, 154);
            this.lstOperaciones.TabIndex = 9;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 203);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Martin Pedraza del curso 2E";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstOperaciones;
    }
}
