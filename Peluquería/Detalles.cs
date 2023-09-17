using System;
using System.Data;
using System.Windows.Forms;
namespace Peluquería
{
    public partial class Detalles : Form
    {
        static Conexión conn = new Conexión();
        DataTable detalles = conn.Detalles();
        public Detalles(DataRow filaSeleccionada)
        {
            InitializeComponent();
            string Servicio = filaSeleccionada["Servicio"].ToString();
            string Cliente = filaSeleccionada["Cliente"].ToString();
            string Fecha = filaSeleccionada["Fecha"].ToString();
            string Horario = filaSeleccionada["Horario"].ToString();
            lblDetalles.Text =
                "TURNO" + "\n\n" +
                "Cliente: " + Cliente + "\n\n" +
                "Fecha: " + Fecha + "\n\n" +
                "Horario: " + Horario + "\n\n" +
                "Servicio: " + Servicio;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {


        }
    }
}
