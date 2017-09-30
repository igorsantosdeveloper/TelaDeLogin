using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class SegundaTela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["administrador"] == null && Session["usuario"] == null)
            {
                
                Response.Redirect("Login.aspx");
            }else if (Session["administrador"] != null)
            {

                Label lbl = this.Page.FindControl("lblMensagem") as Label;
                lbl.Text += " " + Session["administrador"].ToString() + " você é um administrador";
            }
            else
            {
                
                Label lbl = this.Page.FindControl("lblMensagem") as Label;
                lbl.Text += " " + Session["usuario"].ToString();
            }
        }
    }
}