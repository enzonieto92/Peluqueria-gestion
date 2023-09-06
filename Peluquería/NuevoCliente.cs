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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            Opacity = 0;
        }

        private Point dragStartPoint;
        private bool isDragging = false;

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            animacion(true);
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
    }
}
