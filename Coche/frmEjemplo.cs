using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// namespace igual que el resto de las clase
/// </summary>
namespace Coche
{
    public partial class frmEjemplo : Form
    {

        Coche oCoche;
        public frmEjemplo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// crea un coche y lo configura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttCrear_Click(object sender, EventArgs e)
        {
            oCoche = new Coche();
            oCoche.Velocidad = Decimal.ToInt32( udVelocidad.Value);
            oCoche.MarcaCoche = txtMarca.Text;

            MessageBox.Show("Coche creado");

            //cambia la apariencia
            gbAlerta.Enabled = true;
            gbCoche.Enabled = false;


        }


        /// <summary>
        /// consulta al coche la velcidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttComprueba_Click(object sender, EventArgs e)
        {
            
                  
            if (oCoche.Velocidad>nUDLimite.Value)
            {
                oCoche.ReduceVelocidad(nUDLimite.Value);
                MessageBox.Show("Vas muy rápido, toca frenar");
                udVelocidad.Value = oCoche.Velocidad;
            }
            else
            {
                MessageBox.Show("Muy bien estas respetando el límite de velocidad");
            }
        }

        /// <summary>
        /// se ejecuta cuando carga el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEjemplo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación pretende mostrar como trabajar con clases con un formulario. La idea es que veais cómo se definen,crean y modifican objetos desde un formulario. ");
        }
    }
}
