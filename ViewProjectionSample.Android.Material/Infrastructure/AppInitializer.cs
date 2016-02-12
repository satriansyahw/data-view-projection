using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.ViewBuilders;
using Intersoft.Crosslight.Android.Views;
using ViewProjectionSample.Infrastructure;
using Android.Content;
using Intersoft.Crosslight.Forms;

namespace ViewProjectionSample.Android.Infrastructure
{
	public class MySectionViewBuilder : SectionContainerBuilder
	{
		public override IContainerView Build (object viewHost, ComponentDefinitionBase definition)
		{
			return new MySectionView((Context)viewHost, (SectionDefinition)definition);
		}
	}

	public class MySectionView : SectionContainerView
	{
		public MySectionView(Context context, SectionDefinition section) 
			: base(context, section)
		{
		}
	}

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

