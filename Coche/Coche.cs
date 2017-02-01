using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// el namespace del proyecto
/// </summary>
namespace Coche
{

    /// <summary>
    /// simula un coche
    /// </summary>
    class Coche
    {

        private string marcaCoche;

        /// <summary>
        /// Una propiedad con poca utilidad
        /// </summary>
        public string MarcaCoche
        {
            get { return marcaCoche; }
            set { marcaCoche = value; }
        }

        private int velocidad;

        /// <summary>
        /// permite acceder a la velocidad del coche. 
        /// </summary>
        /// <remarks>No hay ningun tipo de validación por lo que puede ser negativa</remarks>
        public int Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        /// <summary>
        /// crea un coche sin marca y con velocidad 0
        /// </summary>
        public Coche()
        {
            velocidad = 0;
        }


        /// <summary>
        /// reduce la velocidad a la permitida
        /// </summary>
        /// <param name="velocidadPermitida"></param>
        public void ReduceVelocidad(decimal velocidadPermitida)
        {

            velocidad = decimal.ToInt32(velocidadPermitida);
                       
            
        }
    }
}
