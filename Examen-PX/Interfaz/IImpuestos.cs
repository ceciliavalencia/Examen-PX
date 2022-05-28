using Examen_PX.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Interfaz
{
    public interface IImpuestos: IAhorro, IISR, IIVA
    {

    }
    public interface IIVA
    {
        double IVA(Client client);
    }

    public interface IISR
    {
        double ISR(Client client);
    }

    public interface IAhorro
    {
        double AHORRO(Client client);
    }
}
