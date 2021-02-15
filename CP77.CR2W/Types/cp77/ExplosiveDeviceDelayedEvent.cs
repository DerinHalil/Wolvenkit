using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceDelayedEvent : redEvent
	{
		[Ordinal(0)] [RED("arrayIndex")] public CInt32 ArrayIndex { get; set; }
		[Ordinal(1)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }

		public ExplosiveDeviceDelayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
