using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionSwitch : animAnimNode_Switch
	{
		[Ordinal(10)] [RED("audioTagsPerInput")] public CArray<CName> AudioTagsPerInput { get; set; }

		public animAnimNode_LocomotionSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
