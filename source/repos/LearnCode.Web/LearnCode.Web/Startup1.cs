using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(LearnCode.Web.Startup1))]

namespace LearnCode.Web
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType= "AplicationCookie",
                //Rota (endereço URL)
                 LoginPath = new PathString("/Autenticacao/Login")
            });

            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
        //colocar a codificação que se encontra no roteiro de copetencia(.docx)
        }
    }
}
