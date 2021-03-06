using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InputProgressView : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("PartName")] public CString PartName { get; set; }
		[Ordinal(1)]  [RED("ProgressPercent")] public CInt32 ProgressPercent { get; set; }
		[Ordinal(2)]  [RED("TargetImage")] public wCHandle<inkImageWidget> TargetImage { get; set; }

		public InputProgressView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
