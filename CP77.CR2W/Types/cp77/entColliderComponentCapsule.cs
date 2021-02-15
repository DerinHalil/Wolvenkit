using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentCapsule : entColliderComponentShape
	{
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(2)] [RED("height")] public CFloat Height { get; set; }

		public entColliderComponentCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
