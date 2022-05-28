using Examen_PX.Classes;
using System;

namespace Examen_PX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            # region cliente
            var cliente = new Client()
            {
                idCliente = 1,
                nombre = "Ana",
                apellido = "Valencia",
                nit= "123456-0",
                pais= "GT",
                idRubro=1,
                cantidad_donacion=10000

            };
#endregion

            var r1 = new Rubro()
               {
                    idRubro = 1,
                    nombre = "Gastos",
                    porcentaje = 0.05
               };
            #region adicionRubros
            //var r2 = new Rubro()
            // {
            //     idRubro = 2,
            //     nombre = "Publicidad",
            //     porcentaje = 0.10
            // };
            //var r3 = new Rubro()
            // {
            //     idRubro = 2,
            //     nombre = "Caja chica",
            //     porcentaje = 0.85
            // };

            //Rubro[] rubro = { r1, r2, r3 };
            #endregion

            CAhorro ah = new CAhorro(); 
            CISR isr = new CISR(); 
            CIVA iva = new CIVA();
            ClientTransaction rub = new ClientTransaction();
            double ahorro = ah.AHORRO(cliente);
            double isr_C = isr.ISR(cliente);
            double iva_c = iva.IVA(cliente);
            double rubros = rub.calculorubro(r1);
            double totalg = (cliente.cantidad_donacion - iva_c - isr_C - ahorro);
           
            Console.WriteLine("Bienvenid@ " + cliente.nombre +" "+cliente.apellido+ "A continuación, encontrará el desfloce de su información");
            Console.WriteLine("NIT: " + cliente.nit);
            Console.WriteLine("Su donacion es de: Q. " + cliente.cantidad_donacion);
            Console.WriteLine("IVA:  Q." + iva_c);
            Console.WriteLine("ISR:  Q." + isr_C);
            Console.WriteLine("AHORRO: Q. " + ahorro);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("A continuación, encontrará el desfloce de su donacion");
            Console.WriteLine("RUBRO:  " + r1.nombre);
            Console.WriteLine("PORCENTAJE:  " + rubros);
            Console.WriteLine("TOTAL DE ACUERDO A DONACION GASTOS:  Q. " + rubros * totalg);
       //     Console.WriteLine("TOTAL GENERAL:  " + totalg);
            Console.ReadKey();

        }

        
        
    }
}
