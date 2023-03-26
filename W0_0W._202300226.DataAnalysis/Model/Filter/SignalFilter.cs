using System.Collections.Generic;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

/// <summary>
/// 抽象信号量滤波器
/// </summary>
abstract class SignalFilter
{
	public abstract IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data);
}