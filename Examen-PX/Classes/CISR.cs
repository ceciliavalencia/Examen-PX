using Examen_PX.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Classes
{
    public class CISR : IISR
    {
        public double ISR(Client client)
        {
            double ISR = client.cantidad_donacion * 0.05;
          // ISR = client.cantidad_donacion -ISR;
            return ISR;
        }
    }
}
