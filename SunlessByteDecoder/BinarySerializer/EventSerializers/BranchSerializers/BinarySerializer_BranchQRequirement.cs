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
		public static BranchQRequirement Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, BranchQRequirement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.DifficultyLevel != null)
			{
				bs.Write(true);
				bs.Write(o.DifficultyLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.DifficultyAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.DifficultyAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.VisibleWhenRequirementFailed);
			if (o.CustomLockedMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CustomLockedMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CustomUnlockedMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CustomUnlockedMessage);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.IsCostRequirement);
			if (o.MinLevel != null)
			{
				bs.Write(true);
				bs.Write(o.MinLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MaxLevel != null)
			{
				bs.Write(true);
				bs.Write(o.MaxLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MinAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.MinAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MaxAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.MaxAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AssociatedQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.AssociatedQuality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
