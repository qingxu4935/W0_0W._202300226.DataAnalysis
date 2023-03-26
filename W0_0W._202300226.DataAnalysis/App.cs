using Splat;
using W0_0W._202300226.DataAnalysis.Model;
using W0_0W._202300226.DataAnalysis.Model.Filter;

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
		//注册限幅滤波法
		Locator.CurrentMutable.Register<SignalFilter>(() => new LimitingSignalFilter(128), nameof(LimitingSignalFilter));
		//注册中位值滤波法
		Locator.CurrentMutable.Register<SignalFilter>(() => new MedianSignalFilter(3), nameof(MedianSignalFilter));
		//注册算术平均滤波法
		Locator.CurrentMutable.Register<SignalFilter>(() => new AverageSignalFilter(2), nameof(AverageSignalFilter));
		SplatRegistrations.SetupIOC();
	}
}