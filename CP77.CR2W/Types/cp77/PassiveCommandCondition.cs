using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassiveCommandCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)]  [RED("cmdCbId")] public CUInt32 CmdCbId { get; set; }
		[Ordinal(1)]  [RED("commandName")] public CName CommandName { get; set; }
		[Ordinal(2)]  [RED("useInheritance")] public CBool UseInheritance { get; set; }

		public PassiveCommandCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
