using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnProgressBarAnimFinish : redEvent
	{
		[Ordinal(0)] [RED("FullbarSize")] public CFloat FullbarSize { get; set; }
		[Ordinal(1)] [RED("IsNegative")] public CBool IsNegative { get; set; }

		public OnProgressBarAnimFinish(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
