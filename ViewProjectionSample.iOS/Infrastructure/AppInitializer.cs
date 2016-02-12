using System;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ViewProjectionSample.Infrastructure;

namespace ViewProjectionSample.iOS.Infrastructure
{
	public sealed class AppInitializer : IApplicationInitializer
	{
		public IApplicationService GetApplicationService(IApplicationContext context)
		{
            return new ViewProjectionSampleAppService(context);
		}
		
		public void InitializeApplication(IApplicationHost appHost)
		{
		}
		
		public void InitializeComponents(IApplicationHost appHost)
		{
		}
		
		public void InitializeServices(IApplicationHost appHost)
		{
		}
	}
}


