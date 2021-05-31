using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActQRequirement
    {
		public static ActQRequirement Deserialize(BinaryReader bs)
		{
			ActQRequirement actQRequirement = new ActQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				actQRequirement.DifficultyLevel = new int?(bs.ReadInt32());
			}
			actQRequirement.Direction = BinarySerializer_RelationshipDirection.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				actQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			actQRequirement.Id = bs.ReadInt32();
			return actQRequirement;
		}

		public static void Serialize(BinaryWriter bs, ActQRequirement o)
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
