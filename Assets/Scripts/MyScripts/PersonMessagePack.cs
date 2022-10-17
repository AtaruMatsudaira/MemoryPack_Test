using MessagePack;

namespace MyScripts
{
	[MessagePackObject]
	public class PersonMessagePack
	{
		[Key(0)]
		public int Age { get; set; }
		[Key(1)]
		public string Name { get; set; }
	}
}