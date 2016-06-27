using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MvcSiteMapProvider;
using SiteMapSpike.DI.Unity.ContainerExtensions;
using MvcSiteMapProvider.Loader;
using MvcSiteMapProvider.Xml;
using System.Web.Hosting;

namespace SiteMapSpike
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = new UnityContainer();
            container.AddNewExtension<MvcSiteMapProviderContainerExtension>();
            SiteMaps.Loader = container.Resolve<ISiteMapLoader>();
            var validator = container.Resolve<ISiteMapXmlValidator>();
            validator.ValidateXml(HostingEnvironment.MapPath("~/Mvc.sitemap"));
          
        }
    }
}
