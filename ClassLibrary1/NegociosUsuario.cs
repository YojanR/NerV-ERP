using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using ClassLibrary2;

namespace ClassLibrary1
{
    public class NegociosUsuario
    {
        DatosUsuario objDato = new DatosUsuario();

        public DataTable NListado()
        {
            return objDato.DLogin();
        }

        public int AgregarUsuarios(EntidadUsuario EL)
        {
            return objDato.AgregarUsuarios(EL);
        }
    }
}
