namespace W0_0W._202300226.DataAnalysis.Model;

/// <summary>
/// 信号量，代表图中每个点
/// </summary>
sealed class Signal
{
	public Signal(double rate, int index, double value)
	{
		Index = index;
		Value = value;
		Second = Index / rate;
	}

	/// <summary>
	/// 秒数
	/// </summary>
	public double Second { get; }

	/// <summary>
	/// 序号
	/// </summary>
	public int Index { get; }

	/// <summary>
	/// 信号量
	/// </summary>
	public double Value { get; }
}