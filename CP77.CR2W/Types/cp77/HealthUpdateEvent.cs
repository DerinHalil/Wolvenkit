using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HealthUpdateEvent : redEvent
	{
		[Ordinal(0)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(1)] [RED("healthDifference")] public CFloat HealthDifference { get; set; }

		public HealthUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
