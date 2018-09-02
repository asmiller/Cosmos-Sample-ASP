using System;
using System.Web;
using System.Web.UI;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;


namespace CosmosWebForms
{
    class OAuthResponse
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }

    class CosmosUser
    {
        public string first { get; set; }
        public string last { get; set; }
        public string email { get; set; }
    }

    public partial class oauth : System.Web.UI.Page
    {
        private static string URL = "https://heinemann.cosmos.school";
        private static string CLIENT_ID = "CLIENT_ID";
        private static string CLIENT_SECRET = "CLIENT_SECRET";

        public string LoginMessage { get; private set; }

        private string getTokenFromCode(string code){

            const string contentType = "application/x-www-form-urlencoded";
            string redirect = "http://localhost:8080/oauth.aspx";
            string fmt = "grant_type=authorization_code&code={0}&redirect_uri={1}&client_id={2}&client_secret={3}";

            string postString = string.Format(fmt, code, redirect, CLIENT_ID, CLIENT_SECRET);
            HttpWebRequest webRequest = WebRequest.Create(URL+"/v1/oauth2/token") as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.ContentType = contentType;
            webRequest.ContentLength = postString.Length;

            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();

            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            string responseData = responseReader.ReadToEnd();

            responseReader.Close();
            webRequest.GetResponse().Close();

            OAuthResponse token = new JavaScriptSerializer().Deserialize<OAuthResponse>(responseData);
            return token.access_token;
        }

        private CosmosUser getUserFromToken(string token){

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL+"/v1/users/me");
            request.Headers.Add("Authorization", "Bearer " + token);
            StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream());
            string responseData = responseReader.ReadToEnd();
            CosmosUser user = new JavaScriptSerializer().Deserialize<CosmosUser>(responseData);

            return user;
        }

        public void Page_Load()
        {
            if (string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                //Error - 
                return;
            }

            string code = Request.QueryString["code"];

            string token = this.getTokenFromCode(code);
            CosmosUser user = this.getUserFromToken(token);

            bool userExists = false;

            //Check if user.email exists in your system. If so, log them in and
            //set session variables
            if (userExists){
                LoginMessage = "login";
            }

            Session["first"] = user.first;
            Session["last"] = user.last;
            Session["email"] = user.email;

            LoginMessage = "register";
        }
    }
}
