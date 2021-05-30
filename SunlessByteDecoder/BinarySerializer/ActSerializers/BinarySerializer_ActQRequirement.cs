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
		internal static ActQRequirement Deserialize(BinaryReader bs)
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
	}
}
