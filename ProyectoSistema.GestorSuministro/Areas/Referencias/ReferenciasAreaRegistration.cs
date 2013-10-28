using System.Web.Mvc;

namespace ProyectoSistema.GestorSuministro.Areas.Referencias
{
    public class ReferenciasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Referencias";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Referencias_default",
                "Referencias/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
