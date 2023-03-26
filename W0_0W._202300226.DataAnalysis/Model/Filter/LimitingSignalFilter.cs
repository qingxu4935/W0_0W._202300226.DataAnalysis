using System;
using System.Collections.Generic;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

sealed class LimitingSignalFilter : SignalFilter
{
	readonly double _delta;

	public LimitingSignalFilter(double delta)
	{
		_delta = delta;
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		var result = new List<Signal>();
		for (var i = 1; i < data.Count; i++)
		{
			result.Add(Math.Abs(data[i].Value - data[i - 1].Value) > _delta ? data[i - 1] : data[i]);
		}
		return result;
	}
}
