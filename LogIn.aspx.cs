using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Logout
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Controlla se il cookie di login esiste
                if (Request.Cookies["username"] != null)
                {
                    // Se il cookie esiste, reindirizza alla pagina successiva
                    Response.Redirect("welcome.aspx");
                }
            }
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Memorizza la username nel cookie solo se la checkbox è selezionata
                if (chkRememberMe.Checked)
                {
                    Response.Cookies["username"].Value = txtUsername.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(1); // Imposta la scadenza del cookie a 1 giorno
                }

                // Reindirizza alla pagina di benvenuto
                Response.Redirect("welcome.aspx");
            }
        }          
    }
}