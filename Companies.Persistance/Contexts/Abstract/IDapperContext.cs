using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Contexts.Abstract
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
        IDbConnection CreateMasterConnection();
    }
}
