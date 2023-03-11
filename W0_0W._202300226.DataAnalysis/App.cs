using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis
{
	static class App
	{
		public static void Init()
		{
			var build = Locator.CurrentMutable;
			build.Register(() => new Config());
			build.Register(() => new SignalFactory(Locator.Current.GetService<Config>()));
		}
	}
}