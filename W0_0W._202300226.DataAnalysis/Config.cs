using System;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace W0_0W._202300226.DataAnalysis
{
	sealed class Config
	{
		readonly FileIniDataParser _parser;
		readonly Lazy<IniData> _data;
		static readonly string Path = System.IO.Path.Combine(Application.StartupPath, "Configuration.ini");

		public Config()
		{
			_parser = new FileIniDataParser();
			_data = new Lazy<IniData>(() => _parser.ReadFile(Path));
		}

		IniData Data => _data.Value;

		public string DeviceName
		{
			get => Data[nameof(Config)][nameof(DeviceName)];
			set => Data[nameof(Config)][nameof(DeviceName)] = value;
		}

		public double Rate
		{
			get => double.Parse(Data[nameof(Config)][nameof(Rate)]);
			set => Data[nameof(Config)][nameof(Rate)] = value.ToString();
		}

		public int ValidStart
		{
			get => int.Parse(Data[nameof(Config)][nameof(ValidStart)]);
			set => Data[nameof(Config)][nameof(ValidStart)] = value.ToString();
		}

		public int Sensitivity
		{
			get => int.Parse(Data[nameof(Config)][nameof(Sensitivity)]);
			set => Data[nameof(Config)][nameof(Sensitivity)] = value.ToString();
		}

		public void Save()
		{
			_parser.WriteFile(Path, Data);
		}
	}
}
