using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.RELATORIOS
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string pasta = @"c:\RelADS";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }
    }
}
