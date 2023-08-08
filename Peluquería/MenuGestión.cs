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
    public partial class MenuGestión : Form
    {
        public MenuGestión(string User)
        {
            InitializeComponent();
            lblUser.Text = User;
            Opacity = 0;
        }

        Conexión conn = new Conexión();

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

        private void MenuGestión_Load(object sender, EventArgs e)
        {
            grdTurnos.DataSource = conn.TurnosHoy();
            gvServicios.DataSource = conn.Servicios();
            posInicial();
            animacion(true);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            moverMenus("Clientes");
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            moverMenus("Turnos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoTurno nuevoTurno = new NuevoTurno();
            nuevoTurno.ShowDialog();
            grdTurnos.DataSource = conn.TurnosHoy();

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
            panelClientes.Location = new Point( 3000, 211);
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

        private void btnVerTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {

        }
    }

}
