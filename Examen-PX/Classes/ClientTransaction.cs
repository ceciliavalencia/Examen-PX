using Examen_PX.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Classes
{
    public class ClientTransaction : IClientTrans, IImpuestos, IRubro
    {
        public void delete(Client client)
        {
            throw new NotImplementedException();
        }

        public void insert(Client client)
        {
            throw new NotImplementedException();
        }
        public double AHORRO(Client client)
        {
            throw new NotImplementedException();
        }


        public double ISR(Client client)
        {
            double ISR = client.cantidad_donacion * 0.05;
            return ISR;
        }

        public double IVA(Client client)
        {
            throw new NotImplementedException();
        }
        #region calculo rubro
        public double calculorubro(Rubro rubro)
        {
            double cantidad = 0;
          

            if (rubro.idRubro == 1)
            {
                cantidad = 0.05;
              
            }
            else if (rubro.idRubro==2)
            {
                cantidad = 0.10;
                
            }
            else
            {
                cantidad = 0.85;
               
            }

            return cantidad;
        }
        #endregion
    }
}
