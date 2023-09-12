
namespace Peluquería
{
    partial class MenuGestión
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnMinimizar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGestión));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new System.Windows.Forms.Label();
            this.TimerTransicion = new System.Windows.Forms.Timer(this.components);
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelTurnos = new System.Windows.Forms.Panel();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.grdTurnos = new System.Windows.Forms.DataGridView();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.gvClientes = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblOpcionesClientes = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.gvServicios = new System.Windows.Forms.DataGridView();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblOpcionesServicios = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnEditarServicio = new System.Windows.Forms.Button();
            this.pnlDrag = new System.Windows.Forms.Panel();
            btnMinimizar = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.panelTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).BeginInit();
            this.panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnMinimizar.CausesValidation = false;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            btnMinimizar.Location = new System.Drawing.Point(1082, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnMinimizar.Size = new System.Drawing.Size(40, 30);
            btnMinimizar.TabIndex = 28;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LblTime.Location = new System.Drawing.Point(1043, 652);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(77, 36);
            this.LblTime.TabIndex = 18;
            this.LblTime.Text = "Label";
            // 
            // btnTurnos
            // 
            this.btnTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurnos.BackColor = System.Drawing.Color.Teal;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.Transparent;
            this.btnTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnos.Location = new System.Drawing.Point(0, 0);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(367, 48);
            this.btnTurnos.TabIndex = 22;
            this.btnTurnos.Text = "TURNOS";
            this.btnTurnos.UseMnemonic = false;
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.Teal;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(367, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(454, 48);
            this.btnClientes.TabIndex = 23;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServicios.BackColor = System.Drawing.Color.Teal;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.Transparent;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServicios.Location = new System.Drawing.Point(821, 0);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(0);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(347, 48);
            this.btnServicios.TabIndex = 24;
            this.btnServicios.Text = "SERVICIOS";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnServicios);
            this.panelBotones.Controls.Add(this.btnTurnos);
            this.panelBotones.Controls.Add(this.btnClientes);
            this.panelBotones.Location = new System.Drawing.Point(1, 43);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1168, 48);
            this.panelBotones.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblUser.Location = new System.Drawing.Point(12, 655);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 33);
            this.lblUser.TabIndex = 35;
            // 
            // panelTurnos
            // 
            this.panelTurnos.Controls.Add(this.btnVerTodo);
            this.panelTurnos.Controls.Add(this.grdTurnos);
            this.panelTurnos.Controls.Add(this.lblTurnos);
            this.panelTurnos.Controls.Add(this.lblOpciones);
            this.panelTurnos.Controls.Add(this.btnAgregarTurno);
            this.panelTurnos.Controls.Add(this.btnEliminarTurno);
            this.panelTurnos.Controls.Add(this.btnEditarTurno);
            this.panelTurnos.Location = new System.Drawing.Point(-307, 211);
            this.panelTurnos.Name = "panelTurnos";
            this.panelTurnos.Size = new System.Drawing.Size(674, 314);
            this.panelTurnos.TabIndex = 36;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerTodo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVerTodo.FlatAppearance.BorderSize = 0;
            this.btnVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodo.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerTodo.Location = new System.Drawing.Point(490, 267);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(182, 47);
            this.btnVerTodo.TabIndex = 65;
            this.btnVerTodo.Text = "VER TODO";
            this.btnVerTodo.UseVisualStyleBackColor = false;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // grdTurnos
            // 
            this.grdTurnos.AllowUserToAddRows = false;
            this.grdTurnos.AllowUserToDeleteRows = false;
            this.grdTurnos.AllowUserToResizeColumns = false;
            this.grdTurnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.Teal;
            this.grdTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.grdTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTurnos.BackgroundColor = System.Drawing.Color.Teal;
            this.grdTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTurnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTurnos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.grdTurnos.ColumnHeadersHeight = 25;
            this.grdTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTurnos.DefaultCellStyle = dataGridViewCellStyle48;
            this.grdTurnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTurnos.EnableHeadersVisualStyles = false;
            this.grdTurnos.GridColor = System.Drawing.Color.Teal;
            this.grdTurnos.Location = new System.Drawing.Point(3, 49);
            this.grdTurnos.MultiSelect = false;
            this.grdTurnos.Name = "grdTurnos";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.grdTurnos.RowHeadersVisible = false;
            this.grdTurnos.RowHeadersWidth = 40;
            this.grdTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            this.grdTurnos.RowsDefaultCellStyle = dataGridViewCellStyle50;
            this.grdTurnos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTurnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTurnos.Size = new System.Drawing.Size(454, 265);
            this.grdTurnos.TabIndex = 60;
            this.grdTurnos.VirtualMode = true;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTurnos.Location = new System.Drawing.Point(141, 2);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(200, 33);
            this.lblTurnos.TabIndex = 59;
            this.lblTurnos.Text = "TURNOS DE HOY";
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
            this.lblOpciones.Location = new System.Drawing.Point(520, 2);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(136, 33);
            this.lblOpciones.TabIndex = 64;
            this.lblOpciones.Text = "OPCIONES ";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarTurno.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarTurno.FlatAppearance.BorderSize = 0;
            this.btnAgregarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTurno.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTurno.Location = new System.Drawing.Point(491, 49);
            this.btnAgregarTurno.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(182, 47);
            this.btnAgregarTurno.TabIndex = 61;
            this.btnAgregarTurno.Text = "AGREGAR TURNO";
            this.btnAgregarTurno.UseVisualStyleBackColor = false;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarTurno.FlatAppearance.BorderSize = 0;
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTurno.Location = new System.Drawing.Point(491, 193);
            this.btnEliminarTurno.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(182, 47);
            this.btnEliminarTurno.TabIndex = 63;
            this.btnEliminarTurno.Text = "ELIMINAR";
            this.btnEliminarTurno.UseVisualStyleBackColor = false;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditarTurno.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarTurno.FlatAppearance.BorderSize = 0;
            this.btnEditarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTurno.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.Location = new System.Drawing.Point(491, 120);
            this.btnEditarTurno.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(182, 47);
            this.btnEditarTurno.TabIndex = 62;
            this.btnEditarTurno.Text = "DETALLES";
            this.btnEditarTurno.UseVisualStyleBackColor = false;
            this.btnEditarTurno.Click += new System.EventHandler(this.btnEditarTurno_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 27);
            this.textBox1.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(801, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 27);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1129, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.gvClientes);
            this.panelClientes.Controls.Add(this.lblClientes);
            this.panelClientes.Controls.Add(this.lblOpcionesClientes);
            this.panelClientes.Controls.Add(this.btnAgregarCliente);
            this.panelClientes.Controls.Add(this.btnEliminarCliente);
            this.panelClientes.Location = new System.Drawing.Point(368, 211);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(674, 314);
            this.panelClientes.TabIndex = 53;
            // 
            // gvClientes
            // 
            this.gvClientes.AllowUserToAddRows = false;
            this.gvClientes.AllowUserToDeleteRows = false;
            this.gvClientes.AllowUserToResizeColumns = false;
            this.gvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.Teal;
            this.gvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle51;
            this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvClientes.BackgroundColor = System.Drawing.Color.Teal;
            this.gvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.gvClientes.ColumnHeadersHeight = 25;
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvClientes.DefaultCellStyle = dataGridViewCellStyle53;
            this.gvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvClientes.EnableHeadersVisualStyles = false;
            this.gvClientes.GridColor = System.Drawing.Color.Teal;
            this.gvClientes.Location = new System.Drawing.Point(2, 49);
            this.gvClientes.MultiSelect = false;
            this.gvClientes.Name = "gvClientes";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.gvClientes.RowHeadersVisible = false;
            this.gvClientes.RowHeadersWidth = 40;
            this.gvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.White;
            this.gvClientes.RowsDefaultCellStyle = dataGridViewCellStyle55;
            this.gvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClientes.Size = new System.Drawing.Size(451, 265);
            this.gvClientes.TabIndex = 60;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClientes.Location = new System.Drawing.Point(167, 2);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(117, 33);
            this.lblClientes.TabIndex = 59;
            this.lblClientes.Text = "CLIENTES";
            // 
            // lblOpcionesClientes
            // 
            this.lblOpcionesClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpcionesClientes.AutoSize = true;
            this.lblOpcionesClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpcionesClientes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesClientes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOpcionesClientes.Location = new System.Drawing.Point(522, 2);
            this.lblOpcionesClientes.Name = "lblOpcionesClientes";
            this.lblOpcionesClientes.Size = new System.Drawing.Size(136, 33);
            this.lblOpcionesClientes.TabIndex = 64;
            this.lblOpcionesClientes.Text = "OPCIONES ";
            this.lblOpcionesClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCliente.Location = new System.Drawing.Point(491, 49);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(182, 47);
            this.btnAgregarCliente.TabIndex = 61;
            this.btnAgregarCliente.Text = "AGREGAR";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCliente.Location = new System.Drawing.Point(492, 122);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(182, 47);
            this.btnEliminarCliente.TabIndex = 63;
            this.btnEliminarCliente.Text = "ELIMINAR";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // panelServicios
            // 
            this.panelServicios.Controls.Add(this.gvServicios);
            this.panelServicios.Controls.Add(this.lblServicios);
            this.panelServicios.Controls.Add(this.lblOpcionesServicios);
            this.panelServicios.Controls.Add(this.btnAgregarServicio);
            this.panelServicios.Controls.Add(this.btnEliminarServicio);
            this.panelServicios.Controls.Add(this.btnEditarServicio);
            this.panelServicios.Location = new System.Drawing.Point(368, 211);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(674, 314);
            this.panelServicios.TabIndex = 54;
            // 
            // gvServicios
            // 
            this.gvServicios.AllowUserToAddRows = false;
            this.gvServicios.AllowUserToDeleteRows = false;
            this.gvServicios.AllowUserToResizeColumns = false;
            this.gvServicios.AllowUserToResizeRows = false;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.Teal;
            this.gvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle56;
            this.gvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvServicios.BackgroundColor = System.Drawing.Color.Teal;
            this.gvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvServicios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.gvServicios.ColumnHeadersHeight = 25;
            this.gvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvServicios.DefaultCellStyle = dataGridViewCellStyle58;
            this.gvServicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvServicios.EnableHeadersVisualStyles = false;
            this.gvServicios.GridColor = System.Drawing.Color.Teal;
            this.gvServicios.Location = new System.Drawing.Point(32, 49);
            this.gvServicios.MultiSelect = false;
            this.gvServicios.Name = "gvServicios";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.gvServicios.RowHeadersVisible = false;
            this.gvServicios.RowHeadersWidth = 40;
            this.gvServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.White;
            this.gvServicios.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.gvServicios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvServicios.Size = new System.Drawing.Size(311, 265);
            this.gvServicios.TabIndex = 66;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.ForeColor = System.Drawing.SystemColors.Window;
            this.lblServicios.Location = new System.Drawing.Point(130, 0);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(131, 33);
            this.lblServicios.TabIndex = 65;
            this.lblServicios.Text = "SERVICIOS";
            // 
            // lblOpcionesServicios
            // 
            this.lblOpcionesServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpcionesServicios.AutoSize = true;
            this.lblOpcionesServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpcionesServicios.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesServicios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOpcionesServicios.Location = new System.Drawing.Point(490, 0);
            this.lblOpcionesServicios.Name = "lblOpcionesServicios";
            this.lblOpcionesServicios.Size = new System.Drawing.Size(136, 33);
            this.lblOpcionesServicios.TabIndex = 70;
            this.lblOpcionesServicios.Text = "OPCIONES ";
            this.lblOpcionesServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarServicio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarServicio.Location = new System.Drawing.Point(460, 49);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(182, 47);
            this.btnAgregarServicio.TabIndex = 67;
            this.btnAgregarServicio.Text = "AGREGAR";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarServicio.Location = new System.Drawing.Point(460, 200);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(182, 47);
            this.btnEliminarServicio.TabIndex = 69;
            this.btnEliminarServicio.Text = "ELIMINAR";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditarServicio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarServicio.FlatAppearance.BorderSize = 0;
            this.btnEditarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarServicio.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarServicio.Location = new System.Drawing.Point(460, 123);
            this.btnEditarServicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(182, 47);
            this.btnEditarServicio.TabIndex = 68;
            this.btnEditarServicio.Text = "EDITAR";
            this.btnEditarServicio.UseVisualStyleBackColor = false;
            // 
            // pnlDrag
            // 
            this.pnlDrag.Location = new System.Drawing.Point(0, 1);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(1076, 29);
            this.pnlDrag.TabIndex = 55;
            // 
            // MenuGestión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1169, 697);
            this.Controls.Add(this.panelTurnos);
            this.Controls.Add(this.panelServicios);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(btnMinimizar);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.pnlDrag);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuGestión";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peluquería Erica Martinez";
            this.Load += new System.EventHandler(this.MenuGestión_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelTurnos.ResumeLayout(false);
            this.panelTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).EndInit();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.panelServicios.ResumeLayout(false);
            this.panelServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer TimerTransicion;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelTurnos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.DataGridView grdTurnos;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnEditarTurno;
        private System.Windows.Forms.DataGridView gvClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblOpcionesClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView gvServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblOpcionesServicios;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnEditarServicio;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Button btnEliminarCliente;
    }
}