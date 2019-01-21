using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Farmacia
{
    public class SeguridadBL
    {
        public bool tipoAdmin(string usuario, string contrasenia)
        {
            if (usuario == "Cajero")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Autorizar(string usuario, string contrasenia)
        {

            if (usuario == "Cajero" && contrasenia == "123")
            {
                return true;
                

            }
            else
            {
                if (usuario == "Usuario" && contrasenia == "456")
                {
                    return true;
                }

            }
            return false;
        }
    }
}
