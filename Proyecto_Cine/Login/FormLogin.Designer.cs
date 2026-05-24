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
            lbCorreoL = new Label();
            lbPassword = new Label();
            txbEmail = new TextBox();
            txbPassword = new TextBox();
            btnEntrar = new Button();
            btnRegistrarse = new Button();
            lblError = new Label();
            chkRecordar = new CheckBox();
            SuspendLayout();
            // 
            // lbCorreoL
            // 
            lbCorreoL.AutoSize = true;
            lbCorreoL.Location = new Point(340, 110);
            lbCorreoL.Name = "lbCorreoL";
            lbCorreoL.Size = new Size(210, 32);
            lbCorreoL.TabIndex = 0;
            lbCorreoL.Text = "Correo Electronico";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(395, 253);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(134, 32);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Contraseña";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(246, 155);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(432, 39);
            txbEmail.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(246, 288);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(432, 39);
            txbPassword.TabIndex = 3;
            // 
            // lblError — NUEVO
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(246, 380);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 32);
            lblError.TabIndex = 6;
            lblError.Text = "";
            lblError.Visible = false;
            // 
            // chkRecordar — NUEVO
            // 
            chkRecordar.AutoSize = true;
            chkRecordar.Location = new Point(246, 340);
            chkRecordar.Name = "chkRecordar";
            chkRecordar.Size = new Size(200, 36);
            chkRecordar.TabIndex = 7;
            chkRecordar.Text = "Recordar sesión";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(410, 423);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(150, 46);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(410, 531);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(150, 46);
            btnRegistrarse.TabIndex = 5;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 708);
            Controls.Add(chkRecordar);
            Controls.Add(lblError);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnEntrar);
            Controls.Add(txbPassword);
            Controls.Add(txbEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbCorreoL);
            Load += FormLogin_Load;
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCorreoL;
        private Label lbPassword;
        private TextBox txbEmail;
        private TextBox txbPassword;
        private Button btnEntrar;
        private Button btnRegistrarse;
        private Label lblError;
        private CheckBox chkRecordar;
    }
}
