namespace patronCommand
{
    public class AltaStock : Orden
    {
        public AltaStock(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.SumarStock(_cantidad);
        }
    }
}