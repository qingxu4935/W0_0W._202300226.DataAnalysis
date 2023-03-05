using System.Collections.Generic;
using System.IO;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis
{
	class SignalRiver
	{
		readonly Config _config;
		readonly List<Signal> _signals = new List<Signal>();

		public SignalRiver(Config config)
		{
			_config = config;
		}

		public IReadOnlyList<Signal> Signals => _signals.AsReadOnly();

		public void Load(string path)
		{
			Guard.Against.NullOrEmpty(path, nameof(path));

			using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
			using (var binaryReader = new BinaryReader(fileStream))
			{
				for (var i = 1; i <= _config.ValidStart - 1; i++)
				{
					binaryReader.ReadByte();
				}

				var index = 0;
				var rate = _config.Rate;
				while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
				{
					_signals.Add(new Signal(rate, index++, binaryReader.ReadInt16()));
				}
			}
		}
	}
}