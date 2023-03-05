using Splat;

namespace W0_0W._202300226.DataAnalysis
{
	static class Globals
	{
		public static void Init()
		{
			var build = Locator.CurrentMutable;
			build.RegisterLazySingleton(() => new Config());
		}
	}
}