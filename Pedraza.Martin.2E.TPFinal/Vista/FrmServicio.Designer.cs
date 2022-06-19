namespace Vista
{
    partial class FrmServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.listboxClientes = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDuracionError = new System.Windows.Forms.Label();
            this.lblEstaPagado = new System.Windows.Forms.Label();
            this.chboPago = new System.Windows.Forms.CheckBox();
            this.lblPromo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(439, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(170, 23);
            this.dtpFecha.TabIndex = 25;
            this.dtpFecha.TabStop = false;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(439, 112);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(170, 23);
            this.cboTipo.TabIndex = 24;
            this.cboTipo.TabStop = false;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(439, 162);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(170, 23);
            this.txtCosto.TabIndex = 23;
            this.txtCosto.TabStop = false;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(439, 12);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PlaceholderText = "en minutos";
            this.txtDuracion.Size = new System.Drawing.Size(170, 23);
            this.txtDuracion.TabIndex = 22;
            this.txtDuracion.TabStop = false;
            this.txtDuracion.Leave += new System.EventHandler(this.txtDuracion_Leave);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCosto.Location = new System.Drawing.Point(250, 160);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(142, 21);
            this.lblCosto.TabIndex = 21;
            this.lblCosto.Text = "COSTO POR HORA";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(250, 110);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 21);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "TIPO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(250, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "FECHA";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.Location = new System.Drawing.Point(250, 10);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(90, 21);
            this.lblDuracion.TabIndex = 18;
            this.lblDuracion.Text = "DURACION";
            // 
            // listboxClientes
            // 
            this.listboxClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listboxClientes.FormattingEnabled = true;
            this.listboxClientes.ItemHeight = 21;
            this.listboxClientes.Location = new System.Drawing.Point(12, 39);
            this.listboxClientes.Name = "listboxClientes";
            this.listboxClientes.Size = new System.Drawing.Size(233, 130);
            this.listboxClientes.TabIndex = 1;
            this.listboxClientes.SelectedIndexChanged += new System.EventHandler(this.listboxClientes_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(439, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 47);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLista.Location = new System.Drawing.Point(12, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(217, 21);
            this.lblLista.TabIndex = 28;
            this.lblLista.Text = "LISTA DE USUARIOS POR DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 191);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 21);
            this.lblNombre.TabIndex = 29;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(250, 260);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 47);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDuracionError
            // 
            this.lblDuracionError.AutoSize = true;
            this.lblDuracionError.ForeColor = System.Drawing.Color.Red;
            this.lblDuracionError.Location = new System.Drawing.Point(439, 38);
            this.lblDuracionError.Name = "lblDuracionError";
            this.lblDuracionError.Size = new System.Drawing.Size(0, 15);
            this.lblDuracionError.TabIndex = 31;
            // 
            // lblEstaPagado
            // 
            this.lblEstaPagado.AutoSize = true;
            this.lblEstaPagado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstaPagado.Location = new System.Drawing.Point(250, 210);
            this.lblEstaPagado.Name = "lblEstaPagado";
            this.lblEstaPagado.Size = new System.Drawing.Size(117, 21);
            this.lblEstaPagado.TabIndex = 32;
            this.lblEstaPagado.Text = "ESTA PAGADO?";
            // 
            // chboPago
            // 
            this.chboPago.AutoSize = true;
            this.chboPago.Location = new System.Drawing.Point(439, 210);
            this.chboPago.Name = "chboPago";
            this.chboPago.Size = new System.Drawing.Size(123, 19);
            this.chboPago.TabIndex = 33;
            this.chboPago.Text = "Pagado o Boucher";
            this.chboPago.UseVisualStyleBackColor = true;
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(439, 188);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(139, 15);
            this.lblPromo.TabIndex = 34;
            this.lblPromo.Text = "Miercoles con descuento";
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 315);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.chboPago);
            this.Controls.Add(this.lblEstaPagado);
            this.Controls.Add(this.lblDuracionError);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listboxClientes);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDuracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Servicio";
            this.Load += new System.EventHandler(this.FrmServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ListBox listboxClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDuracionError;
        private System.Windows.Forms.Label lblEstaPagado;
        private System.Windows.Forms.CheckBox chboPago;
        private System.Windows.Forms.Label lblPromo;
    }
}