using System;
using System.Collections.Generic;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

/// <summary>
/// 限幅滤波法：
/// 根据经验判断，确定两次采样允许的最大偏差值（设为 A）
/// 如果本次值与上次值之差 小于等于 A, 则本次值有效
/// 如果本次值与上次值之差 大于 A, 则本次值无效, 放弃本次值, 用上次值代替本次值
/// </summary>
sealed class LimitingSignalFilter : SignalFilter
{
	/// <summary>
	/// 最大偏差值
	/// </summary>
	readonly double _delta;

	public LimitingSignalFilter(Config config)
	{
		_delta = config.LimitingSignalFilterDelta;
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		var result = new List<Signal>();
		for (var i = 1; i < data.Count; i++)
		{
			result.Add(Math.Abs(data[i].Value - data[i - 1].Value) > _delta // 本次值与上次值之差 > A
				? data[i - 1] //用上次值
				: data[i] //用本次值
			);
		}
		return result;
	}
}
