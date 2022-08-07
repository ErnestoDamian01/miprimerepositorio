namespace EjemploErnestoDamianBoiero
{
    class ProbarObjetos
    {
        static void Main(string[] args)
        {
            Producto productoPorDefecto = new Producto();
            Console.WriteLine(productoPorDefecto.Categoria);

            productoPorDefecto.Categoria = "Categoria de producto";

            Console.WriteLine(productoPorDefecto.Categoria);

        }
    }

    public class Producto
    {
        private int _codigo;
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        private string _descripcion;
        private string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }
        private string _categoria;
        public string Categoria
        {
            get
            {
                if(!String.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "SIN CATEGORIA";
                }
            }
            set
            {
                this._categoria = value;
            }
        }

        private double _precioDeCompra;
        private double _precioDeVenta;
    }
}
