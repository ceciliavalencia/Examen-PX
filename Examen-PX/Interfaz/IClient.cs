using Examen_PX.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PX.Interfaz
{
   public interface IClient
   {
       
   }
    public interface IRubro
    {
        double calculorubro(Rubro rubro);
    }
    public interface InsertCliente
    {
        void insert(Client client);
    }
    public interface DeleteCliente
    {
        void delete(Client client);
    }

    interface IClientTrans : InsertCliente, DeleteCliente
    {

    }
    


}
