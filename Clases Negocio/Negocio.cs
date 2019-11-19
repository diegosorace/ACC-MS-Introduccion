using Microsoft.Extensions.Logging;
using MS_TEST_EJ.Clases_Datos;

namespace MS_TEST_EJ.Clases_Negocio
{
    public class Negocio : INegocio
    {
        //Constructor
        private readonly IDatos _datos;
        private readonly ILogger<Negocio> _log;
        public Negocio(IDatos datos, ILogger<Negocio> log)
        {
            _datos = datos;
            _log = log;
        }
        //

    }
}
