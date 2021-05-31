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
		public static ActInviterQRequirement Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, ActInviterQRequirement o)
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
			BinarySerializer_RelationshipDirection.Serialize(bs, o.Direction);
			bs.Write(o.VisibleWhenRequirementFailed);
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
