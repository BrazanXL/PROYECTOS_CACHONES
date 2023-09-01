using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Software
{
    public static class logger
    {
        public static void RegistrarError(String message) 
        {
            String LogPath = ConfigurationManager.AppSettings["LogPath"];
            using (StreamWriter writer = new StreamWriter(LogPath,true)) 
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
                //esto se coloca para llamar esta clase ¬
                //¬¬¬(logger.RegistrarError("Se Capturo el sigiente error: " + error);)
            }
        }
    }
}
