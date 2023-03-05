using Splat;

namespace W0_0W._202300226.DataAnalysis
{
	static class App
	{
		public static void Init()
		{
			var build = Locator.CurrentMutable;
			build.Register(() => new Config());
		}
	}
}