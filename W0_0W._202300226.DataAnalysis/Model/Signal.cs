namespace W0_0W._202300226.DataAnalysis.Model;

sealed class Signal
{
	public Signal(double rate, int index, int value)
	{
		Index = index;
		Value = value;
		Second = Index / rate;
	}

	public double Second { get; }
	public int Index { get; }
	public int Value { get; }
}