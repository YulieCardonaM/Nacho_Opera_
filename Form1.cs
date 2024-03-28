using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multiplicacion;

namespace Nacho_Opera
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            lblRespuestas.Visible = true;
            lblSuma.Visible = true;
            lblResta.Visible = true;
            lblMultiplicacion.Visible = true;
            lblDivision.Visible = true;

            //Crear instancia de la clase Multiplicacion
            Multiplicacion.Class1 multiplicacion = new Multiplicacion.Class1();

            if (int.TryParse(txtNumero1.Text, out int Numero1) && int.TryParse(txtNumero2.Text, out int Numero2))
            {
                // Llamar al método RealizarMultiplicacion 
                int resultado = multiplicacion.RealizarMultiplicacion(Numero1, Numero2);

                // Mostrar resultado
                lblRespuestaMulti.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
