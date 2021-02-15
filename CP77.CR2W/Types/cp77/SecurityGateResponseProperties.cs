using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityGateResponseProperties : CVariable
	{
		[Ordinal(0)] [RED("securityGateResponseType")] public CEnum<ESecurityGateResponseType> SecurityGateResponseType { get; set; }
		[Ordinal(1)] [RED("securityLevelAccessGranted")] public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted { get; set; }

		public SecurityGateResponseProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
