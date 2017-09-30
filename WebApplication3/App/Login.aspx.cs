using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String nomeUsuario = txtBoxUsuario.Text;
            {
                    
            }
            if (txtBoxUsuario.Text == "igor" && txtBoxSenha.Text == "senhaDoIgor")
            {

                Session.Add("administrador", nomeUsuario);
                Session["usuario"] = null;
                Response.Redirect("Menu.aspx");
            }else if (txtBoxUsuario.Text == "usuario" && txtBoxSenha.Text == "senha")
            {
                
                Session.Add("usuario", nomeUsuario);
                Session["administrador"] = null;
                Response.Redirect("Menu.aspx");
            }
            else
            {
                Label lbl = this.Page.FindControl("lblFalhaAutenticacao") as Label;
                lbl.Text = "Usuário e/ou senha inválido(s)";
            }
        }
    }
}