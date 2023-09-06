using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Peluquería
{
    public partial class NuevoTurno : Form
    {
        public NuevoTurno()
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            Opacity = 0;
        }
        public bool SeAgregoTurno { get; private set; } = false;
        private Point dragStartPoint;
        private bool isDragging = false;

        Conexión conn = new Conexión();
        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            animacion(true);
            cargarServicios();
            cargarFecha();
        }
        public void cargarServicios()
        {
            DataTable servicios = conn.Servicios();

            // Limpia los elementos previos en el ComboBox
            cbxServicios.Items.Clear();

            // Agrega cada nombre de servicio al ComboBox
            foreach (DataRow fila in servicios.Rows)
            {
                cbxServicios.Items.Add(fila["Servicio"].ToString());
            }

            // Establece el índice seleccionado en 0 si hay elementos en el ComboBox
            if (cbxServicios.Items.Count > 0)
            {
                cbxServicios.SelectedIndex = 0;
            }
        }
        public void cargarFecha()
        {
            dtpFecha.Value = DateTime.Today;
            cbxHora.SelectedItem = "10";
            cbxMinuto.SelectedItem = "00" ;
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            int ClienteId = 0;
            string nombre = txtbxNombre.Text;
            string apellido = txtbxApellido.Text;
            string servicio = cbxServicios.SelectedItem.ToString();
            string hora = cbxHora.SelectedItem.ToString();
            string minuto = cbxMinuto.SelectedItem.ToString();
            string teléfono = txtbxTelefono.Text;
            string horaSeleccionada = hora + ":" + minuto + ":00";

            TimeSpan hs = TimeSpan.Parse(horaSeleccionada);

            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            string fecha = fechaSeleccionada.Day + "/" +  fechaSeleccionada.Month + "/" + fechaSeleccionada.Year;
            DateTime fechaYHora = fechaSeleccionada.Add(hs);

            string message = "Se va a agregar el siguiente Turno: \n\n" +
                             "Nombre: " + nombre + " " + apellido + "\n\n" +
                             "Fecha:  " + fecha + "\n\n" + 
                             "Horario: " + hora + ":" + minuto + " hs \n\n" +
                             "Servicio: " + servicio;

            string title = "Confirmar Turno";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (conn.ConsultaCliente(nombre, apellido, teléfono))
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    ClienteId = conn.ObtenerID(nombre, apellido);
                    conn.AgregarTurno(ClienteId, servicio, fechaYHora);
                    SeAgregoTurno = true;
                    this.Close();
                }
                else
                {
                    return;
                }

            }
            else
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        conn.AgregarTurno(nombre, apellido, servicio, teléfono, fechaYHora);
                        SeAgregoTurno = true;
                        this.Close();
                    }
                    else
                    {
                        return;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
        }

        private void txtbxNombre_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtbxNombre_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }

        private void txtbxApellido_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtbxApellido_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }

        private void txtbxTelefono_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde3, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtbxTelefono_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde3, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
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

        private void LinkClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListaClientes lista = new ListaClientes();
            lista.ShowDialog();
            txtbxNombre.Text = lista.seleccion.Nombre;
            txtbxApellido.Text = lista.seleccion.Apellido;
            txtbxTelefono.Text = lista.seleccion.Telefono;
        }
    }
}
