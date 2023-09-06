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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
            InitializeDragEvents(pnlDrag);
            Opacity = 0;
        }
        private Point dragStartPoint;
        private bool isDragging = false;

        public Cliente seleccion = new Cliente();
        static Conexión conn = new Conexión();

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            animacion(true);
            gvClientes.DataSource = conn.ObtenerClientes();
            gvClientes.Columns["ClienteId"].Visible = false;
            gvClientes.Columns["Balance"].Visible = false;
        }


        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            seleccion.Nombre = gvClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
            seleccion.Apellido = gvClientes.SelectedRows[0].Cells["Apellido"].Value.ToString();
            seleccion.Telefono = gvClientes.SelectedRows[0].Cells["Teléfono"].Value.ToString();
            animacion(false);
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
    }
}
