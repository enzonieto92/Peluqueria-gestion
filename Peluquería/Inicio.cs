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

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            txtboxUsuario.Focus();
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            txtboxContraseña.Focus();
        }

        private void txtboxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Inicio_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void lvlInvitado_Click(object sender, EventArgs e)
        {

            animacion(false);
            MenuGestión Menu = new MenuGestión("INVITADO");
            Menu.ShowDialog();
            animacion(true);
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
    }
}
