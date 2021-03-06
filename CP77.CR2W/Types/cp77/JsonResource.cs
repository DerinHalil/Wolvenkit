using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JsonResource : CResource
	{
		[Ordinal(0)]  [RED("root")] public CHandle<ISerializable> Root { get; set; }

		public JsonResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
