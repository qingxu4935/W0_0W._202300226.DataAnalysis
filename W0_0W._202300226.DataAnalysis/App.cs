using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis;

static class App
{
	/// <summary>
	/// Service locator Pattern, 注册业务类
	/// </summary>
	public static void Init()
	{
		SplatRegistrations.Register<Config>();
		SplatRegistrations.Register<SignalFactory>();
		SplatRegistrations.SetupIOC();
	}
}