using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Peluquería
{
    public partial class VerTodo : Form
    {
        static Conexión conn = new Conexión();
        DataTable Turnos = conn.Turnos();

        public VerTodo()
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            Opacity = 0;
        }

        private Point dragStartPoint;
        private bool isDragging = false;
        private void VerTodo_Load(object sender, EventArgs e)
        {
            animacion(true);
            grdTurnos.DataSource = Turnos;
            grdTurnos.Columns["TurnoId"].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (grdTurnos.SelectedRows.Count > 0)
            {
                DataRowView selectedRowView = (DataRowView)grdTurnos.SelectedRows[0].DataBoundItem;
                DataRow selectedRow = selectedRowView.Row;

                string Cliente = selectedRow["Cliente"].ToString();
                string Horario = selectedRow["Horario"].ToString();
                string Servicio = selectedRow["Servicio"].ToString();
                string Fecha = selectedRow["Fecha"].ToString();
                // Find the row in the DataTable that matches the selected information
                DataRow[] matchingRows = Turnos.Select(
                    $"[Cliente] = '{Cliente}' AND Horario = '{Horario}' AND Servicio = '{Servicio}'");

                if (matchingRows.Length > 0)
                {
                    DataRow rowToDelete = matchingRows[0];

                    string message = "Está seguro que desea eliminar el siguiente turno?: \n\n" +
                                     "Cliente: " + Cliente + "\n\n" +
                                     "Servicio: " + Servicio + "\n\n" +
                                     "Fecha: " + Fecha + "\n\n" +
                                     "Horario: " + Horario + "\n\n";

                    string title = "Advertencia";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int turnoId = Convert.ToInt32(rowToDelete["TurnoId"]);

                        // Llamar al método para eliminar el turno (reemplaza 'conn' con tu objeto de conexión)
                        conn.EliminarTurno(turnoId);

                        // Remove the row from the DataTable
                        Turnos.Rows.Remove(rowToDelete);

                        // Reassign the DataTable as the DataSource
                        grdTurnos.DataSource = Turnos;
                    }
                }
            }
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

        private void grdTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdTurnos.Columns["Detalles"].Index && e.RowIndex >= 0)
            {
                // Aquí puedes obtener el número de turno u otra información relevante
                int IdTurno = (int)grdTurnos.Rows[e.RowIndex].Cells["TurnoId"].Value;

                MessageBox.Show("Id de Turno: " + IdTurno.ToString());
            }
        }
    }
}
