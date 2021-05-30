using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses.BranchClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers.BranchSerializers
{
    public class BinarySerializer_BranchQRequirement
    {
		internal static BranchQRequirement Deserialize(BinaryReader bs)
		{
			BranchQRequirement branchQRequirement = new BranchQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.DifficultyLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.DifficultyAdvanced = bs.ReadString();
			}
			branchQRequirement.VisibleWhenRequirementFailed = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				branchQRequirement.CustomLockedMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.CustomUnlockedMessage = bs.ReadString();
			}
			branchQRequirement.IsCostRequirement = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				branchQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				branchQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			branchQRequirement.Id = bs.ReadInt32();
			return branchQRequirement;
		}
	}
}
