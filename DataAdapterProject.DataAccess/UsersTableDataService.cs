using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterProject.DataAccess
{
    public class UsersTableDataService
    {
        private readonly string _connectionString;
        private readonly string _providerName;
        private DbProviderFactory _providerFactory;

        public UsersTableDataService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _providerName = ConfigurationManager.ConnectionStrings["DefaultConnection"].ProviderName;
            _providerFactory = DbProviderFactories.GetFactory(_providerName);
        }
    }
}
