using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Peluquería
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            Opacity = 0;
        }

        Conexión conn = new Conexión();
        private Point dragStartPoint;
        private bool isDragging = false;

        private void NuevoCliente_Load(object sender, EventArgs e) 
        {
            animacion(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e) => animacion(false);

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

        private void txtbxNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtbxNombre.Text;
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                Transition.run(Borde, "BackColor", Color.Red, new TransitionType_Linear(300));
                epNombre.Icon = Properties.Resources.attention;
                epNombre.SetError(txtbxNombre, "Nombre Inválido!");
                e.Cancel = true;
            }
            else
            {
                Transition.run(Borde, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
                epNombre.Clear();
                e.Cancel = false;
            }
        }

        private void txtbxApellido_Validating(object sender, CancelEventArgs e)
        {
            string apellido = txtbxApellido.Text;
            if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                Transition.run(Borde2, "BackColor", Color.Red, new TransitionType_Linear(300));
                epApellido.Icon = Properties.Resources.attention; // Usa epApellido
                epApellido.SetError(txtbxApellido, "Apellido Inválido!"); // Usa epApellido
                e.Cancel = true;
            }
            else
            {
                Transition.run(Borde2, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
                epApellido.Clear(); // Usa epApellido
                e.Cancel = false;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Realizar una validación global antes de continuar
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de confirmar");
                return;
            }

            string nombre = txtbxNombre.Text;
            string apellido = txtbxApellido.Text;
            string teléfono = txtbxTelefono.Text;

            string message = "Se va a agregar el siguiente Cliente: \n\n" +
                         "Nombre: " + nombre + " " + apellido + "\n\n" +
                         "Teléfono: " + teléfono;

            string message2 = "Ese Usuario ya existe!";

            string title = "Confirmar Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (conn.ConsultaCliente(nombre, apellido, teléfono))
            {
                DialogResult result = MessageBox.Show(message2, title);
                if (result == DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    conn.AgregarCliente(nombre, apellido, teléfono);
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


    }
}
