using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

/// <summary>
/// 中位值滤波法：连续采样 N 次（N 取奇数, 把 N 次采样值按大小排列, 取中间值为本次有效值
/// </summary>
sealed class MedianSignalFilter : SignalFilter
{
	/// <summary>
	/// 采样数
	/// </summary>
	readonly int _number;

	public MedianSignalFilter(Config config)
	{
		//要求采样数最小为3
		_number = Guard.Against.AgainstExpression(x => x % 2 == 1 && x > 1, config.MedianSignalFilterNumber, "采样数为>1的奇数");
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		//N的中间数
		var mid = (_number + 1) / 2;

		return data
			.Chunk(_number)//按N分块
			.Where(signals => signals.Length >= mid)//每块至少有mid个值
			.Select(signals => signals.OrderBy(x => x.Value).ElementAt(mid - 1)) //每块排序，取中间值
			.ToList();
	}
}