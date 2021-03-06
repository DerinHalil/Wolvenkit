using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questHackingManager_SetEnabled : questHackingManager_ActionType
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }

		public questHackingManager_SetEnabled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
