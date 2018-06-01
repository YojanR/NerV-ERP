using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using ClassLibrary2;
using System.Data;

namespace ClassLibrary1
{
    public class NegociosCliente
    {
        DatosCliente objDato = new DatosCliente();
        
        public int AgregarUsuarios(EntidadCliente EC)
        {
            return objDato.AgregarCliente(EC);
        }
    }
}
