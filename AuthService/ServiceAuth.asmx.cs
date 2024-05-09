using System;
using System.Web.Services;

namespace AuthService
{
    /// <summary>
    /// Summary description for AuthService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthService : System.Web.Services.WebService
    {

        //Creating an instance of other classes to call methods
        AuthenticationCode authenticationVar = new AuthenticationCode();

        //All available Services within this component
        [WebMethod]
        public int AuthenticateUserByPassword(String email, String password)
        {
            int output = authenticationVar.AuthenticateUserByPassword(email, password);
            return output;
        }

        [WebMethod]
        public int AuthenticateUserByPin(int customerID, String pin)
        {
            int output = authenticationVar.AuthenticateUserByPin(customerID, pin);
            return output;
        }
    }
}
