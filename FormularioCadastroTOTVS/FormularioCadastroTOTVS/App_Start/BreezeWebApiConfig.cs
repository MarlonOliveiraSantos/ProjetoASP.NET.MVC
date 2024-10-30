using System.Web;
using System.Web.Http;

namespace FormularioCadastroTOTVS.App_Start {
  public static class BreezeWebApiConfig {

    public static void RegisterBreezePreStart() {
      GlobalConfiguration.Configuration.Routes.MapHttpRoute(
          name: "BreezeApi",
          routeTemplate: "breeze/{controller}/{action}"
      );
    }
  }
}