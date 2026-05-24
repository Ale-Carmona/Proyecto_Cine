namespace Proyecto_Cine.Logros
{
    partial class FormLogro
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
            dgDatosLog = new DataGridView();
            lbNombreL = new Label();
            lbDescripcionL = new Label();
            lbPuntosL = new Label();
            lbRequisitosL = new Label();
            lbCategoriaL = new Label();
            txbNombreL = new TextBox();
            txbDescripcionL = new TextBox();
            txbPuntosL = new TextBox();
            txbRequisitosL = new TextBox();
            cmbCategoriaL = new ComboBox();
            cbActivoL = new CheckBox();
            btnAgregarL = new Button();
            btnActualizarL = new Button();
            btnEliminarL = new Button();
            btnLimpiarL = new Button();
            txbUsuarioL = new TextBox();
            lbUsuarioL = new Label();
            lbLogroL = new Label();
            comboBox1 = new ComboBox();
            dgvLogrosUsuarios = new DataGridView();
            btnAsignarL = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatosLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogrosUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgDatosLog
            // 
            dgDatosLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatosLog.Location = new Point(36, 28);
            dgDatosLog.Name = "dgDatosLog";
            dgDatosLog.RowHeadersWidth = 82;
            dgDatosLog.Size = new Size(1486, 376);
            dgDatosLog.TabIndex = 0;
            // 
            // lbNombreL
            // 
            lbNombreL.AutoSize = true;
            lbNombreL.Location = new Point(36, 443);
            lbNombreL.Name = "lbNombreL";
            lbNombreL.Size = new Size(107, 32);
            lbNombreL.TabIndex = 2;
            lbNombreL.Text = "Nombre:";
            // 
            // lbDescripcionL
            // 
            lbDescripcionL.AutoSize = true;
            lbDescripcionL.Location = new Point(333, 443);
            lbDescripcionL.Name = "lbDescripcionL";
            lbDescripcionL.Size = new Size(143, 32);
            lbDescripcionL.TabIndex = 3;
            lbDescripcionL.Text = "Descripcion:";
            // 
            // lbPuntosL
            // 
            lbPuntosL.AutoSize = true;
            lbPuntosL.Location = new Point(36, 540);
            lbPuntosL.Name = "lbPuntosL";
            lbPuntosL.Size = new Size(92, 32);
            lbPuntosL.TabIndex = 4;
            lbPuntosL.Text = "Puntos:";
            // 
            // lbRequisitosL
            // 
            lbRequisitosL.AutoSize = true;
            lbRequisitosL.Location = new Point(1246, 443);
            lbRequisitosL.Name = "lbRequisitosL";
            lbRequisitosL.Size = new Size(127, 32);
            lbRequisitosL.TabIndex = 5;
            lbRequisitosL.Text = "Requisitos:";
            // 
            // lbCategoriaL
            // 
            lbCategoriaL.AutoSize = true;
            lbCategoriaL.Location = new Point(914, 442);
            lbCategoriaL.Name = "lbCategoriaL";
            lbCategoriaL.Size = new Size(121, 32);
            lbCategoriaL.TabIndex = 6;
            lbCategoriaL.Text = "Categoria:";
            // 
            // txbNombreL
            // 
            txbNombreL.Location = new Point(36, 478);
            txbNombreL.Name = "txbNombreL";
            txbNombreL.Size = new Size(242, 39);
            txbNombreL.TabIndex = 8;
            // 
            // txbDescripcionL
            // 
            txbDescripcionL.Location = new Point(333, 478);
            txbDescripcionL.Name = "txbDescripcionL";
            txbDescripcionL.Size = new Size(500, 39);
            txbDescripcionL.TabIndex = 9;
            // 
            // txbPuntosL
            // 
            txbPuntosL.Location = new Point(36, 575);
            txbPuntosL.Name = "txbPuntosL";
            txbPuntosL.Size = new Size(242, 39);
            txbPuntosL.TabIndex = 10;
            // 
            // txbRequisitosL
            // 
            txbRequisitosL.Location = new Point(1246, 478);
            txbRequisitosL.Name = "txbRequisitosL";
            txbRequisitosL.Size = new Size(242, 39);
            txbRequisitosL.TabIndex = 11;
            // 
            // cmbCategoriaL
            // 
            cmbCategoriaL.FormattingEnabled = true;
            cmbCategoriaL.Location = new Point(914, 477);
            cmbCategoriaL.Name = "cmbCategoriaL";
            cmbCategoriaL.Size = new Size(242, 40);
            cmbCategoriaL.TabIndex = 12;
            // 
            // cbActivoL
            // 
            cbActivoL.AutoSize = true;
            cbActivoL.Location = new Point(371, 577);
            cbActivoL.Name = "cbActivoL";
            cbActivoL.Size = new Size(89, 36);
            cbActivoL.TabIndex = 13;
            cbActivoL.Text = "true";
            cbActivoL.UseVisualStyleBackColor = true;
            // 
            // btnAgregarL
            // 
            btnAgregarL.Location = new Point(533, 561);
            btnAgregarL.Name = "btnAgregarL";
            btnAgregarL.Size = new Size(174, 64);
            btnAgregarL.TabIndex = 14;
            btnAgregarL.Text = "Agregar";
            btnAgregarL.UseVisualStyleBackColor = true;
            btnAgregarL.Click += btnAgregarL_Click;
            // 
            // btnActualizarL
            // 
            btnActualizarL.Location = new Point(785, 561);
            btnActualizarL.Name = "btnActualizarL";
            btnActualizarL.Size = new Size(174, 64);
            btnActualizarL.TabIndex = 15;
            btnActualizarL.Text = "Actualizar";
            btnActualizarL.UseVisualStyleBackColor = true;
            btnActualizarL.Click += btnActualizarL_Click;
            // 
            // btnEliminarL
            // 
            btnEliminarL.Location = new Point(1041, 560);
            btnEliminarL.Name = "btnEliminarL";
            btnEliminarL.Size = new Size(174, 66);
            btnEliminarL.TabIndex = 16;
            btnEliminarL.Text = "Eliminar";
            btnEliminarL.UseVisualStyleBackColor = true;
            btnEliminarL.Click += btnEliminarL_Click;
            // 
            // btnLimpiarL
            // 
            btnLimpiarL.Location = new Point(1301, 561);
            btnLimpiarL.Name = "btnLimpiarL";
            btnLimpiarL.Size = new Size(174, 66);
            btnLimpiarL.TabIndex = 17;
            btnLimpiarL.Text = "Limpiar";
            btnLimpiarL.UseVisualStyleBackColor = true;
            btnLimpiarL.Click += btnLimpiarL_Click;
            // 
            // txbUsuarioL
            // 
            txbUsuarioL.Location = new Point(36, 805);
            txbUsuarioL.Name = "txbUsuarioL";
            txbUsuarioL.Size = new Size(242, 39);
            txbUsuarioL.TabIndex = 18;
            // 
            // lbUsuarioL
            // 
            lbUsuarioL.AutoSize = true;
            lbUsuarioL.Location = new Point(36, 745);
            lbUsuarioL.Name = "lbUsuarioL";
            lbUsuarioL.Size = new Size(129, 32);
            lbUsuarioL.TabIndex = 19;
            lbUsuarioL.Text = "Usuario ID:";
            // 
            // lbLogroL
            // 
            lbLogroL.AutoSize = true;
            lbLogroL.Location = new Point(348, 770);
            lbLogroL.Name = "lbLogroL";
            lbLogroL.Size = new Size(80, 32);
            lbLogroL.TabIndex = 20;
            lbLogroL.Text = "Logro:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(348, 805);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 21;
            // 
            // dgvLogrosUsuarios
            // 
            dgvLogrosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogrosUsuarios.Location = new Point(36, 909);
            dgvLogrosUsuarios.Name = "dgvLogrosUsuarios";
            dgvLogrosUsuarios.RowHeadersWidth = 82;
            dgvLogrosUsuarios.Size = new Size(1486, 300);
            dgvLogrosUsuarios.TabIndex = 22;
            // 
            // btnAsignarL
            // 
            btnAsignarL.Location = new Point(668, 773);
            btnAsignarL.Name = "btnAsignarL";
            btnAsignarL.Size = new Size(228, 72);
            btnAsignarL.TabIndex = 23;
            btnAsignarL.Text = "Asignar Logro";
            btnAsignarL.UseVisualStyleBackColor = true;
            btnAsignarL.Click += btnAsignarL_Click;
            // 
            // FormLogro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 1272);
            Controls.Add(btnAsignarL);
            Controls.Add(dgvLogrosUsuarios);
            Controls.Add(comboBox1);
            Controls.Add(lbLogroL);
            Controls.Add(lbUsuarioL);
            Controls.Add(txbUsuarioL);
            Controls.Add(btnLimpiarL);
            Controls.Add(btnEliminarL);
            Controls.Add(btnActualizarL);
            Controls.Add(btnAgregarL);
            Controls.Add(cbActivoL);
            Controls.Add(cmbCategoriaL);
            Controls.Add(txbRequisitosL);
            Controls.Add(txbPuntosL);
            Controls.Add(txbDescripcionL);
            Controls.Add(txbNombreL);
            Controls.Add(lbCategoriaL);
            Controls.Add(lbRequisitosL);
            Controls.Add(lbPuntosL);
            Controls.Add(lbDescripcionL);
            Controls.Add(lbNombreL);
            Controls.Add(dgDatosLog);
            Name = "FormLogro";
            Text = "FormLogro";
            ((System.ComponentModel.ISupportInitialize)dgDatosLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogrosUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDatosLog;
        private Label lbNombreL;
        private Label lbDescripcionL;
        private Label lbPuntosL;
        private Label lbRequisitosL;
        private Label lbCategoriaL;
        private TextBox txbNombreL;
        private TextBox txbDescripcionL;
        private TextBox txbPuntosL;
        private TextBox txbRequisitosL;
        private ComboBox cmbCategoriaL;
        private CheckBox cbActivoL;
        private Button btnAgregarL;
        private Button btnActualizarL;
        private Button btnEliminarL;
        private Button btnLimpiarL;
        private TextBox txbUsuarioL;
        private Label lbUsuarioL;
        private Label lbLogroL;
        private ComboBox comboBox1;
        private DataGridView dgvLogrosUsuarios;
        private Button btnAsignarL;
    }
}