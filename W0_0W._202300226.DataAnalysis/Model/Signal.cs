namespace W0_0W._202300226.DataAnalysis
{
	class Signal
	{
		public Signal(double rate, int index, short value)
		{
			Index = index;
			Value = value;
			Second = Index / rate;
		}

		public double Second { get; }
		public int Index { get; }
		public short Value { get; }
	}
}