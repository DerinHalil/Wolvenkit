using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAddRemoveItem_NodeTypeParams : ISerializable
	{
		[Ordinal(0)]  [RED("entityRef")] public CHandle<questUniversalRef> EntityRef { get; set; }
		[Ordinal(1)]  [RED("flagItemAddedCallbackAsSilent")] public CBool FlagItemAddedCallbackAsSilent { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(4)]  [RED("itemIDsToIgnoreOnRemove")] public CArray<TweakDBID> ItemIDsToIgnoreOnRemove { get; set; }
		[Ordinal(5)]  [RED("nodeType")] public CEnum<questEAddRemoveItemType> NodeType { get; set; }
		[Ordinal(6)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(7)]  [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(8)]  [RED("removeAllQuantity")] public CBool RemoveAllQuantity { get; set; }
		[Ordinal(9)]  [RED("sendNotification")] public CBool SendNotification { get; set; }
		[Ordinal(10)]  [RED("tagToRemove")] public CName TagToRemove { get; set; }
		[Ordinal(11)]  [RED("tagsToIgnoreOnRemove")] public CArray<CName> TagsToIgnoreOnRemove { get; set; }

		public questAddRemoveItem_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
