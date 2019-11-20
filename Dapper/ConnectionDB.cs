using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MS_TEST_EJ.Dapper
{
    public class ConnectionDB : IConnectionDB
    {
        private readonly ILogger<ConnectionDB> _logger;
        private readonly IConfiguration _configuration;

        public ConnectionDB(ILogger<ConnectionDB> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public IDbConnection ConexionABase()
        {
            try
            {
                IDbConnection db = new SqlConnection(_configuration["BASE_DE_DATOS_STT"]);
                return db;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ConexionBaseDeDatos(), ex:{ex.ToString()}");
                return null;
            }
        }
    }
}
