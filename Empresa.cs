using System.Collections.Generic;
namespace patronCommand
{
    public class Empresa
    {
        private List<Orden> ordenes = new List<Orden>();

        public void TomarOrden(Orden cmd)
        {
            ordenes.Add(cmd);
        }

        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
                orden.Ejecutar();
            ordenes.Clear();
        }
    }
}