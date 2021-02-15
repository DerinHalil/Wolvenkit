using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDyngParticle_ : CVariable
	{
		[Ordinal(0)] [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(1)] [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(2)] [RED("pullForceFactor")] public CFloat PullForceFactor { get; set; }
		[Ordinal(3)] [RED("isFree")] public CBool IsFree { get; set; }
		[Ordinal(4)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(5)] [RED("collisionCapsuleRadius")] public CFloat CollisionCapsuleRadius { get; set; }
		[Ordinal(6)] [RED("collisionCapsuleHeightExtent")] public CFloat CollisionCapsuleHeightExtent { get; set; }
		[Ordinal(7)] [RED("collisionCapsuleAxisLS")] public Vector3 CollisionCapsuleAxisLS { get; set; }
		[Ordinal(8)] [RED("projectionType")] public CEnum<animDyngParticleProjectionType> ProjectionType { get; set; }

		public animDyngParticle_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
