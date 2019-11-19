using Microsoft.Extensions.Logging;

namespace MS_TEST_EJ.Clases_Datos
{
    public class Datos: IDatos
    {
        //Constructor
        private readonly ILogger<Datos> _log;
        public Datos(ILogger<Datos> log)
        {
            _log = log;
        }
        //

    }
}
