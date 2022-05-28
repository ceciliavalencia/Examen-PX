using Examen_PX.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Classes
{
    public class CIVA : IIVA
    {
        double IIVA.IVA(Client client)
        {
            double iva = client.cantidad_donacion * 0.12;
            return iva;

            //throw new NotImplementedException();
        }
    }
}
