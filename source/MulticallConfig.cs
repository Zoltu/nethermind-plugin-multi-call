using System;

namespace Zoltu.Nethermind.Plugin.Multicall
{
	public class MulticallConfig : IMulticallConfig
	{
		public Boolean Enabled { get; set; }
		public String BlockProducer { get; set; } = "0x0000000000000000000000000000000000000000";
	}
}
