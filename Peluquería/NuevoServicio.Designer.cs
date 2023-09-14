
namespace Peluquería
{
    partial class NuevoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoServicio));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.Borde2 = new System.Windows.Forms.Panel();
            this.Borde = new System.Windows.Forms.Panel();
            this.txtbxServicio = new System.Windows.Forms.TextBox();
            this.txtbxPrecio = new System.Windows.Forms.TextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(381, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpciones.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOpciones.Location = new System.Drawing.Point(105, 9);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(206, 33);
            this.lblOpciones.TabIndex = 65;
            this.lblOpciones.Text = "NUEVO SERVICIO";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Borde2
            // 
            this.Borde2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Borde2.Location = new System.Drawing.Point(155, 126);
            this.Borde2.Name = "Borde2";
            this.Borde2.Size = new System.Drawing.Size(160, 1);
            this.Borde2.TabIndex = 82;
            // 
            // Borde
            // 
            this.Borde.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Borde.Location = new System.Drawing.Point(155, 85);
            this.Borde.Name = "Borde";
            this.Borde.Size = new System.Drawing.Size(160, 1);
            this.Borde.TabIndex = 81;
            // 
            // txtbxServicio
            // 
            this.txtbxServicio.BackColor = System.Drawing.Color.Teal;
            this.txtbxServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxServicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbxServicio.Location = new System.Drawing.Point(156, 67);
            this.txtbxServicio.Name = "txtbxServicio";
            this.txtbxServicio.Size = new System.Drawing.Size(158, 16);
            this.txtbxServicio.TabIndex = 79;
            this.txtbxServicio.Enter += new System.EventHandler(this.txtbxServicio_Enter);
            this.txtbxServicio.Leave += new System.EventHandler(this.txtbxServicio_Leave);
            // 
            // txtbxPrecio
            // 
            this.txtbxPrecio.BackColor = System.Drawing.Color.Teal;
            this.txtbxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxPrecio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbxPrecio.Location = new System.Drawing.Point(177, 108);
            this.txtbxPrecio.Name = "txtbxPrecio";
            this.txtbxPrecio.Size = new System.Drawing.Size(138, 16);
            this.txtbxPrecio.TabIndex = 80;
            this.txtbxPrecio.Enter += new System.EventHandler(this.txtbxPrecio_Enter);
            this.txtbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPrecio_KeyPress);
            this.txtbxPrecio.Leave += new System.EventHandler(this.txtbxPrecio_Leave);
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(76, 64);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(78, 23);
            this.lblServicio.TabIndex = 83;
            this.lblServicio.Text = "Servicio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(90, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(87, 23);
            this.lblPrecio.TabIndex = 84;
            this.lblPrecio.Text = "Precio:   $";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarServicio.Location = new System.Drawing.Point(102, 146);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(209, 39);
            this.btnAgregarServicio.TabIndex = 90;
            this.btnAgregarServicio.Text = "AGREGAR SERVICIO";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // NuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(422, 204);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.Borde2);
            this.Controls.Add(this.Borde);
            this.Controls.Add(this.txtbxServicio);
            this.Controls.Add(this.txtbxPrecio);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoServicio";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NuevoServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Panel Borde2;
        private System.Windows.Forms.Panel Borde;
        private System.Windows.Forms.TextBox txtbxServicio;
        private System.Windows.Forms.TextBox txtbxPrecio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregarServicio;
    }
}