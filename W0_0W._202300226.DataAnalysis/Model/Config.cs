using System;
using System.Globalization;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace W0_0W._202300226.DataAnalysis.Model;

/// <summary>
/// 文件Configuration.ini的配置类
/// </summary>
sealed class Config
{
	readonly FileIniDataParser _parser;
	readonly Lazy<IniData> _data;
	static readonly string Path = System.IO.Path.Combine(Application.StartupPath, "Configuration.ini");

	public Config()
	{
		_parser = new FileIniDataParser();

		// 读文件是件费性能的动作，使用Lazy<>, 只在需要的时候才读文件，因此new Config()是高效的
		_data = new Lazy<IniData>(() => _parser.ReadFile(Path));
	}

	/// <summary>
	/// 一旦调用Lazy<>.Value, 我们就执行读文件这个动作
	/// </summary>
	IniData Data => _data.Value;

	/// <summary>
	/// 设备号
	/// </summary>
	public string DeviceName
	{
		get => Data[nameof(Config)][nameof(DeviceName)];
		set => Data[nameof(Config)][nameof(DeviceName)] = value;
	}

	/// <summary>
	/// 采样率实际计算值
	/// </summary>
	public double RateValue => (int)Rate * 1000;

	/// <summary>
	/// 采样率，K/S
	/// </summary>
	public double Rate
	{
		get => double.Parse(Data[nameof(Config)][nameof(Rate)]);
		set => Data[nameof(Config)][nameof(Rate)] = value.ToString(CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// 有效起始点
	/// </summary>
	public int ValidStart
	{
		get => int.Parse(Data[nameof(Config)][nameof(ValidStart)]);
		set => Data[nameof(Config)][nameof(ValidStart)] = value.ToString();
	}

	/// <summary>
	/// 灵敏度实际计算值
	/// </summary>
	public double SensitivityValue => Sensitivity / 100d;

	/// <summary>
	/// 灵敏度, %
	/// </summary>
	public int Sensitivity
	{
		get => int.Parse(Data[nameof(Config)][nameof(Sensitivity)]);
		set => Data[nameof(Config)][nameof(Sensitivity)] = value.ToString();
	}

	/// <summary>
	/// 限幅滤波法-最大偏差值
	/// </summary>
	public double LimitingSignalFilterDelta
	{
		get => double.Parse(Data[nameof(Config)][nameof(LimitingSignalFilterDelta)]);
		set => Data[nameof(Config)][nameof(LimitingSignalFilterDelta)] = value.ToString(CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// 算术平均滤波法-连续采样数
	/// </summary>
	public int AverageSignalFilterNumber
	{
		get => int.Parse(Data[nameof(Config)][nameof(AverageSignalFilterNumber)]);
		set => Data[nameof(Config)][nameof(AverageSignalFilterNumber)] = value.ToString();
	}

	/// <summary>
	/// 中位值滤波法-连续采样数
	/// </summary>
	public int MedianSignalFilterNumber
	{
		get => int.Parse(Data[nameof(Config)][nameof(MedianSignalFilterNumber)]);
		set => Data[nameof(Config)][nameof(MedianSignalFilterNumber)] = value.ToString();
	}

	/// <summary>
	/// 保存配置改动
	/// </summary>
	public void Save()
	{
		_parser.WriteFile(Path, Data);
	}
}