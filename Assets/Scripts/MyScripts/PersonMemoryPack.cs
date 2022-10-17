using MemoryPack;

namespace MyScripts
{
	[MemoryPackable]
	public partial class PersonMemoryPack
	{
		public int Age { get; set; }
		public string Name { get; set; }
	}
}