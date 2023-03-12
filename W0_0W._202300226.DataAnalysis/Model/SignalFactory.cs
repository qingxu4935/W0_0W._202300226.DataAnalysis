using System;
using System.Collections.Generic;
using System.IO;
using Ardalis.GuardClauses;

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

	public SignalFactory(Config config)
	{
		_config = config;
	}

	/// <summary>
	/// 信号量结果list（只读）
	/// </summary>
	public IReadOnlyList<Signal> Signals => _signals.AsReadOnly();

	/// <summary>
	/// 设备号
	/// </summary>
	public string DeviceName => _config.DeviceName;

	/// <summary>
	/// 峰值
	/// </summary>
	public int MaxValue { get; private set; }

	/// <summary>
	/// 加载，解析历史数据，并计算峰值
	/// </summary>
	/// <param name="path">历史dat文件路径</param>
	public void Load(string path)
	{
		//确保路径有值，否则throw exception
		Guard.Against.NullOrEmpty(path, nameof(path));

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
		//只要没有读到文件的结尾，一直读取并处理
		while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
		{
			//按字节读数据
			var value = binaryReader.ReadByte();
			// 如果当前点是采样率的倍数，我们就要输出到chart
			if (index % rate == 0)
			{
				//当前数据是不是比已知最大值大，是就输出
				MaxValue = Math.Max(value, MaxValue);
				//添加结果list中
				_signals.Add(new Signal(rate, index, value));
			}
			//计数器+1
			index++;
		}
	}
}