namespace Vista
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.lblSauna = new System.Windows.Forms.Label();
            this.lblMasaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMasaje = new System.Windows.Forms.TextBox();
            this.txtSauna = new System.Windows.Forms.TextBox();
            this.txtJacuzzi = new System.Windows.Forms.TextBox();
            this.lblJacuzzi = new System.Windows.Forms.Label();
            this.lblValidador = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(250, 150);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoServicio.Location = new System.Drawing.Point(312, 12);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(250, 150);
            this.btnNuevoServicio.TabIndex = 1;
            this.btnNuevoServicio.Text = "Nuevo Servicio";
            this.btnNuevoServicio.UseVisualStyleBackColor = true;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistros.Location = new System.Drawing.Point(312, 208);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(250, 150);
            this.btnRegistros.TabIndex = 2;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // lblSauna
            // 
            this.lblSauna.AutoSize = true;
            this.lblSauna.Location = new System.Drawing.Point(0, 67);
            this.lblSauna.Name = "lblSauna";
            this.lblSauna.Size = new System.Drawing.Size(53, 21);
            this.lblSauna.TabIndex = 4;
            this.lblSauna.Text = "Sauna";
            // 
            // lblMasaje
            // 
            this.lblMasaje.AutoSize = true;
            this.lblMasaje.Location = new System.Drawing.Point(0, 108);
            this.lblMasaje.Name = "lblMasaje";
            this.lblMasaje.Size = new System.Drawing.Size(59, 21);
            this.lblMasaje.TabIndex = 5;
            this.lblMasaje.Text = "Masaje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLock);
            this.groupBox1.Controls.Add(this.txtMasaje);
            this.groupBox1.Controls.Add(this.txtSauna);
            this.groupBox1.Controls.Add(this.txtJacuzzi);
            this.groupBox1.Controls.Add(this.lblJacuzzi);
            this.groupBox1.Controls.Add(this.lblMasaje);
            this.groupBox1.Controls.Add(this.lblSauna);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costos por hora";
            // 
            // btnLock
            // 
            this.btnLock.ImageIndex = 0;
            this.btnLock.ImageList = this.imageList1;
            this.btnLock.Location = new System.Drawing.Point(155, 25);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(89, 68);
            this.btnLock.TabIndex = 10;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "openpadlock_120633 (1).png");
            this.imageList1.Images.SetKeyName(1, "3643755-hide-lock-locked-padlock-private_113428.png");
            // 
            // txtMasaje
            // 
            this.txtMasaje.Location = new System.Drawing.Point(64, 105);
            this.txtMasaje.Name = "txtMasaje";
            this.txtMasaje.Size = new System.Drawing.Size(85, 29);
            this.txtMasaje.TabIndex = 9;
            this.txtMasaje.Text = "900";
            this.txtMasaje.Leave += new System.EventHandler(this.txtMasaje_Leave);
            // 
            // txtSauna
            // 
            this.txtSauna.Location = new System.Drawing.Point(64, 64);
            this.txtSauna.Name = "txtSauna";
            this.txtSauna.Size = new System.Drawing.Size(85, 29);
            this.txtSauna.TabIndex = 8;
            this.txtSauna.Text = "1900";
            this.txtSauna.Leave += new System.EventHandler(this.txtSauna_Leave);
            // 
            // txtJacuzzi
            // 
            this.txtJacuzzi.Location = new System.Drawing.Point(64, 27);
            this.txtJacuzzi.Name = "txtJacuzzi";
            this.txtJacuzzi.Size = new System.Drawing.Size(85, 29);
            this.txtJacuzzi.TabIndex = 7;
            this.txtJacuzzi.Text = "2400";
            this.txtJacuzzi.Leave += new System.EventHandler(this.txtJacuzzi_Leave);
            // 
            // lblJacuzzi
            // 
            this.lblJacuzzi.AutoSize = true;
            this.lblJacuzzi.Location = new System.Drawing.Point(0, 30);
            this.lblJacuzzi.Name = "lblJacuzzi";
            this.lblJacuzzi.Size = new System.Drawing.Size(58, 21);
            this.lblJacuzzi.TabIndex = 6;
            this.lblJacuzzi.Text = "Jacuzzi";
            // 
            // lblValidador
            // 
            this.lblValidador.AutoSize = true;
            this.lblValidador.ForeColor = System.Drawing.Color.Red;
            this.lblValidador.Location = new System.Drawing.Point(12, 372);
            this.lblValidador.Name = "lblValidador";
            this.lblValidador.Size = new System.Drawing.Size(0, 15);
            this.lblValidador.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 411);
            this.Controls.Add(this.lblValidador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.btnNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Spa Greenwood";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Label lblSauna;
        private System.Windows.Forms.Label lblMasaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJacuzzi;
        private System.Windows.Forms.TextBox txtJacuzzi;
        private System.Windows.Forms.TextBox txtMasaje;
        private System.Windows.Forms.TextBox txtSauna;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblValidador;
    }
}
