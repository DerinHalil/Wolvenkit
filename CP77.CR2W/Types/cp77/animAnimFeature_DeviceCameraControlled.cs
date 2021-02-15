using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DeviceCameraControlled : animAnimFeature
	{
		[Ordinal(0)] [RED("currentRotation")] public Vector4 CurrentRotation { get; set; }

		public animAnimFeature_DeviceCameraControlled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
