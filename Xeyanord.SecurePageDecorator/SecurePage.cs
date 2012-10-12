using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xeyanord.SecurePageDecorator
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SecurePage : Attribute
    {
        public SecurePage()
        {
            //check to see if this library is used in a web app
            if (HttpContext.Current != null)
            {
                HttpRequest request = HttpContext.Current.Request;
                HttpResponse response = HttpContext.Current.Response;
                //check to see if we are at an http application
                if (request != null && response != null)
                {
                    if (!request.IsSecureConnection)
                    {
                        response.Redirect(request.Url.AbsoluteUri.Replace("http://", "https://"));
                    }
                }
            }
        }
    }
}