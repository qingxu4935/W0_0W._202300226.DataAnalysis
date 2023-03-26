using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

sealed class AverageSignalFilter : SignalFilter
{
	readonly int _number;

	public AverageSignalFilter(int number)
	{
		_number = Guard.Against.AgainstExpression(x => x >= 2, number, "采样数至少2");
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		return data.Chunk(_number)
			.Select(signals => new Signal(signals[0].Rate, (int)Math.Ceiling(signals.Average(x => x.Index)), signals.Average(x => x.Value)))
			.ToList();
	}
}