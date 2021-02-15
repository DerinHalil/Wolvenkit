using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRateOverLife : IParticleModificator
	{
		[Ordinal(4)] [RED("rotationRate")] public CHandle<IEvaluatorFloat> RotationRate { get; set; }
		[Ordinal(5)] [RED("modulate")] public CBool Modulate { get; set; }

		public CParticleModificatorRotationRateOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
