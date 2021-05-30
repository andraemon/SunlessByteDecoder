using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.BargainClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.BargainSerializers
{
    public class BinarySerializer_BargainQRequirement
    {
		internal static BargainQRequirement Deserialize(BinaryReader bs)
		{
			BargainQRequirement bargainQRequirement = new BargainQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.CustomLockedMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.CustomUnlockedMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargainQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			bargainQRequirement.Id = bs.ReadInt32();
			return bargainQRequirement;
		}
	}
}
