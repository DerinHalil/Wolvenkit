using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventPostponedParameterVector : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] [RED("value")] public Vector4 Value { get; set; }

		public gamestateMachineeventPostponedParameterVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
