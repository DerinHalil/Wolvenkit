using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopGlobalNodeIDInfo : CVariable
	{
		[Ordinal(0)] [RED("globalName")] public CString GlobalName { get; set; }
		[Ordinal(1)] [RED("globalNodeIDPath")] public CString GlobalNodeIDPath { get; set; }
		[Ordinal(2)] [RED("globalNodeIDHash")] public CUInt64 GlobalNodeIDHash { get; set; }
		[Ordinal(3)] [RED("globalNameIsAutoGenerated")] public CBool GlobalNameIsAutoGenerated { get; set; }

		public interopGlobalNodeIDInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
