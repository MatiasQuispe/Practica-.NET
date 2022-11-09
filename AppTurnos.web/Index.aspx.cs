using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppTurnos.web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["session_usuario"] != null) {
                string usuario = Session["session_usuario"].ToString();
                lblBienvenida.Text = "Bienvenido/a " + usuario;
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("session_usuario");
            Response.Redirect("login.aspx");
        }
    }
}