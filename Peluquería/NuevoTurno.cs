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
            Opacity = 0;
        }
        Conexión conn = new Conexión();
        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            animacion(true);
            cargarServicios();
            establecerHora();
        }
        public void cargarServicios()
        {
            List<string> servicios = conn.ObtenerServicios();
            cbxServicios.Items.AddRange(servicios.ToArray());
        }
        public void establecerHora()
        {
            cbxHora.SelectedItem = "10";
            cbxMinuto.SelectedItem = "00" ;
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            string nombre = txtbxNombre.Text;
            string apellido = txtbxApellido.Text;
            string servicio = cbxServicios.SelectedItem.ToString();
            string hora = cbxHora.SelectedItem.ToString();
            string minuto = cbxMinuto.SelectedItem.ToString();
            string teléfono = txtbxTelefono.Text;
            string horaSeleccionada = hora + ":"  + minuto + ":00";  

            TimeSpan hs = TimeSpan.Parse(horaSeleccionada);

            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            DateTime fechaYHora = fechaSeleccionada.Add(hs);

            string message = "Se va a agregar el siguiente Turno: \n\n" +
                             "Nombre: " + nombre + " " + apellido + "\n\n" +
                             "el día " + fechaYHora.ToString() + " hs \n\n" +
                             "Servicio: " + servicio;

            string title = "Confirmación";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                conn.AgregarTurno(nombre, apellido, servicio, teléfono, fechaYHora);
                this.Close();
            }
            else
            {
                return;
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
    }
}
