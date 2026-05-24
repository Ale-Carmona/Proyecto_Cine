namespace Proyecto_Cine.Login
{
    partial class FormRegistro
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
            NombreCompleto = new Label();
            lbCorreo = new Label();
            lbPassword = new Label();
            lbConfirmar = new Label();
            txbNombreRes = new TextBox();
            txbCorreoRes = new TextBox();
            txbPasswordRes = new TextBox();
            txbConfirmar = new TextBox();
            btnResgistrarseRes = new Button();
            btnCancelar = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSize = true;
            NombreCompleto.Location = new Point(283, 53);
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Size = new Size(206, 32);
            NombreCompleto.TabIndex = 0;
            NombreCompleto.Text = "nombre completo";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(283, 185);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(210, 32);
            lbCorreo.TabIndex = 1;
            lbCorreo.Text = "Correo Electronico";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(121, 315);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(134, 32);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Contraseña";
            // 
            // lbConfirmar
            // 
            lbConfirmar.AutoSize = true;
            lbConfirmar.Location = new Point(487, 305);
            lbConfirmar.Name = "lbConfirmar";
            lbConfirmar.Size = new Size(120, 32);
            lbConfirmar.TabIndex = 3;
            lbConfirmar.Text = "Confirmar";
            // 
            // lblError — NUEVO
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(179, 415);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 32);
            lblError.TabIndex = 10;
            lblError.Text = "";
            lblError.Visible = false;
            // 
            // txbNombreRes
            // 
            txbNombreRes.Location = new Point(233, 98);
            txbNombreRes.Name = "txbNombreRes";
            txbNombreRes.Size = new Size(308, 39);
            txbNombreRes.TabIndex = 4;
            // 
            // txbCorreoRes
            // 
            txbCorreoRes.Location = new Point(233, 220);
            txbCorreoRes.Name = "txbCorreoRes";
            txbCorreoRes.Size = new Size(308, 39);
            txbCorreoRes.TabIndex = 5;
            // 
            // txbPasswordRes
            // 
            txbPasswordRes.Location = new Point(51, 350);
            txbPasswordRes.Name = "txbPasswordRes";
            txbPasswordRes.Size = new Size(308, 39);
            txbPasswordRes.TabIndex = 6;
            // 
            // txbConfirmar
            // 
            txbConfirmar.Location = new Point(409, 350);
            txbConfirmar.Name = "txbConfirmar";
            txbConfirmar.Size = new Size(308, 39);
            txbConfirmar.TabIndex = 7;
            // 
            // btnResgistrarseRes
            // 
            btnResgistrarseRes.Location = new Point(179, 456);
            btnResgistrarseRes.Name = "btnResgistrarseRes";
            btnResgistrarseRes.Size = new Size(150, 46);
            btnResgistrarseRes.TabIndex = 8;
            btnResgistrarseRes.Text = "Registrarse";
            btnResgistrarseRes.UseVisualStyleBackColor = true;
            btnResgistrarseRes.Click += btnResgistrarseRes_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 456);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(lblError);
            Controls.Add(btnCancelar);
            Controls.Add(btnResgistrarseRes);
            Controls.Add(txbConfirmar);
            Controls.Add(txbPasswordRes);
            Controls.Add(txbCorreoRes);
            Controls.Add(txbNombreRes);
            Controls.Add(lbConfirmar);
            Controls.Add(lbPassword);
            Controls.Add(lbCorreo);
            Controls.Add(NombreCompleto);
            Name = "FormRegistro";
            Text = "FormRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreCompleto;
        private Label lbCorreo;
        private Label lbPassword;
        private Label lbConfirmar;
        private TextBox txbNombreRes;
        private TextBox txbCorreoRes;
        private TextBox txbPasswordRes;
        private TextBox txbConfirmar;
        private Button btnResgistrarseRes;
        private Button btnCancelar;
        private Label lblError;
    }
}