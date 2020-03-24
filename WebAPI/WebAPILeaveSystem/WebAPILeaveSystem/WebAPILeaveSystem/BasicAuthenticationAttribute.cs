using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Text;
using System.Threading;
using System.Security.Principal;

namespace WebAPILeaveSystem
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //if authorization header is missing
           if(actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                
                //decode authentication token
                string decodedAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));

                //split by column and get user name and password
                string[] usernamePasswordArray = decodedAuthToken.Split(':');
                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];

                //validate if received user name and password are in DB
                if (EmployeeSecurity.Login(username, password))
                {
                    //set current principle
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username),null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                }

            }
        }
    }
}