using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Peluquería
{
    public partial class MenuGestión : Form
    {

        private Point dragStartPoint;
        private bool isDragging = false;
        static Conexión conn = new Conexión();
        DataTable turnosHoy = conn.TurnosHoy();
        DataTable clientes = conn.ObtenerClientes();
        DataTable servicios = conn.Servicios();
        public MenuGestión(string User)
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            lblUser.Text = User;
            Opacity = 0;
        }


        private void MenuGestión_Load(object sender, EventArgs e)
        {
            grdTurnos.DataSource = turnosHoy;
            grdTurnos.Columns["TurnoId"].Visible = false;
            grdTurnos.Columns["Fecha"].Visible = false;

            gvClientes.DataSource = clientes;
            gvClientes.Columns["ClienteId"].Visible = false;

            gvServicios.DataSource = servicios;
            gvServicios.Columns["ServicioId"].Visible = false;

            posInicial();
            animacion(true);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("HH:mm") + " hs";
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            moverMenus("Clientes");
        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            moverMenus("Turnos");
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            moverMenus("Servicios");
        }
        private void moverMenus(string menu)
        {
            int posTurno = 0;
            int posCliente = 0;
            int posServicio = 0;
            btnServicios.BackColor = Color.Teal;
            btnTurnos.BackColor = Color.Teal;
            btnClientes.BackColor = Color.Teal;
            if (menu == "Servicios")
            {
                btnServicios.BackColor = Color.LightSeaGreen;
                posTurno = -6000;
                posCliente = -3000;
                posServicio = 300;
            }
            else if (menu == "Clientes")
            {
                btnClientes.BackColor = Color.LightSeaGreen;
                posTurno = -3000;
                posCliente = 300;
                posServicio = 3000;
            }
            else if (menu == "Turnos")
            {
                btnTurnos.BackColor = Color.LightSeaGreen;
                posTurno = 300;
                posCliente = 3000;
                posServicio = 6000;
            }
            Transition t = new Transition(new TransitionType_Linear(300));
            t.add(panelTurnos, "Left", posTurno);
            t.add(panelClientes, "Left", posCliente);
            t.add(panelServicios, "Left", posServicio);
            t.run();
        }
        private void posInicial()
        {
            panelClientes.Location = new Point(3000, 211);
            panelTurnos.Location = new Point(300, 211);
            panelServicios.Location = new Point(6000, 211);
            btnTurnos.BackColor = Color.LightSeaGreen;
        }
        public void animacion(bool aparece)
        {
            if (aparece)
            {
                Transition.run(this, "Opacity", 1.0, new TransitionType_Linear(300));
            }
            else
            {
                Transition transition = new Transition(new TransitionType_Linear(300));
                transition.TransitionCompletedEvent += (s, args) =>
                {
                    this.Close();
                };
                transition.add(this, "Opacity", 0.0);
                transition.run();
            }
        }
        private void InitializeDragEvents(Control control)
        {
            control.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragStartPoint = new Point(e.X, e.Y);
                    isDragging = true;
                }
            };

            control.MouseMove += (sender, e) =>
            {
                if (isDragging)
                {
                    Point difference = new Point(e.X - dragStartPoint.X, e.Y - dragStartPoint.Y);
                    this.Location = new Point(this.Location.X + difference.X, this.Location.Y + difference.Y);
                }
            };

            control.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = false;
                }
            };
        }



                         //TURNOS//

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoTurno nuevoTurno = new NuevoTurno();
            nuevoTurno.ShowDialog();
            turnosHoy = conn.TurnosHoy();
            grdTurnos.DataSource = turnosHoy;
        }
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            VerTodo Menu = new VerTodo();
            Menu.ShowDialog();
            turnosHoy = conn.TurnosHoy();
            grdTurnos.DataSource = turnosHoy;
            MenuGestión_Load(this, e);
        }
        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count > 0)
            {
                DataRowView selectedRowView = (DataRowView)grdTurnos.SelectedRows[0].DataBoundItem;
                DataRow selectedRow = selectedRowView.Row;

                string Turno = selectedRow["TurnoId"].ToString();
                string Horario = selectedRow["Horario"].ToString();
                string Servicio = selectedRow["Servicio"].ToString();
                string Cliente = selectedRow["Cliente"].ToString();
                string Fecha = selectedRow["Fecha"].ToString();
                // Find the row in the DataTable that matches the selected information
                DataRow[] matchingRows = turnosHoy.Select(
                    $"TurnoId = '{Turno}' AND Horario = '{Horario}' AND Servicio = '{Servicio}'");

                if (matchingRows.Length > 0)
                {
                    DataRow rowToDelete = matchingRows[0];

                    string message = "Está seguro que desea eliminar el siguiente turno?: \n\n" +
                                     "Cliente: " + Cliente + "\n\n" +
                                     "Servicio: " + Servicio + "\n\n" +
                                     "Fecha: " + Fecha + "\n\n" +
                                     "Horario: " + Horario + " \n\n";

                    string title = "Advertencia";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int turnoId = Convert.ToInt32(rowToDelete["TurnoId"]);
                        conn.EliminarTurno(turnoId); // Llamar al método para eliminar el turno
                        turnosHoy.Rows.Remove(rowToDelete); // Remove the row from the DataTable
                        grdTurnos.DataSource = turnosHoy; // Reassign the DataTable as the DataSource
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Turno primero!");
            }
        }
        private void btnDetallesTurno_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count > 0)
            {
                int fila = grdTurnos.SelectedRows[0].Index;
                DataRow filaSeleccionada = turnosHoy.Rows[fila];
                Detalles detalles = new Detalles(filaSeleccionada);
                detalles.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Turno de la lista!");
            }
        }


                         //CLIENTES//


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente agregar = new NuevoCliente();
            agregar.ShowDialog();
            clientes = conn.ObtenerClientes();
            gvClientes.DataSource = clientes;

        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRows.Count > 0)
            {
            DataRowView selectedRowView = (DataRowView)gvClientes.SelectedRows[0].DataBoundItem;
            DataRow selectedRow = selectedRowView.Row;

            string ClienteId = selectedRow["ClienteId"].ToString();
            string Nombre = selectedRow["Nombre"].ToString();
            string Apellido = selectedRow["Apellido"].ToString();
            string Teléfono = selectedRow["Teléfono"].ToString();

            DataRow[] matchingRows = clientes.Select(
                   $"ClienteId = '{ClienteId}' AND Nombre = '{Nombre}' AND Apellido = '{Apellido}' AND Teléfono = '{Teléfono}'");


                if (matchingRows.Length > 0)
                {
                    DataRow rowToDelete = matchingRows[0];

                    string message = "Está seguro que desea eliminar el siguiente Cliente?: \n\n" +
                                     "Cliente: " + Nombre + " " + Apellido + "\n\n" +
                                     "Teléfono: " + Teléfono + "\n\n";

                    string title = "Advertencia";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int clienteId = Convert.ToInt32(rowToDelete["ClienteId"]);
                        conn.EliminarCliente(clienteId);
                        clientes.Rows.Remove(rowToDelete);
                        clientes = conn.ObtenerClientes();
                        gvClientes.DataSource = clientes;
                    }
                    else
                    {
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente primero!");
            }
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
           if (gvClientes.SelectedRows.Count > 0)
            {


            DataGridViewRow filaSeleccionada = gvClientes.SelectedRows[0];
            List<TextBox> textBoxes = new List<TextBox>();

            // Obtén la fila seleccionada del DataGridView (asumiendo que tienes un DataGridView llamado gvServicios)

            // Crea una instancia del formulario dinámico
            FormularioDinamico formularioDinamico = new FormularioDinamico(textBoxes);

            // Obtén el número de columnas en la fila seleccionada
            int columnasCount = filaSeleccionada.Cells.Count - 1;

            // Calcula el ancho disponible para cada TextBox
            int anchoFormulario = formularioDinamico.Width;
            int anchoTextBox = (anchoFormulario / columnasCount) - 30; // Resta el espacio entre TextBox

            // Inicializa la posición horizontal
            int posX = 30;

            // Agrega TextBoxes con valores de la fila al formulario dinámico
            foreach (DataGridViewCell celda in filaSeleccionada.Cells)
            {
                if (celda.ColumnIndex == 0)
                {
                    continue;
                }
                else
                {


                    TextBox textBox = new TextBox();
                    textBox.Text = celda.Value.ToString();
                    textBox.BorderStyle = BorderStyle.None;
                    textBox.BackColor = Color.DarkTurquoise;
                    textBox.Font = new Font("Calibri", 12f);
                    textBox.ForeColor = Color.White;
                    textBox.Width = anchoTextBox; // Establece el ancho igual para cada TextBox
                    textBox.Location = new Point(posX, 40); // Establece la posición de cada TextBox
                    textBox.Padding = new Padding(40);
                    textBox.Margin = new Padding(100);
                    formularioDinamico.Controls.Add(textBox);
                    textBoxes.Add(textBox);
                }

                posX += anchoTextBox + 10; // Incrementa la posición horizontal para el siguiente TextBox, incluyendo el espacio entre TextBox
            }

            // Obtiene la posición de la fila seleccionada en relación con el DataGridView
            Point posicionEnDataGridView = gvClientes.GetCellDisplayRectangle(0, filaSeleccionada.Index, false).Location;

            // Convierte la posición en el DataGridView a coordenadas de pantalla 
            Point posicionEnPantalla = gvClientes.PointToScreen(posicionEnDataGridView);

            // Establece la ubicación del formulario dinámico cerca de la fila seleccionada en el DataGridView
            formularioDinamico.StartPosition = FormStartPosition.Manual;
            formularioDinamico.Location = new Point(
                posicionEnPantalla.X + 22, // Añade un pequeño desplazamiento a la izquierda para evitar la superposición del borde
                posicionEnPantalla.Y + filaSeleccionada.Height  // 5 es el espacio entre el DataGridView y el formulario
            );

            // Establece el tamaño del formulario dinámico
            formularioDinamico.Width = anchoFormulario;

            // Muestra el formulario dinámico
            formularioDinamico.ShowDialog();
            if (formularioDinamico.DialogResult == DialogResult.OK)
            {
                // Aplica los cambios al DataGridView
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    filaSeleccionada.Cells[i + 1].Value = textBoxes[i].Text; // El índice 1 se usa para omitir la primera columna
                }
            }
            int ClienteId = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
            string Nombre = filaSeleccionada.Cells[1].Value.ToString();
            string Apellido = filaSeleccionada.Cells[2].Value.ToString();
            string Teléfono = filaSeleccionada.Cells[3].Value.ToString();

            conn.EditarCliente(ClienteId, Nombre, Apellido, Teléfono);
            clientes = conn.ObtenerClientes();
            gvClientes.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente primero!");
            }
        }

                         //SERVICIOS//

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            NuevoServicio serv = new NuevoServicio();
            serv.ShowDialog();
            servicios = conn.Servicios();
            gvServicios.DataSource = servicios;
        }
        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (gvServicios.SelectedRows.Count > 0)
            {
                int fila = gvServicios.SelectedRows[0].Index;
                int servicioId = Convert.ToInt32(gvServicios.Rows[fila].Cells["ServicioId"].Value);
                string servicioNombre = gvServicios.Rows[fila].Cells["Servicio"].Value.ToString();
                decimal precio = Convert.ToDecimal(gvServicios.Rows[fila].Cells["Precio"].Value);

                // Mostrar un cuadro de diálogo de confirmación
                string mensaje = $"¿Está seguro de que quiere eliminar el siguiente Servicio?\n\nServicio: {servicioNombre}\nPrecio: {precio:C}";
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    conn.EliminarServicio(servicioId);
                    servicios = conn.Servicios();
                    gvServicios.DataSource = servicios;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Servicio Primero!");
            }
        }
        private void btnEditarServicio_Click(object sender, EventArgs e)
        {

        }


    }
}
