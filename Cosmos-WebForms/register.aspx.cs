using System;
using System.Web;
using System.Web.UI;

namespace CosmosWebForms
{

    public partial class register : System.Web.UI.Page
    {
        public void Page_Load()
        {
            First.Text = Session["First"] as String;
            Last.Text = Session["Last"] as String;
            Email.Text = Session["Email"] as String; ;
        }
    }
}
