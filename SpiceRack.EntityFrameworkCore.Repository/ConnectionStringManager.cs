using System;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public class ConnectionStringManager
    {
        public string Get(string connectionStringName = "DatabaseContext")
        {
            try
            {
                return GetConnectionStringFromWebAppConfigFile(connectionStringName);
            }
            catch
            {
                return GetConnectionStringFromProjectJsonFile(connectionStringName);
            }
        }

        private string GetConnectionStringFromWebAppConfigFile(string connectionStringName = "DatabaseContext")
        {
            var connectionString = string.Empty;
                
            //ConfigurationManager.ConnectionStrings[$@"{connectionStringName}"].ConnectionString;

            return connectionString;
        }

        private string GetConnectionStringFromProjectJsonFile(string connectionStringName = "DatabaseContext")
        {
            var connectionString = ApplicationConfiguration.Configuration[$@"Data:{connectionStringName}"];

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception($@"Unable to find connection string for {connectionStringName}");
            }

            return connectionString;
        }
    }
}
