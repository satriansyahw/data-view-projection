using Intersoft.AppFramework;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Containers;
using Intersoft.Crosslight.Data.EntityModel;
using Intersoft.Crosslight.RestClient;
using Intersoft.Crosslight.Services;
using ViewProjectionSample.DomainModels;
using ViewProjectionSample.ViewModels;

namespace ViewProjectionSample.Infrastructure
{
    public sealed class ViewProjectionSampleAppService : ApplicationServiceBase
    {
        public ViewProjectionSampleAppService(IApplicationContext context)
            : base(context)
        {
			// configure app settings
			var appSettings = new AppSettings();
            // By default, this sample points to a WebAPI host in Intersoft's server for convenient 
            // sample experience. If you want to point this URL to your local development server,
            //  you should deploy and run the .WebApi project locally and replace the URL here.
            // For more information, check out the documentation: 
            // http://developer.intersoftsolutions.com/display/crosslight/Walkthrough%3A+Configuring+WebAPI-enabled+Crosslight+Samples
            appSettings.WebServerUrl = "http://staging1.intersoftsolutions.com/ViewProjection";
			appSettings.BaseAppUrl = appSettings.WebServerUrl + "";
			appSettings.BaseImageUrl = appSettings.BaseAppUrl + "/images/";
			appSettings.RestServiceUrl = appSettings.BaseAppUrl + "/data/AdventureWorks";
			appSettings.RequiresInternetConnection = true;
            
			// shared services registration
			this.GetService<ITypeResolverService>().Register(System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(SalesOrderHeader)).Assembly);

            // components specific registration
            this.GetService<IActivatorService>().Register<IRestClient>(
                (c) => 
                {
					var restClient = new RestClient(appSettings.RestServiceUrl);
                    restClient.TypeResolver = new EntityTypeResolver();
					restClient.AuthenticationUrl = appSettings.AuthenticationUrl;
                    return restClient;
                });

            // application-specific containers registration
			// such as data repositories
			Container.Current.RegisterInstance<AppSettings>(appSettings);
			Container.Current.Register<IEntityContainer>("Default", (c) => new EntityContainer()).WithLifetimeManager(new ContainerLifetime());
            Container.Current.Register<ISalesOrderHeaderRepository>((c) => new SalesOrderHeaderRepository(c.Resolve<IEntityContainer>("Default"))).WithLifetimeManager(new ContainerLifetime());
            Container.Current.Register<ICustomerRepository>((c) => new CustomerRepository(c.Resolve<IEntityContainer>("Default"))).WithLifetimeManager(new ContainerLifetime());
            
			// add new services (extensions)
			ServiceProvider.AddService<IResourceLoaderService, ResourceLoaderService>();
			ServiceProvider.AddService<IResourceCacheService, ResourceCacheService>();
			ServiceProvider.AddService<IImageLoaderService, ImageLoaderService>();
        }

		protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);

            this.SetRootViewModel<SalesOrderHeaderMultiPageViewModel>();
        }
    }
}
