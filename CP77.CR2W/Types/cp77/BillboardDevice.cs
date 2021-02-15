using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BillboardDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("advUiComponent")] public CHandle<entIComponent> AdvUiComponent { get; set; }
		[Ordinal(94)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(95)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public BillboardDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
