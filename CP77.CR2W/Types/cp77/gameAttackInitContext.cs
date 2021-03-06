using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttackInitContext : CVariable
	{
		[Ordinal(0)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(1)]  [RED("record")] public CHandle<gamedataAttack_Record> Record { get; set; }
		[Ordinal(2)]  [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(3)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public gameAttackInitContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
