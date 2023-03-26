using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomAttributes
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        /*protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            // redirect to your Error page
            context.Result = new RedirectResult("/UnauthorizedRequest.html");
            // if you want to redirect to some action, use: 
            //   new RedirectResult("/UnAuthorizedUsers/ErrorDetails");

        }*/
    }
}
