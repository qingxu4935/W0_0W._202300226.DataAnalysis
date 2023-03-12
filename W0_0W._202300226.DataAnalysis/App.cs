using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis
{
	static class App
	{
		public static void Init()
		{
			SplatRegistrations.Register<Config>();
			SplatRegistrations.Register<SignalFactory>();
			SplatRegistrations.SetupIOC();
		}
	}
}