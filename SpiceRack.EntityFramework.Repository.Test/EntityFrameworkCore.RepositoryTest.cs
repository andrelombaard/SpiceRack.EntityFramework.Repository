﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpiceRack.EntityFrameworkCore.Repository;

namespace SpiceRack.EntityFramework.Repository.Test
{
    [TestClass]
    public class EntityFrameworkCoreRepositoryTest
    {
        [TestMethod]
        public void Test()
        {
            var connectionString = ConfigurationManager.GetConnectionString("MasterDatabaseContext");

            connectionString = ConfigurationManager.GetConnectionString("DatabaseContext");
        }
    }
}
