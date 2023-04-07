using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ardalis.GuardClauses;
using Splat;
using W0_0W._202300226.DataAnalysis.Model.Filter;

namespace W0_0W._202300226.DataAnalysis.Model;

/// <summary>
/// 信号量工厂
/// </summary>
sealed class SignalFactory
{
	//配置
	readonly Config _config;

	//内部使用的信号量list
	readonly List<Signal> _signals = new();

	public SignalFactory(Config config = null)
	{
		_config = Guard.Against.Null(config, nameof(config));
	}

	/// <summary>
	/// 信号量结果list（只读）
	/// </summary>
	public IReadOnlyList<Signal> Signals => _signals.AsReadOnly();

	public IReadOnlyList<Signal> CalibratedResult { get; private set; } = new List<Signal>();

	/// <summary>
	/// 限幅滤波法 结果
	/// </summary>
	public IReadOnlyList<Signal> LimitingSignalFilterResult { get; private set; } = new List<Signal>();

	/// <summary>
	/// 中位值滤波法 结果
	/// </summary>
	public IReadOnlyList<Signal> MedianSignalFilterResult { get; private set; } = new List<Signal>();

	/// <summary>
	/// 算术平均滤波法 结果
	/// </summary>
	public IReadOnlyList<Signal> AverageSignalFilterResult { get; private set; } = new List<Signal>();

	/// <summary>
	/// 设备号
	/// </summary>
	public string DeviceName => _config.DeviceName;

	/// <summary>
	/// 测试人员
	/// </summary>
	public string TesterName => _config.TesterName;

	/// <summary>
	/// 测试日期
	/// </summary>
	public DateTime TestTime => _config.TestTime;

	/// <summary>
	/// 峰值
	/// </summary>
	public double MaxValue { get; private set; }

	/// <summary>
	/// 谷值
	/// </summary>
	public double MinValue { get; private set; }

	/// <summary>
	/// 加载，解析历史数据，并计算峰值
	/// </summary>
	/// <param name="path">历史dat文件路径</param>
	public void Load(string path)
	{
		//确保路径有值，否则throw exception
		Guard.Against.NullOrEmpty(path, nameof(path));

		Read(path);

		Calibrate();

		Filter();
	}

	void Read(string path)
	{
		//打开文件流
		using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		//字节阅读器
		using var binaryReader = new BinaryReader(fileStream);

		//跳过无效的文件头，如果有效起始点23，意味前22字节是无效的
		for (var i = 0; i < _config.ValidStart - 1; i++)
		{
			//ReadByte->按字节读数据
			binaryReader.ReadByte();
		}

		//计数器
		var index = 0;
		//读取采样率
		var rate = _config.RateValue;
		//采样率
		var sensitivityValue = _config.SensitivityValue;
		//只要没有读到文件的结尾，一直读取并处理
		while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
		{
			//按字节读数据
			var value = binaryReader.ReadUInt16() * sensitivityValue;
			// 如果当前点是采样率的倍数，我们就要输出到chart
			if (index % rate == 0)
			{
				//当前数据是不是比已知最大值大，是就输出
				MaxValue = Math.Max(value, MaxValue);
				//当前数据是不是比已知最小值小，是就输出
				MinValue = Math.Min(value, MinValue);
				//添加结果list中
				_signals.Add(new Signal(rate, index, value));
			}

			//计数器+1
			index++;
		}
	}

	/// <summary>
	/// 定标, y=kx+b
	/// </summary>
	void Calibrate()
	{
		var delta = MaxValue - MinValue;
		if (delta != 0d)
		{
			var actualMax = _config.Max;
			var actualMin = _config.Min;
			var k = (actualMax - actualMin) / delta;
			var b = actualMax - k * MaxValue;

			CalibratedResult = Signals.Select(x => new Signal(x.Rate, x.Index, k * x.Value + b)).ToList();
		}
	}

	void Filter()
	{
		//限幅滤波
		LimitingSignalFilterResult = Locator.Current.GetService<SignalFilter>(nameof(LimitingSignalFilter)).Filter(CalibratedResult);
		//中位值滤波
		MedianSignalFilterResult = Locator.Current.GetService<SignalFilter>(nameof(MedianSignalFilter)).Filter(CalibratedResult);
		//算术平均滤波
		AverageSignalFilterResult = Locator.Current.GetService<SignalFilter>(nameof(AverageSignalFilter)).Filter(CalibratedResult);
	}
}