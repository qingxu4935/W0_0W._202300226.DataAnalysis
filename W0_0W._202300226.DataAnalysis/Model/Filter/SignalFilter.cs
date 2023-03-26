using System.Collections.Generic;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

abstract class SignalFilter
{
	public abstract IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data);
}