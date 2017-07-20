using System.Web.Http;
using Trie.Services;

namespace Trie
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register); 
        }
    }
}
