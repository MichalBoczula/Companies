using Companies.Application.Contracts;
using Companies.Domain.Entities;
using Companies.Persistance.Contexts.Abstract;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Contexts.Concrete
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _configuration;
        
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_configuration.GetConnectionString("SqlConnection"));
        public IDbConnection CreateMasterConnection()
            => new SqlConnection(_configuration.GetConnectionString("MasterConnection"));

        
    }
}
