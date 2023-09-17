using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Peluquería
{
    public partial class NuevoServicio : Form
    {
        public NuevoServicio()
        {
            InitializeComponent();
        }
        static Conexión conn = new Conexión();
        private void NuevoServicio_Load(object sender, EventArgs e)
        {
            animacion(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
        }

        private void txtbxServicio_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtbxServicio_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }

        private void txtbxPrecio_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtbxPrecio_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            string message = "Se va a agregar el siguiente Servicio:\n\n" +
                 "Servicio: " + txtbxServicio.Text + "\n" +
                 "Precio: $ " + txtbxPrecio.Text;

            string title = "Confirmar Servicio";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                conn.AgregarServicio(txtbxServicio.Text, txtbxPrecio.Text);

                this.Close();
            }
            else
            {
                return;
            }
        }


        private void txtbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela la entrada de texto
                e.Handled = true;
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
