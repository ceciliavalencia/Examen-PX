using Examen_PX.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Classes
{
    public class CAhorro : IAhorro
    {
        public double AHORRO(Client client)
        {
            double ahorro = client.cantidad_donacion * 0.05;
            return ahorro;
        }
    }
}
