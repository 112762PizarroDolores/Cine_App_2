namespace Cine_App_2.Entidades
{
    public class TipoCliente
    {
        public int idTipoCliente;
        public string nombreTipoCliente;
        public decimal precio;


        public TipoCliente(int _idTipoCliente, string _nombreTipoCliente, decimal _precio)
        {
            idTipoCliente = _idTipoCliente;
            nombreTipoCliente = _nombreTipoCliente;
            precio = _precio;

        }

        public int _idTipoCliente { get; private set; }

        public string _nombreTipoCliente { get; private set; }

        public decimal _precio { get; private set; }


    }
}
