using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoBD;

namespace Negocio
{
    public class BandasElegidasNegocio
    {
        public BandasElegidas cargarDatos(string coder)
        {
            AccesoDatos datos = new AccesoDatos();
            BandasElegidas bandas = new BandasElegidas();

            try
            {
                //datos.setearConsulta("select bd.Banda, bd.Coder from bandasMusicales bd where bd.Coder = '" + coder);
                datos.setearConsulta("select bd.Banda, bd.Coder from bandasMusicales bd where bd.Coder = '" + coder + "'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    bandas.banda = (string)datos.Lector["Banda"];
                    bandas.coder = (string)datos.Lector["Coder"];
                }

                return bandas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
