using System;
using System.Collections.Generic;
using System.IO;
using Ardalis.GuardClauses;

namespace W0_0W._202300226.DataAnalysis.Model
{
	sealed class SignalRiver
	{
		readonly Config _config;
		readonly List<Signal> _signals = new List<Signal>();

		public SignalRiver(Config config)
		{
			_config = config;
		}

		public IReadOnlyList<Signal> Signals => _signals.AsReadOnly();

		public string DeviceName => _config.DeviceName;

		public int MaxValue { get; private set; }

		public void Load(string path)
		{
			Guard.Against.NullOrEmpty(path, nameof(path));

			using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
			using (var binaryReader = new BinaryReader(fileStream))
			{
				for (var i = 0; i < _config.ValidStart - 1; i++)
				{
					binaryReader.ReadByte();
				}

				var index = 0;
				var rate = _config.Rate * 1000;
				while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
				{
					var value = binaryReader.ReadInt16();
					MaxValue = Math.Max(value, MaxValue);
					if (index % rate == 0)
					{
						_signals.Add(new Signal(rate, index, value));
					}
					index++;
				}
			}
		}
	}
}