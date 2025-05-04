namespace InterfazGrafica
{
    partial class Acceso
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
            this.lblTituloAcesso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnIngresarAcceso = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.linkRevisarAccesos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTituloAcesso
            // 
            this.lblTituloAcesso.AutoSize = true;
            this.lblTituloAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAcesso.Location = new System.Drawing.Point(45, 50);
            this.lblTituloAcesso.Name = "lblTituloAcesso";
            this.lblTituloAcesso.Size = new System.Drawing.Size(282, 31);
            this.lblTituloAcesso.TabIndex = 0;
            this.lblTituloAcesso.Text = "ACCESO CRM AIEP";
            this.lblTituloAcesso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(102, 143);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(172, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(172, 181);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(128, 26);
            this.txtClave.TabIndex = 3;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(102, 184);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(48, 20);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // btnIngresarAcceso
            // 
            this.btnIngresarAcceso.BackColor = System.Drawing.SystemColors.Info;
            this.btnIngresarAcceso.Location = new System.Drawing.Point(210, 242);
            this.btnIngresarAcceso.Name = "btnIngresarAcceso";
            this.btnIngresarAcceso.Size = new System.Drawing.Size(90, 33);
            this.btnIngresarAcceso.TabIndex = 5;
            this.btnIngresarAcceso.Text = "Ingresar";
            this.btnIngresarAcceso.UseVisualStyleBackColor = false;
            this.btnIngresarAcceso.Click += new System.EventHandler(this.btnIngresarAcceso_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(102, 313);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 6;
            // 
            // linkRevisarAccesos
            // 
            this.linkRevisarAccesos.AutoSize = true;
            this.linkRevisarAccesos.Location = new System.Drawing.Point(268, 518);
            this.linkRevisarAccesos.Name = "linkRevisarAccesos";
            this.linkRevisarAccesos.Size = new System.Drawing.Size(86, 13);
            this.linkRevisarAccesos.TabIndex = 7;
            this.linkRevisarAccesos.TabStop = true;
            this.linkRevisarAccesos.Text = "Revisar accesos";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.linkRevisarAccesos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnIngresarAcceso);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTituloAcesso);
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAcesso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnIngresarAcceso;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.LinkLabel linkRevisarAccesos;
    }
}

