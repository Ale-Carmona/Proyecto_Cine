namespace Proyecto_Cine
{
    partial class FormLogin
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
            DgDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgDatos).BeginInit();
            SuspendLayout();
            // 
            // DgDatos
            // 
            DgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgDatos.Location = new Point(527, 26);
            DgDatos.Name = "DgDatos";
            DgDatos.RowHeadersWidth = 82;
            DgDatos.Size = new Size(930, 464);
            DgDatos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 708);
            Controls.Add(DgDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgDatos;
    }
}
