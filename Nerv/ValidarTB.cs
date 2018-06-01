using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nerv
{
    public class ValidarTB
    {


        public static object VerificarCamposDeTextoCliente(string tel, string cla, string nom)
        {
            if (tel.Length == 10)
            {
                if (int.Parse(cla) >= 0)
                {
                    if (nom.Length > 50)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El nombre ingresado no es válido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La Clave del Cliente ingresada no es válida");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("El número de teléfono ingresado no es válido");
                return false;
            }
        }

        public static object VerificarCamposDeTextoCatalogoProducto(string cat, string cla, string nom)
        {
            if (cat.Length < 15)
            {
                if (int.Parse(cla) >= 0)
                {
                    if (nom.Length < 5)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El nombre ingresado no es válido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La Clave del Producto ingresada no es válida");
                    return false;

                }

            }
            else
            {
                MessageBox.Show("La Categoria ingresada no es válida");
                return false;
            }
        }
    }


}

