using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleStyleManagerGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(1)]  [RED("stylePath1")] public redResourceReferenceScriptToken StylePath1 { get; set; }
		[Ordinal(2)]  [RED("stylePath2")] public redResourceReferenceScriptToken StylePath2 { get; set; }

		public sampleStyleManagerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
