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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Conexión conn = new Conexión();
        private void Inicio_Load(object sender, EventArgs e)
        {
            animacion(true);
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            if (conn.ComprobarDatos(txtboxUsuario.Text, txtboxContraseña.Text))
            {
                this.Hide();
                string Nombre = conn.getNombre(txtboxUsuario.Text);
                MenuGestión Menu = new MenuGestión(Nombre);
                Menu.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void animacion(bool aparece)
        {
            if (aparece)
            {
                this.Show();
                Transition.run(this, "Opacity", 1.0, new TransitionType_Linear(300));
            }
            else
            {
                Transition transition = new Transition(new TransitionType_Linear(300));
                transition.TransitionCompletedEvent += (s, args) =>
                {
                    this.Hide();
                };
                transition.add(this, "Opacity", 0.0);
                transition.run();
            }
        }

        private void LinkInvitado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                animacion(false);
                MenuGestión Menu = new MenuGestión("INVITADO");
                Menu.ShowDialog();
                animacion(true);
        }

        private void txtboxUsuario_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtboxContraseña_Enter(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.SpringGreen, new TransitionType_Linear(300));
        }

        private void txtboxUsuario_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }

        private void txtboxContraseña_Leave(object sender, EventArgs e)
        {
            Transition.run(Borde2, "BackColor", Color.PaleTurquoise, new TransitionType_Linear(300));
        }
    }
}
