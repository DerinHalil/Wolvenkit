using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounce_JsonProperties : ISerializable
	{
		[Ordinal(0)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)]  [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
		[Ordinal(2)]  [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(3)]  [RED("negativeMultiplier")] public CFloat NegativeMultiplier { get; set; }
		[Ordinal(4)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(5)]  [RED("outputDriverTrack")] public animNamedTrackIndex OutputDriverTrack { get; set; }
		[Ordinal(6)]  [RED("smoothStep")] public CFloat SmoothStep { get; set; }
		[Ordinal(7)]  [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
		[Ordinal(8)]  [RED("trackOutputs")] public CArray<animSimpleBounceTrackOutput> TrackOutputs { get; set; }
		[Ordinal(9)]  [RED("transformOutputs")] public CArray<animSimpleBounceTransformOutput> TransformOutputs { get; set; }

		public animSimpleBounce_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
