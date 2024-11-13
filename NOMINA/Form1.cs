using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMINA
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

       

        //Button
        private void IngresarNuevaNomina(object sender, EventArgs e)
        {
            if(tipoNominaForm == null)
            {
                tipoNominaForm = new TipoDeNominasForm();
            }
        }
    }
}
