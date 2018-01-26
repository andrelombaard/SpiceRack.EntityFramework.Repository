using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public static class ConfigurationManager
    {
        public static void Read()
        {
            var file = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //var doc = XDocument.Load();
        }
    }
}
