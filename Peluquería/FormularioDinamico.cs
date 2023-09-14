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
    public partial class FormularioDinamico : Form
    {
        
        public FormularioDinamico()
        {
            InitializeComponent();
        }
        private void FormularioDinamico_Load(object sender, EventArgs e)
        {
            animacion(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            animacion(false);
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
