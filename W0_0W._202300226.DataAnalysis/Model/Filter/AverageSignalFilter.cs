using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis.Model.Filter;

/// <summary>
/// 算术平均滤波法，连续取 N 个采样值进行算术平均运算
/// </summary>
sealed class AverageSignalFilter : SignalFilter
{
	//采样数
	readonly int _number;

	public AverageSignalFilter(Config config)
	{
		//要求连续采样数至少为2
		_number = Guard.Against.AgainstExpression(x => x >= 2, config.AverageSignalFilterNumber, "采样数至少2");
	}

	public override IReadOnlyList<Signal> Filter(IReadOnlyList<Signal> data)
	{
		return data.Chunk(_number)//按N分块
			.Select(signals => new Signal(signals[0].Rate, //采样率不变
				(int)Math.Ceiling(signals.Average(x => x.Index)), //索引为每块索引均值
				signals.Average(x => x.Value)//采样值为每块的采样均值
				))
			.ToList();
	}
}