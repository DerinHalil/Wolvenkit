using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SExperiencePoints : CVariable
	{
		[Ordinal(0)]  [RED("amount")] public CFloat Amount { get; set; }
		[Ordinal(1)]  [RED("entity")] public entEntityID Entity { get; set; }
		[Ordinal(2)]  [RED("forType")] public CEnum<gamedataProficiencyType> ForType { get; set; }

		public SExperiencePoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
