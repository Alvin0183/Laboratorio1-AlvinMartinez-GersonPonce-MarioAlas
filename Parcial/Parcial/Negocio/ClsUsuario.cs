using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Negocio
{
    public class ClsUsuario
    {
        public bool Acces(Usuario us)
        {

            if (us.Nombre == "Alvin" && us.Contra == 123)
            {
                return true;

            }
            else
            {

                return false;
            }
        }
    }
}
