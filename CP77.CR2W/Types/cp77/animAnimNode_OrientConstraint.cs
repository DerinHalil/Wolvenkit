using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_OrientConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
		[Ordinal(1)]  [RED("inputTransforms")] public CArray<CHandle<animAnimNodeSourceChannel_WeightedQuat>> InputTransforms { get; set; }
		[Ordinal(2)]  [RED("inputWeightedTransforms")] public CArray<animAnimNode_OrientConstraint_WeightedTransform> InputWeightedTransforms { get; set; }
		[Ordinal(3)]  [RED("preprocessedWeights")] public CArray<CFloat> PreprocessedWeights { get; set; }
		[Ordinal(4)]  [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(5)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(6)]  [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }
		[Ordinal(7)]  [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }

		public animAnimNode_OrientConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
