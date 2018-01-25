using Microsoft.Extensions.Configuration;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public static class ApplicationConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }
    }
}
