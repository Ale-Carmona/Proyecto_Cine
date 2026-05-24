namespace Proyecto_Cine.Recompensas
{
    partial class FormRecompensas
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
            DgDatosRecom = new DataGridView();
            btnActualizarR = new Button();
            btnAgregarR = new Button();
            btnEliminarR = new Button();
            lbIDR = new Label();
            lbNombreR = new Label();
            lbDescripcionR = new Label();
            lbStockR = new Label();
            lbPuntosR = new Label();
            txbIDR = new TextBox();
            txbNombreR = new TextBox();
            txbDescripcionR = new TextBox();
            txbPuntosR = new TextBox();
            lbTipoR = new Label();
            lbImagenR = new Label();
            txbStockR = new TextBox();
            cbTipoR = new ComboBox();
            textBox1 = new TextBox();
            Disponible = new CheckBox();
            btnMostrarR = new Button();
            btnbuscarR = new Button();
            btnLimpiarR = new Button();
            lbCategoriaR = new Label();
            txbCategoriaR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgDatosRecom).BeginInit();
            SuspendLayout();
            // 
            // DgDatosRecom
            // 
            DgDatosRecom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgDatosRecom.Location = new Point(37, 30);
            DgDatosRecom.Name = "DgDatosRecom";
            DgDatosRecom.RowHeadersWidth = 82;
            DgDatosRecom.Size = new Size(1366, 381);
            DgDatosRecom.TabIndex = 0;
            // 
            // btnActualizarR
            // 
            btnActualizarR.Location = new Point(553, 728);
            btnActualizarR.Name = "btnActualizarR";
            btnActualizarR.Size = new Size(200, 94);
            btnActualizarR.TabIndex = 1;
            btnActualizarR.Text = "Actualizar Recompensas";
            btnActualizarR.UseVisualStyleBackColor = true;
            btnActualizarR.Click += btnActualizarR_Click;
            // 
            // btnAgregarR
            // 
            btnAgregarR.Location = new Point(295, 728);
            btnAgregarR.Name = "btnAgregarR";
            btnAgregarR.Size = new Size(200, 94);
            btnAgregarR.TabIndex = 2;
            btnAgregarR.Text = "Agregar Recompensa ";
            btnAgregarR.UseVisualStyleBackColor = true;
            btnAgregarR.Click += btnAgregarR_Click;
            // 
            // btnEliminarR
            // 
            btnEliminarR.Location = new Point(791, 728);
            btnEliminarR.Name = "btnEliminarR";
            btnEliminarR.Size = new Size(200, 94);
            btnEliminarR.TabIndex = 3;
            btnEliminarR.Text = "Eliminar Recompensa";
            btnEliminarR.UseVisualStyleBackColor = true;
            btnEliminarR.Click += btnEliminarR_Click;
            // 
            // lbIDR
            // 
            lbIDR.AutoSize = true;
            lbIDR.Location = new Point(37, 434);
            lbIDR.Name = "lbIDR";
            lbIDR.Size = new Size(42, 32);
            lbIDR.TabIndex = 4;
            lbIDR.Text = "ID:";
            // 
            // lbNombreR
            // 
            lbNombreR.AutoSize = true;
            lbNombreR.Location = new Point(323, 434);
            lbNombreR.Name = "lbNombreR";
            lbNombreR.Size = new Size(107, 32);
            lbNombreR.TabIndex = 5;
            lbNombreR.Text = "Nombre:";
            // 
            // lbDescripcionR
            // 
            lbDescripcionR.AutoSize = true;
            lbDescripcionR.Location = new Point(727, 434);
            lbDescripcionR.Name = "lbDescripcionR";
            lbDescripcionR.Size = new Size(143, 32);
            lbDescripcionR.TabIndex = 6;
            lbDescripcionR.Text = "Descripcion:";
            // 
            // lbStockR
            // 
            lbStockR.AutoSize = true;
            lbStockR.Location = new Point(323, 544);
            lbStockR.Name = "lbStockR";
            lbStockR.Size = new Size(76, 32);
            lbStockR.TabIndex = 7;
            lbStockR.Text = "Stock:";
            lbStockR.Click += lbCostoR_Click;
            // 
            // lbPuntosR
            // 
            lbPuntosR.AutoSize = true;
            lbPuntosR.Location = new Point(37, 544);
            lbPuntosR.Name = "lbPuntosR";
            lbPuntosR.Size = new Size(92, 32);
            lbPuntosR.TabIndex = 8;
            lbPuntosR.Text = "Puntos:";
            // 
            // txbIDR
            // 
            txbIDR.Location = new Point(37, 469);
            txbIDR.Name = "txbIDR";
            txbIDR.Size = new Size(224, 39);
            txbIDR.TabIndex = 9;
            // 
            // txbNombreR
            // 
            txbNombreR.Location = new Point(323, 469);
            txbNombreR.Name = "txbNombreR";
            txbNombreR.Size = new Size(320, 39);
            txbNombreR.TabIndex = 10;
            // 
            // txbDescripcionR
            // 
            txbDescripcionR.Location = new Point(727, 469);
            txbDescripcionR.Name = "txbDescripcionR";
            txbDescripcionR.Size = new Size(496, 39);
            txbDescripcionR.TabIndex = 11;
            // 
            // txbPuntosR
            // 
            txbPuntosR.Location = new Point(323, 579);
            txbPuntosR.Name = "txbPuntosR";
            txbPuntosR.Size = new Size(224, 39);
            txbPuntosR.TabIndex = 12;
            // 
            // lbTipoR
            // 
            lbTipoR.AutoSize = true;
            lbTipoR.Location = new Point(611, 529);
            lbTipoR.Name = "lbTipoR";
            lbTipoR.Size = new Size(66, 32);
            lbTipoR.TabIndex = 14;
            lbTipoR.Text = "Tipo:";
            // 
            // lbImagenR
            // 
            lbImagenR.AutoSize = true;
            lbImagenR.Location = new Point(901, 528);
            lbImagenR.Name = "lbImagenR";
            lbImagenR.Size = new Size(99, 32);
            lbImagenR.TabIndex = 15;
            lbImagenR.Text = "Imagen:";
            // 
            // txbStockR
            // 
            txbStockR.Location = new Point(37, 579);
            txbStockR.Name = "txbStockR";
            txbStockR.Size = new Size(224, 39);
            txbStockR.TabIndex = 13;
            // 
            // cbTipoR
            // 
            cbTipoR.FormattingEnabled = true;
            cbTipoR.Location = new Point(611, 578);
            cbTipoR.Name = "cbTipoR";
            cbTipoR.Size = new Size(242, 40);
            cbTipoR.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(901, 578);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 39);
            textBox1.TabIndex = 20;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Location = new Point(40, 663);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(89, 36);
            Disponible.TabIndex = 18;
            Disponible.Text = "true";
            Disponible.UseVisualStyleBackColor = true;
            // 
            // btnMostrarR
            // 
            btnMostrarR.Location = new Point(37, 852);
            btnMostrarR.Name = "btnMostrarR";
            btnMostrarR.Size = new Size(200, 94);
            btnMostrarR.TabIndex = 21;
            btnMostrarR.Text = "Mostrar todo";
            btnMostrarR.UseVisualStyleBackColor = true;
            // 
            // btnbuscarR
            // 
            btnbuscarR.Location = new Point(40, 728);
            btnbuscarR.Name = "btnbuscarR";
            btnbuscarR.Size = new Size(200, 94);
            btnbuscarR.TabIndex = 22;
            btnbuscarR.Text = "Buscar por ID";
            btnbuscarR.UseVisualStyleBackColor = true;
            btnbuscarR.Click += btnbuscarR_Click;
            // 
            // btnLimpiarR
            // 
            btnLimpiarR.Location = new Point(1023, 728);
            btnLimpiarR.Name = "btnLimpiarR";
            btnLimpiarR.Size = new Size(200, 94);
            btnLimpiarR.TabIndex = 23;
            btnLimpiarR.Text = "Limpiar Todo";
            btnLimpiarR.UseVisualStyleBackColor = true;
            btnLimpiarR.Click += btnLimpiarR_Click;
            // 
            // lbCategoriaR
            // 
            lbCategoriaR.AutoSize = true;
            lbCategoriaR.Location = new Point(1179, 527);
            lbCategoriaR.Name = "lbCategoriaR";
            lbCategoriaR.Size = new Size(144, 32);
            lbCategoriaR.TabIndex = 24;
            lbCategoriaR.Text = "CategoriaID:";
            // 
            // txbCategoriaR
            // 
            txbCategoriaR.Location = new Point(1179, 579);
            txbCategoriaR.Name = "txbCategoriaR";
            txbCategoriaR.Size = new Size(224, 39);
            txbCategoriaR.TabIndex = 25;
            // 
            // FormRecompensas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 1003);
            Controls.Add(txbCategoriaR);
            Controls.Add(lbCategoriaR);
            Controls.Add(btnLimpiarR);
            Controls.Add(btnbuscarR);
            Controls.Add(btnMostrarR);
            Controls.Add(textBox1);
            Controls.Add(Disponible);
            Controls.Add(cbTipoR);
            Controls.Add(lbImagenR);
            Controls.Add(lbTipoR);
            Controls.Add(txbStockR);
            Controls.Add(txbPuntosR);
            Controls.Add(txbDescripcionR);
            Controls.Add(txbNombreR);
            Controls.Add(txbIDR);
            Controls.Add(lbPuntosR);
            Controls.Add(lbStockR);
            Controls.Add(lbDescripcionR);
            Controls.Add(lbNombreR);
            Controls.Add(lbIDR);
            Controls.Add(btnEliminarR);
            Controls.Add(btnAgregarR);
            Controls.Add(btnActualizarR);
            Controls.Add(DgDatosRecom);
            Name = "FormRecompensas";
            Text = "FormRecompensas";
            Load += FormRecompensas_Load;
            ((System.ComponentModel.ISupportInitialize)DgDatosRecom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgDatosRecom;
        private Button btnActualizarR;
        private Button btnAgregarR;
        private Button btnEliminarR;
        private Label lbIDR;
        private Label lbNombreR;
        private Label lbDescripcionR;
        private Label lbStockR;
        private Label lbPuntosR;
        private TextBox txbIDR;
        private TextBox txbNombreR;
        private TextBox txbDescripcionR;
        private TextBox txbPuntosR;
        private Label lbTipoR;
        private Label lbImagenR;
        private TextBox txbStockR;
        private ComboBox cbTipoR;
        private TextBox textBox1;
        private CheckBox Disponible;
        private Button btnMostrarR;
        private Button btnbuscarR;
        private Button btnLimpiarR;
        private Label lbCategoriaR;
        private TextBox txbCategoriaR;
    }
}