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
    public partial class NuevoServicio : Form
    {
        public NuevoServicio()
        {
            InitializeComponent();
        }
        static Conexión conn = new Conexión();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
