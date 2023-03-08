using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace MasterClass
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BandasElegidasNegocio negocio = new BandasElegidasNegocio();
            BandasElegidas bandas = new BandasElegidas();
            //bandas.banda = "Patricio Rey y sus Redonditos de Ricota";
            //bandas.coder = "Gonzalo";

            bandas = negocio.cargarDatos();

            lblBanda.Text = bandas.banda;
            lblCoder.Text = bandas.coder;
        }
    }
}