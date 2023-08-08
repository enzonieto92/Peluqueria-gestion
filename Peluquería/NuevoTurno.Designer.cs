
namespace Peluquería
{
    partial class NuevoTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoTurno));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.txtbxTelefono = new System.Windows.Forms.TextBox();
            this.txtbxApellido = new System.Windows.Forms.TextBox();
            this.cbxServicios = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHS = new System.Windows.Forms.Label();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxMinuto = new System.Windows.Forms.ComboBox();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(75, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVO TURNO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(55, 148);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 23);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(59, 190);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(78, 23);
            this.lblServicio.TabIndex = 6;
            this.lblServicio.Text = "Servicio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(74, 232);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 23);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(53, 272);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(83, 23);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarTurno.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregarTurno.FlatAppearance.BorderSize = 0;
            this.btnAgregarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTurno.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTurno.Location = new System.Drawing.Point(77, 316);
            this.btnAgregarTurno.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(182, 47);
            this.btnAgregarTurno.TabIndex = 62;
            this.btnAgregarTurno.Text = "AGREGAR TURNO";
            this.btnAgregarTurno.UseVisualStyleBackColor = false;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombre.Location = new System.Drawing.Point(143, 108);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(158, 23);
            this.txtbxNombre.TabIndex = 65;
            // 
            // txtbxTelefono
            // 
            this.txtbxTelefono.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtbxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTelefono.Location = new System.Drawing.Point(143, 272);
            this.txtbxTelefono.Name = "txtbxTelefono";
            this.txtbxTelefono.Size = new System.Drawing.Size(158, 23);
            this.txtbxTelefono.TabIndex = 69;
            // 
            // txtbxApellido
            // 
            this.txtbxApellido.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtbxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxApellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxApellido.Location = new System.Drawing.Point(143, 148);
            this.txtbxApellido.Name = "txtbxApellido";
            this.txtbxApellido.Size = new System.Drawing.Size(158, 23);
            this.txtbxApellido.TabIndex = 66;
            // 
            // cbxServicios
            // 
            this.cbxServicios.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbxServicios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxServicios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxServicios.FormattingEnabled = true;
            this.cbxServicios.IntegralHeight = false;
            this.cbxServicios.Location = new System.Drawing.Point(144, 190);
            this.cbxServicios.Name = "cbxServicios";
            this.cbxServicios.Size = new System.Drawing.Size(157, 21);
            this.cbxServicios.TabIndex = 67;
            // 
            // dtpFecha
            // 
            this.dtpFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(143, 236);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 17, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2023, 8, 3, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeftLayout = true;
            this.dtpFecha.Size = new System.Drawing.Size(82, 20);
            this.dtpFecha.TabIndex = 68;
            this.dtpFecha.Value = new System.DateTime(2023, 8, 5, 0, 0, 0, 0);
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHS.Location = new System.Drawing.Point(287, 234);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(31, 23);
            this.lblHS.TabIndex = 73;
            this.lblHS.Text = "HS";
            // 
            // cbxHora
            // 
            this.cbxHora.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.DropDownWidth = 15;
            this.cbxHora.ForeColor = System.Drawing.SystemColors.Window;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxHora.IntegralHeight = false;
            this.cbxHora.ItemHeight = 13;
            this.cbxHora.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cbxHora.Location = new System.Drawing.Point(229, 235);
            this.cbxHora.MaxDropDownItems = 20;
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(36, 21);
            this.cbxHora.Sorted = true;
            this.cbxHora.TabIndex = 74;
            // 
            // cbxMinuto
            // 
            this.cbxMinuto.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cbxMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinuto.DropDownWidth = 15;
            this.cbxMinuto.FormattingEnabled = true;
            this.cbxMinuto.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cbxMinuto.Location = new System.Drawing.Point(265, 235);
            this.cbxMinuto.Name = "cbxMinuto";
            this.cbxMinuto.Size = new System.Drawing.Size(36, 21);
            this.cbxMinuto.TabIndex = 75;
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparacion.Location = new System.Drawing.Point(251, 233);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(15, 23);
            this.lblSeparacion.TabIndex = 76;
            this.lblSeparacion.Text = ":";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Peluquería.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnCerrar.Location = new System.Drawing.Point(288, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // NuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(330, 401);
            this.Controls.Add(this.lblSeparacion);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.txtbxTelefono);
            this.Controls.Add(this.txtbxApellido);
            this.Controls.Add(this.cbxServicios);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxMinuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoTurno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoTurno";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NuevoTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.TextBox txtbxTelefono;
        private System.Windows.Forms.TextBox txtbxApellido;
        private System.Windows.Forms.ComboBox cbxServicios;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.ComboBox cbxMinuto;
        private System.Windows.Forms.Label lblSeparacion;
    }
}