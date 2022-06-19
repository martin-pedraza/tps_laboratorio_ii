namespace Vista
{
    partial class FrmRegistros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistros));
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.listBoxPagos = new System.Windows.Forms.ListBox();
            this.lblTodosUsuarios = new System.Windows.Forms.Label();
            this.btnArchivar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 15;
            this.listBoxUsuarios.Location = new System.Drawing.Point(12, 52);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(274, 289);
            this.listBoxUsuarios.TabIndex = 0;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.ItemHeight = 15;
            this.listBoxPagos.Location = new System.Drawing.Point(338, 52);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(274, 289);
            this.listBoxPagos.TabIndex = 1;
            // 
            // lblTodosUsuarios
            // 
            this.lblTodosUsuarios.AutoSize = true;
            this.lblTodosUsuarios.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTodosUsuarios.Location = new System.Drawing.Point(12, 21);
            this.lblTodosUsuarios.Name = "lblTodosUsuarios";
            this.lblTodosUsuarios.Size = new System.Drawing.Size(225, 28);
            this.lblTodosUsuarios.TabIndex = 2;
            this.lblTodosUsuarios.Text = "TODOS LOS USUARIOS";
            // 
            // btnArchivar
            // 
            this.btnArchivar.Location = new System.Drawing.Point(12, 347);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Size = new System.Drawing.Size(120, 23);
            this.btnArchivar.TabIndex = 7;
            this.btnArchivar.Text = "ARCHIVAR";
            this.btnArchivar.UseVisualStyleBackColor = true;
            this.btnArchivar.Click += new System.EventHandler(this.btnArchivar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(492, 347);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(120, 23);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Location = new System.Drawing.Point(492, 376);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(120, 23);
            this.btnCorreo.TabIndex = 11;
            this.btnCorreo.Text = "GENERAR CORREO";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendientes.Location = new System.Drawing.Point(362, 21);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(204, 28);
            this.lblPendientes.TabIndex = 12;
            this.lblPendientes.Text = "PAGOS PENDIENTES";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(12, 376);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(120, 23);
            this.btnAbrirArchivo.TabIndex = 13;
            this.btnAbrirArchivo.Text = "ABRIR ARCHIVOS";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // btnGanancia
            // 
            this.btnGanancia.ImageIndex = 0;
            this.btnGanancia.ImageList = this.imageList2;
            this.btnGanancia.Location = new System.Drawing.Point(338, 347);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(148, 52);
            this.btnGanancia.TabIndex = 14;
            this.btnGanancia.UseVisualStyleBackColor = true;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ganancia.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "datos.png");
            // 
            // btnDatos
            // 
            this.btnDatos.ImageIndex = 0;
            this.btnDatos.ImageList = this.imageList1;
            this.btnDatos.Location = new System.Drawing.Point(138, 347);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(148, 52);
            this.btnDatos.TabIndex = 15;
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.ImageIndex = 0;
            this.btnAutomatico.ImageList = this.imageList3;
            this.btnAutomatico.Location = new System.Drawing.Point(292, 52);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(40, 40);
            this.btnAutomatico.TabIndex = 36;
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "suma.png");
            this.imageList3.Images.SetKeyName(1, "cancelar.png");
            // 
            // FrmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnAutomatico);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnArchivar);
            this.Controls.Add(this.lblTodosUsuarios);
            this.Controls.Add(this.listBoxPagos);
            this.Controls.Add(this.listBoxUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.FrmRegistros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.ListBox listBoxPagos;
        private System.Windows.Forms.Label lblTodosUsuarios;
        private System.Windows.Forms.Button btnArchivar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.ImageList imageList3;
    }
}