using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Logout
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Controlla se il cookie di login esiste
            if (Request.Cookies["username"] == null)
            {
                // Se il cookie non esiste, reindirizza alla pagina di login
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                // Mostra la username nella label
                lblUsername.Text = "Logged in as: " + Request.Cookies["username"].Value;
            }

        }
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            // Cancella il cookie di login
            Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);

            // Reindirizza alla pagina di login
            Response.Redirect("LogIn.aspx");
        }
    }
}