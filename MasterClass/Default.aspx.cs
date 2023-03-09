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
            
            try
            {
                bandas = negocio.cargarDatos("Gonzalo");
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx", false);
                //throw ex;
            }
            
            if(!(bandas.banda is null))
                lblBanda.Text = bandas.banda;
            if(!(bandas.coder is null))
                lblCoder.Text = bandas.coder;
        }
    }
}