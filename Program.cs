using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//crear un programa donde una empresa pueda procesar (sumar/restar) ordenes de productos 
// y que pueda mostrar cual es la cantidad desponible de los productos.
namespace patronCommand
{
    class program
    {
        static void Main(string[] args)
        {
            var empresa = new Empresa();
            var producto = new ProductoReceiver();
            producto.Cantidad = 75;


            var ordenAlta = new AltaStock(producto, 25);
            empresa.TomarOrden(ordenAlta);
            var ordenbaja = new BajaStock(producto, 60);
            empresa.TomarOrden(ordenbaja);

   

            empresa.ProcesarOrdenes();
            Console.Write(string.Format("Total stock es de {0} Unidades ", producto.Cantidad));
        }
    }
}
