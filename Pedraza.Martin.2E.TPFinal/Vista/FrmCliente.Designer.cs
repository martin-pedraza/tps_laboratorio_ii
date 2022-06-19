namespace Vista
{
    partial class FrmCliente
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
            this.lblDn = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDniError = new System.Windows.Forms.Label();
            this.lblNombreError = new System.Windows.Forms.Label();
            this.lblApellidoError = new System.Windows.Forms.Label();
            this.lblTelefonoError = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.chboPago = new System.Windows.Forms.CheckBox();
            this.lblEstaPagado = new System.Windows.Forms.Label();
            this.lblDuracionError = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDn
            // 
            this.lblDn.AutoSize = true;
            this.lblDn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDn.Location = new System.Drawing.Point(12, 10);
            this.lblDn.Name = "lblDn";
            this.lblDn.Size = new System.Drawing.Size(37, 21);
            this.lblDn.TabIndex = 0;
            this.lblDn.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 21);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(12, 160);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 21);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(190, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 23);
            this.txtDni.TabIndex = 5;
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(190, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 23);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(190, 162);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(12, 210);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(172, 47);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(190, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 47);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblDniError
            // 
            this.lblDniError.AutoSize = true;
            this.lblDniError.ForeColor = System.Drawing.Color.Red;
            this.lblDniError.Location = new System.Drawing.Point(87, 38);
            this.lblDniError.Name = "lblDniError";
            this.lblDniError.Size = new System.Drawing.Size(0, 15);
            this.lblDniError.TabIndex = 20;
            // 
            // lblNombreError
            // 
            this.lblNombreError.AutoSize = true;
            this.lblNombreError.ForeColor = System.Drawing.Color.Red;
            this.lblNombreError.Location = new System.Drawing.Point(190, 88);
            this.lblNombreError.Name = "lblNombreError";
            this.lblNombreError.Size = new System.Drawing.Size(0, 15);
            this.lblNombreError.TabIndex = 21;
            // 
            // lblApellidoError
            // 
            this.lblApellidoError.AutoSize = true;
            this.lblApellidoError.ForeColor = System.Drawing.Color.Red;
            this.lblApellidoError.Location = new System.Drawing.Point(190, 138);
            this.lblApellidoError.Name = "lblApellidoError";
            this.lblApellidoError.Size = new System.Drawing.Size(0, 15);
            this.lblApellidoError.TabIndex = 22;
            // 
            // lblTelefonoError
            // 
            this.lblTelefonoError.AutoSize = true;
            this.lblTelefonoError.ForeColor = System.Drawing.Color.Red;
            this.lblTelefonoError.Location = new System.Drawing.Point(190, 188);
            this.lblTelefonoError.Name = "lblTelefonoError";
            this.lblTelefonoError.Size = new System.Drawing.Size(0, 15);
            this.lblTelefonoError.TabIndex = 23;
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(619, 188);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(139, 15);
            this.lblPromo.TabIndex = 46;
            this.lblPromo.Text = "Miercoles con descuento";
            // 
            // chboPago
            // 
            this.chboPago.AutoSize = true;
            this.chboPago.Location = new System.Drawing.Point(619, 210);
            this.chboPago.Name = "chboPago";
            this.chboPago.Size = new System.Drawing.Size(66, 19);
            this.chboPago.TabIndex = 12;
            this.chboPago.Text = "Pagado";
            this.chboPago.UseVisualStyleBackColor = true;
            // 
            // lblEstaPagado
            // 
            this.lblEstaPagado.AutoSize = true;
            this.lblEstaPagado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstaPagado.Location = new System.Drawing.Point(430, 210);
            this.lblEstaPagado.Name = "lblEstaPagado";
            this.lblEstaPagado.Size = new System.Drawing.Size(117, 21);
            this.lblEstaPagado.TabIndex = 44;
            this.lblEstaPagado.Text = "ESTA PAGADO?";
            // 
            // lblDuracionError
            // 
            this.lblDuracionError.AutoSize = true;
            this.lblDuracionError.ForeColor = System.Drawing.Color.Red;
            this.lblDuracionError.Location = new System.Drawing.Point(619, 38);
            this.lblDuracionError.Name = "lblDuracionError";
            this.lblDuracionError.Size = new System.Drawing.Size(0, 15);
            this.lblDuracionError.TabIndex = 43;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(619, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(170, 23);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.TabStop = false;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 15;
            this.cboTipo.Location = new System.Drawing.Point(619, 112);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(170, 23);
            this.cboTipo.TabIndex = 41;
            this.cboTipo.TabStop = false;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(619, 162);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(170, 23);
            this.txtCosto.TabIndex = 40;
            this.txtCosto.TabStop = false;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(619, 12);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PlaceholderText = "en minutos";
            this.txtDuracion.Size = new System.Drawing.Size(170, 23);
            this.txtDuracion.TabIndex = 9;
            this.txtDuracion.TabStop = false;
            this.txtDuracion.Leave += new System.EventHandler(this.txtDuracion_Leave);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCosto.Location = new System.Drawing.Point(430, 160);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(142, 21);
            this.lblCosto.TabIndex = 38;
            this.lblCosto.Text = "COSTO POR HORA";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(430, 110);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 21);
            this.lblTipo.TabIndex = 37;
            this.lblTipo.Text = "TIPO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(430, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "FECHA";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.Location = new System.Drawing.Point(430, 10);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(90, 21);
            this.lblDuracion.TabIndex = 35;
            this.lblDuracion.Text = "DURACION";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 280);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.chboPago);
            this.Controls.Add(this.lblEstaPagado);
            this.Controls.Add(this.lblDuracionError);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblTelefonoError);
            this.Controls.Add(this.lblApellidoError);
            this.Controls.Add(this.lblNombreError);
            this.Controls.Add(this.lblDniError);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDn;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDniError;
        private System.Windows.Forms.Label lblNombreError;
        private System.Windows.Forms.Label lblApellidoError;
        private System.Windows.Forms.Label lblTelefonoError;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.CheckBox chboPago;
        private System.Windows.Forms.Label lblEstaPagado;
        private System.Windows.Forms.Label lblDuracionError;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDuracion;
    }
}