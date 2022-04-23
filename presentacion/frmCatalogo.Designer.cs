namespace presentacion
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblValidarFiltro = new System.Windows.Forms.Label();
            this.txtDetalleCodigo = new System.Windows.Forms.TextBox();
            this.txtDetalleNombre = new System.Windows.Forms.TextBox();
            this.txtDetalleDescripcion = new System.Windows.Forms.TextBox();
            this.txtDetalleEmpresa = new System.Windows.Forms.TextBox();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleEmpresa = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleCategorias = new System.Windows.Forms.Label();
            this.txtDetallePrecio = new System.Windows.Forms.TextBox();
            this.txtDetalleCategorias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToResizeColumns = false;
            this.dgvArticulo.AllowUserToResizeRows = false;
            this.dgvArticulo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(29, 44);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(653, 186);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulo_CellClick);
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(688, 44);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(215, 186);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(29, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(150, 238);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 37);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarFisico.Location = new System.Drawing.Point(271, 237);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(84, 37);
            this.btnEliminarFisico.TabIndex = 3;
            this.btnEliminarFisico.Text = "Eliminar Fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(30, 18);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(69, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(105, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(253, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(688, 440);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(30, 455);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(76, 452);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(99, 21);
            this.cboCampo.TabIndex = 4;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(195, 455);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(251, 452);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(99, 21);
            this.cboCriterio.TabIndex = 5;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(365, 454);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroAvanzado.TabIndex = 12;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(454, 451);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(158, 20);
            this.txtFiltroAvanzado.TabIndex = 6;
            // 
            // lblValidarFiltro
            // 
            this.lblValidarFiltro.AutoSize = true;
            this.lblValidarFiltro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarFiltro.Location = new System.Drawing.Point(682, 362);
            this.lblValidarFiltro.Name = "lblValidarFiltro";
            this.lblValidarFiltro.Size = new System.Drawing.Size(0, 19);
            this.lblValidarFiltro.TabIndex = 13;
            this.lblValidarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDetalleCodigo
            // 
            this.txtDetalleCodigo.Location = new System.Drawing.Point(150, 294);
            this.txtDetalleCodigo.Name = "txtDetalleCodigo";
            this.txtDetalleCodigo.ReadOnly = true;
            this.txtDetalleCodigo.Size = new System.Drawing.Size(156, 20);
            this.txtDetalleCodigo.TabIndex = 14;
            // 
            // txtDetalleNombre
            // 
            this.txtDetalleNombre.Location = new System.Drawing.Point(150, 333);
            this.txtDetalleNombre.Name = "txtDetalleNombre";
            this.txtDetalleNombre.ReadOnly = true;
            this.txtDetalleNombre.Size = new System.Drawing.Size(156, 20);
            this.txtDetalleNombre.TabIndex = 15;
            // 
            // txtDetalleDescripcion
            // 
            this.txtDetalleDescripcion.Location = new System.Drawing.Point(150, 362);
            this.txtDetalleDescripcion.Multiline = true;
            this.txtDetalleDescripcion.Name = "txtDetalleDescripcion";
            this.txtDetalleDescripcion.ReadOnly = true;
            this.txtDetalleDescripcion.Size = new System.Drawing.Size(156, 43);
            this.txtDetalleDescripcion.TabIndex = 16;
            // 
            // txtDetalleEmpresa
            // 
            this.txtDetalleEmpresa.Location = new System.Drawing.Point(150, 411);
            this.txtDetalleEmpresa.Name = "txtDetalleEmpresa";
            this.txtDetalleEmpresa.ReadOnly = true;
            this.txtDetalleEmpresa.Size = new System.Drawing.Size(156, 20);
            this.txtDetalleEmpresa.TabIndex = 17;
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(73, 301);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDetalleCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblDetalleCodigo.TabIndex = 18;
            this.lblDetalleCodigo.Text = "Código";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(69, 340);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(44, 13);
            this.lblDetalleNombre.TabIndex = 19;
            this.lblDetalleNombre.Text = "Nombre";
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(50, 379);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDetalleDescripcion.TabIndex = 20;
            this.lblDetalleDescripcion.Text = "Descripción";
            // 
            // lblDetalleEmpresa
            // 
            this.lblDetalleEmpresa.AutoSize = true;
            this.lblDetalleEmpresa.Location = new System.Drawing.Point(65, 418);
            this.lblDetalleEmpresa.Name = "lblDetalleEmpresa";
            this.lblDetalleEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblDetalleEmpresa.TabIndex = 21;
            this.lblDetalleEmpresa.Text = "Empresa";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(335, 340);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(37, 13);
            this.lblDetallePrecio.TabIndex = 23;
            this.lblDetallePrecio.Text = "Precio";
            // 
            // lblDetalleCategorias
            // 
            this.lblDetalleCategorias.AutoSize = true;
            this.lblDetalleCategorias.Location = new System.Drawing.Point(315, 301);
            this.lblDetalleCategorias.Name = "lblDetalleCategorias";
            this.lblDetalleCategorias.Size = new System.Drawing.Size(57, 13);
            this.lblDetalleCategorias.TabIndex = 22;
            this.lblDetalleCategorias.Text = "Categorias";
            // 
            // txtDetallePrecio
            // 
            this.txtDetallePrecio.Location = new System.Drawing.Point(391, 333);
            this.txtDetallePrecio.Name = "txtDetallePrecio";
            this.txtDetallePrecio.ReadOnly = true;
            this.txtDetallePrecio.Size = new System.Drawing.Size(156, 20);
            this.txtDetallePrecio.TabIndex = 25;
            // 
            // txtDetalleCategorias
            // 
            this.txtDetalleCategorias.Location = new System.Drawing.Point(391, 294);
            this.txtDetalleCategorias.Name = "txtDetalleCategorias";
            this.txtDetalleCategorias.ReadOnly = true;
            this.txtDetalleCategorias.Size = new System.Drawing.Size(156, 20);
            this.txtDetalleCategorias.TabIndex = 24;
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(905, 508);
            this.Controls.Add(this.txtDetallePrecio);
            this.Controls.Add(this.txtDetalleCategorias);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.lblDetalleCategorias);
            this.Controls.Add(this.lblDetalleEmpresa);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Controls.Add(this.txtDetalleEmpresa);
            this.Controls.Add(this.txtDetalleDescripcion);
            this.Controls.Add(this.txtDetalleNombre);
            this.Controls.Add(this.txtDetalleCodigo);
            this.Controls.Add(this.lblValidarFiltro);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(921, 547);
            this.MinimumSize = new System.Drawing.Size(921, 547);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblValidarFiltro;
        private System.Windows.Forms.TextBox txtDetalleCodigo;
        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.TextBox txtDetalleDescripcion;
        private System.Windows.Forms.TextBox txtDetalleEmpresa;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleEmpresa;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleCategorias;
        private System.Windows.Forms.TextBox txtDetallePrecio;
        private System.Windows.Forms.TextBox txtDetalleCategorias;
    }
}

