namespace patronCommand
{
    public abstract class Orden
    {
        public abstract void Ejecutar();

        protected ProductoReceiver _producto;
        protected double _cantidad;

        public Orden(ProductoReceiver producto, double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }
    }
}
