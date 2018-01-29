using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public static class ConfigurationManager
    {
        private static Dictionary<string, string> ConnectionStrings = new Dictionary<string, string>();

        public static string GetConnectionString(string name)
        {
            if (ConnectionStrings.Count < 1)
            {
                ReadConnectionStrings();
            }

            return ConnectionStrings[name];
        }

        private static void ReadConnectionStrings()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var directory = Path.GetDirectoryName(path);

            var files = Directory.GetFiles(directory, "*.config");

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(files[0]);

            var connectionStringNodes = xmlDocument.DocumentElement.SelectNodes("connectionStrings");

            var connectionStrings = connectionStringNodes[0].ChildNodes;

            foreach (XmlNode connectionString in connectionStrings)
            {
                ConnectionStrings.Add
                    (
                        connectionString.Attributes["name"].InnerText, 
                        connectionString.Attributes["connectionString"].InnerText
                    );
            }
        }
    }
}
