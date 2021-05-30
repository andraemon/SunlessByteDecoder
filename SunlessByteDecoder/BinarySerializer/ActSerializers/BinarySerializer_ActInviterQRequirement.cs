using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActInviterQRequirement
    {
		internal static ActInviterQRequirement Deserialize(BinaryReader bs)
		{
			ActInviterQRequirement actInviterQRequirement = new ActInviterQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.DifficultyLevel = new int?(bs.ReadInt32());
			}
			actInviterQRequirement.Direction = BinarySerializer_RelationshipDirection.Deserialize(bs);
			actInviterQRequirement.VisibleWhenRequirementFailed = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actInviterQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			actInviterQRequirement.Id = bs.ReadInt32();
			return actInviterQRequirement;
		}
	}
}
