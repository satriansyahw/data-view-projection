using Intersoft.Crosslight.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Intersoft.Crosslight.Data;
using Intersoft.Data.WebApi;

namespace ViewProjectionSample.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IocContainer.Current.Register<IAppDomainInfo, AppDomainInfo>();
            EntityServerConfig.Initialize();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public class AppDomainInfo : IAppDomainInfo
        {
            public ApplicationType ApplicationType
            {
                get { return ApplicationType.Server; }
            }

            public ProviderType ProviderType
            {
                get { return ProviderType.IntersoftWebApi; }
            }
        }
    }
}
