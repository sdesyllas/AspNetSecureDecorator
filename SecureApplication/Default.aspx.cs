using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Xeyanord.SecurePageDecorator;

namespace SecureApplication
{
    //we decorate our page class with SecurePage attribute in order to make sure that this page is loaded through https
    [SecurePage]
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}