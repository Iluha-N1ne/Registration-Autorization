
using System.Configuration;

namespace RegistrationMark2
{
    internal class Connection
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["RegistrationMark2.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            }
        }
    }
    //DatabaseConnectionString
}
