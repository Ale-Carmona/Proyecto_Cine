namespace Proyecto_Cine.Usuarios
{
    partial class FormUsuarios
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
            dgvUsuarios = new DataGridView();
            lbIdU = new Label();
            lbNombreU = new Label();
            lbEmailU = new Label();
            lbContraseñaU = new Label();
            lbPuntosU = new Label();
            lbMenmbresiaU = new Label();
            txbIdU = new TextBox();
            txbNombreU = new TextBox();
            txbEmailU = new TextBox();
            txbContraeñaU = new TextBox();
            txbPuntosU = new TextBox();
            cmbMembresiaU = new ComboBox();
            hkActivoU = new CheckBox();
            btnBuscarU = new Button();
            btnAgregarU = new Button();
            btnActualizarU = new Button();
            btnEliminarU = new Button();
            btnLimpiarU = new Button();
            btnIrLogros = new Button();
            btnIrRecompensas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(34, 104);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 82;
            dgvUsuarios.Size = new Size(1196, 300);
            dgvUsuarios.TabIndex = 0;
            // 
            // lbIdU
            // 
            lbIdU.AutoSize = true;
            lbIdU.Location = new Point(34, 434);
            lbIdU.Name = "lbIdU";
            lbIdU.Size = new Size(42, 32);
            lbIdU.TabIndex = 1;
            lbIdU.Text = "ID:";
            // 
            // lbNombreU
            // 
            lbNombreU.AutoSize = true;
            lbNombreU.Location = new Point(313, 434);
            lbNombreU.Name = "lbNombreU";
            lbNombreU.Size = new Size(107, 32);
            lbNombreU.TabIndex = 2;
            lbNombreU.Text = "Nombre:";
            // 
            // lbEmailU
            // 
            lbEmailU.AutoSize = true;
            lbEmailU.Location = new Point(598, 434);
            lbEmailU.Name = "lbEmailU";
            lbEmailU.Size = new Size(76, 32);
            lbEmailU.TabIndex = 3;
            lbEmailU.Text = "Email:";
            // 
            // lbContraseñaU
            // 
            lbContraseñaU.AutoSize = true;
            lbContraseñaU.Location = new Point(893, 434);
            lbContraseñaU.Name = "lbContraseñaU";
            lbContraseñaU.Size = new Size(139, 32);
            lbContraseñaU.TabIndex = 4;
            lbContraseñaU.Text = "Contraseña:";
            // 
            // lbPuntosU
            // 
            lbPuntosU.AutoSize = true;
            lbPuntosU.Location = new Point(34, 538);
            lbPuntosU.Name = "lbPuntosU";
            lbPuntosU.Size = new Size(92, 32);
            lbPuntosU.TabIndex = 5;
            lbPuntosU.Text = "Puntos:";
            // 
            // lbMenmbresiaU
            // 
            lbMenmbresiaU.AutoSize = true;
            lbMenmbresiaU.Location = new Point(313, 538);
            lbMenmbresiaU.Name = "lbMenmbresiaU";
            lbMenmbresiaU.Size = new Size(138, 32);
            lbMenmbresiaU.TabIndex = 6;
            lbMenmbresiaU.Text = "Membresia:";
            lbMenmbresiaU.Click += lbMenmbresiaU_Click;
            // 
            // txbIdU
            // 
            txbIdU.Location = new Point(34, 469);
            txbIdU.Name = "txbIdU";
            txbIdU.Size = new Size(242, 39);
            txbIdU.TabIndex = 7;
            // 
            // txbNombreU
            // 
            txbNombreU.Location = new Point(313, 469);
            txbNombreU.Name = "txbNombreU";
            txbNombreU.Size = new Size(242, 39);
            txbNombreU.TabIndex = 8;
            // 
            // txbEmailU
            // 
            txbEmailU.Location = new Point(598, 469);
            txbEmailU.Name = "txbEmailU";
            txbEmailU.Size = new Size(242, 39);
            txbEmailU.TabIndex = 9;
            // 
            // txbContraeñaU
            // 
            txbContraeñaU.Location = new Point(893, 469);
            txbContraeñaU.Name = "txbContraeñaU";
            txbContraeñaU.Size = new Size(242, 39);
            txbContraeñaU.TabIndex = 10;
            // 
            // txbPuntosU
            // 
            txbPuntosU.Location = new Point(34, 573);
            txbPuntosU.Name = "txbPuntosU";
            txbPuntosU.Size = new Size(242, 39);
            txbPuntosU.TabIndex = 11;
            // 
            // cmbMembresiaU
            // 
            cmbMembresiaU.FormattingEnabled = true;
            cmbMembresiaU.Location = new Point(313, 572);
            cmbMembresiaU.Name = "cmbMembresiaU";
            cmbMembresiaU.Size = new Size(242, 40);
            cmbMembresiaU.TabIndex = 12;
            // 
            // hkActivoU
            // 
            hkActivoU.AutoSize = true;
            hkActivoU.Location = new Point(598, 572);
            hkActivoU.Name = "hkActivoU";
            hkActivoU.Size = new Size(112, 36);
            hkActivoU.TabIndex = 13;
            hkActivoU.Text = "Activo";
            hkActivoU.UseVisualStyleBackColor = true;
            // 
            // btnBuscarU
            // 
            btnBuscarU.Location = new Point(34, 667);
            btnBuscarU.Name = "btnBuscarU";
            btnBuscarU.Size = new Size(150, 46);
            btnBuscarU.TabIndex = 14;
            btnBuscarU.Text = "Buscar";
            btnBuscarU.UseVisualStyleBackColor = true;
            btnBuscarU.Click += btnBuscarU_Click;
            // 
            // btnAgregarU
            // 
            btnAgregarU.Location = new Point(223, 667);
            btnAgregarU.Name = "btnAgregarU";
            btnAgregarU.Size = new Size(150, 46);
            btnAgregarU.TabIndex = 15;
            btnAgregarU.Text = "Agregar";
            btnAgregarU.UseVisualStyleBackColor = true;
            btnAgregarU.Click += btnAgregarU_Click;
            // 
            // btnActualizarU
            // 
            btnActualizarU.Location = new Point(405, 667);
            btnActualizarU.Name = "btnActualizarU";
            btnActualizarU.Size = new Size(150, 46);
            btnActualizarU.TabIndex = 16;
            btnActualizarU.Text = "Actualizar";
            btnActualizarU.UseVisualStyleBackColor = true;
            btnActualizarU.Click += btnActualizarU_Click;
            // 
            // btnEliminarU
            // 
            btnEliminarU.Location = new Point(586, 667);
            btnEliminarU.Name = "btnEliminarU";
            btnEliminarU.Size = new Size(150, 46);
            btnEliminarU.TabIndex = 17;
            btnEliminarU.Text = "Eliminar";
            btnEliminarU.UseVisualStyleBackColor = true;
            btnEliminarU.Click += btnEliminarU_Click;
            // 
            // btnLimpiarU
            // 
            btnLimpiarU.Location = new Point(770, 667);
            btnLimpiarU.Name = "btnLimpiarU";
            btnLimpiarU.Size = new Size(150, 46);
            btnLimpiarU.TabIndex = 18;
            btnLimpiarU.Text = "Limpiar";
            btnLimpiarU.UseVisualStyleBackColor = true;
            btnLimpiarU.Click += btnLimpiarU_Click;
            // 
            // btnIrLogros
            // 
            btnIrLogros.Location = new Point(732, 37);
            btnIrLogros.Name = "btnIrLogros";
            btnIrLogros.Size = new Size(150, 46);
            btnIrLogros.TabIndex = 19;
            btnIrLogros.Text = "Logros";
            btnIrLogros.UseVisualStyleBackColor = true;
            btnIrLogros.Click += btnIrLogros_Click;
            // 
            // btnIrRecompensas
            // 
            btnIrRecompensas.Location = new Point(939, 37);
            btnIrRecompensas.Name = "btnIrRecompensas";
            btnIrRecompensas.Size = new Size(196, 46);
            btnIrRecompensas.TabIndex = 20;
            btnIrRecompensas.Text = "Recompensas";
            btnIrRecompensas.UseVisualStyleBackColor = true;
            btnIrRecompensas.Click += btnIrRecompensas_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 732);
            Controls.Add(btnIrRecompensas);
            Controls.Add(btnIrLogros);
            Controls.Add(btnLimpiarU);
            Controls.Add(btnEliminarU);
            Controls.Add(btnActualizarU);
            Controls.Add(btnAgregarU);
            Controls.Add(btnBuscarU);
            Controls.Add(hkActivoU);
            Controls.Add(cmbMembresiaU);
            Controls.Add(txbPuntosU);
            Controls.Add(txbContraeñaU);
            Controls.Add(txbEmailU);
            Controls.Add(txbNombreU);
            Controls.Add(txbIdU);
            Controls.Add(lbMenmbresiaU);
            Controls.Add(lbPuntosU);
            Controls.Add(lbContraseñaU);
            Controls.Add(lbEmailU);
            Controls.Add(lbNombreU);
            Controls.Add(lbIdU);
            Controls.Add(dgvUsuarios);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label lbIdU;
        private Label lbNombreU;
        private Label lbEmailU;
        private Label lbContraseñaU;
        private Label lbPuntosU;
        private Label lbMenmbresiaU;
        private TextBox txbIdU;
        private TextBox txbNombreU;
        private TextBox txbEmailU;
        private TextBox txbContraeñaU;
        private TextBox txbPuntosU;
        private ComboBox cmbMembresiaU;
        private CheckBox hkActivoU;
        private Button btnBuscarU;
        private Button btnAgregarU;
        private Button btnActualizarU;
        private Button btnEliminarU;
        private Button btnLimpiarU;
        private Button btnIrLogros;
        private Button btnIrRecompensas;
    }
}