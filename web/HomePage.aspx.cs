using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureSQLWebApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("SignUp.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Function.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}