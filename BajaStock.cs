namespace patronCommand
{
    public class BajaStock : Orden
    {
        public BajaStock(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
