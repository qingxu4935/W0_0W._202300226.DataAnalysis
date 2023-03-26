using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

sealed class MedianSignalFilter : SignalFilter
{
	readonly int _number;

	public MedianSignalFilter(int number)
	{
		_number = Guard.Against.AgainstExpression(x => x % 2 == 1 && x > 1, number, "采样数为>1的奇数");
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		var mid = (_number + 1) / 2;
		return data.Chunk(_number)
			.Where(signals => signals.Length >= mid)
			.Select(signals => signals.OrderBy(x => x.Value).ElementAt(mid - 1))
			.ToList();
	}
}