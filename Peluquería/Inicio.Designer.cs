
namespace Peluquería
{
    partial class Inicio
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
            System.Windows.Forms.Button btnMinimizar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.txtboxUsuario = new System.Windows.Forms.TextBox();
            this.txtboxContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.PanelSesión = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ImagenLogo = new System.Windows.Forms.PictureBox();
            this.LinkInvitado = new System.Windows.Forms.LinkLabel();
            btnMinimizar = new System.Windows.Forms.Button();
            this.PanelSesión.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMinimizar.CausesValidation = false;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Image = global::Peluquería.Properties.Resources.icons8_menos_30;
            btnMinimizar.Location = new System.Drawing.Point(466, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnMinimizar.Size = new System.Drawing.Size(40, 30);
            btnMinimizar.TabIndex = 13;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtboxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxUsuario.CausesValidation = false;
            this.txtboxUsuario.Location = new System.Drawing.Point(85, 17);
            this.txtboxUsuario.MaxLength = 20;
            this.txtboxUsuario.Name = "txtboxUsuario";
            this.txtboxUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsuario.TabIndex = 0;
            // 
            // txtboxContraseña
            // 
            this.txtboxContraseña.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtboxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxContraseña.Location = new System.Drawing.Point(85, 43);
            this.txtboxContraseña.Name = "txtboxContraseña";
            this.txtboxContraseña.PasswordChar = '●';
            this.txtboxContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtboxContraseña.TabIndex = 1;
            this.txtboxContraseña.TextChanged += new System.EventHandler(this.txtboxContraseña_TextChanged);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciarSesión.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciarSesión.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.Location = new System.Drawing.Point(205, 17);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(63, 46);
            this.btnIniciarSesión.TabIndex = 9;
            this.btnIniciarSesión.Text = "Iniciar Sesión";
            this.btnIniciarSesión.UseVisualStyleBackColor = false;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            // 
            // PanelSesión
            // 
            this.PanelSesión.BackColor = System.Drawing.Color.DarkCyan;
            this.PanelSesión.Controls.Add(this.txtboxUsuario);
            this.PanelSesión.Controls.Add(this.btnIniciarSesión);
            this.PanelSesión.Controls.Add(this.txtboxContraseña);
            this.PanelSesión.Location = new System.Drawing.Point(128, 158);
            this.PanelSesión.Name = "PanelSesión";
            this.PanelSesión.Size = new System.Drawing.Size(292, 90);
            this.PanelSesión.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Peluquería.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnCerrar.Location = new System.Drawing.Point(511, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ImagenLogo
            // 
            this.ImagenLogo.Image = global::Peluquería.Properties.Resources.Imagen_de_WhatsApp_2022_12_19_a_las_12_41_46_removebg_preview;
            this.ImagenLogo.Location = new System.Drawing.Point(105, 33);
            this.ImagenLogo.Name = "ImagenLogo";
            this.ImagenLogo.Size = new System.Drawing.Size(340, 119);
            this.ImagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenLogo.TabIndex = 15;
            this.ImagenLogo.TabStop = false;
            // 
            // LinkInvitado
            // 
            this.LinkInvitado.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.LinkInvitado.AutoSize = true;
            this.LinkInvitado.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkInvitado.Location = new System.Drawing.Point(211, 256);
            this.LinkInvitado.Name = "LinkInvitado";
            this.LinkInvitado.Size = new System.Drawing.Size(105, 13);
            this.LinkInvitado.TabIndex = 16;
            this.LinkInvitado.TabStop = true;
            this.LinkInvitado.Text = "Entrar como Invitado";
            this.LinkInvitado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInvitado_LinkClicked);
            // 
            // Inicio
            // 
            this.AcceptButton = this.btnIniciarSesión;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.LinkInvitado);
            this.Controls.Add(this.ImagenLogo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(btnMinimizar);
            this.Controls.Add(this.PanelSesión);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peluquería Erica Martinez";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseUp);
            this.PanelSesión.ResumeLayout(false);
            this.PanelSesión.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxUsuario;
        private System.Windows.Forms.TextBox txtboxContraseña;
        private System.Windows.Forms.Button btnIniciarSesión;
        private System.Windows.Forms.Panel PanelSesión;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox ImagenLogo;
        private System.Windows.Forms.LinkLabel LinkInvitado;
    }
}

