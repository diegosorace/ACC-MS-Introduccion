using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MS_TEST_EJ.Dapper
{
    public interface IConnectionDB
    {
        IDbConnection ConexionABase();
    }
}
