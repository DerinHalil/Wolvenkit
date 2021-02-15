using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemAddedNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("itemImage")] public inkImageWidgetReference ItemImage { get; set; }
		[Ordinal(13)] [RED("rarityBar")] public inkWidgetReference RarityBar { get; set; }
		[Ordinal(14)] [RED("itemIconGender")] public CEnum<gameItemIconGender> ItemIconGender { get; set; }
		[Ordinal(15)] [RED("animationName")] public CName AnimationName { get; set; }

		public ItemAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
