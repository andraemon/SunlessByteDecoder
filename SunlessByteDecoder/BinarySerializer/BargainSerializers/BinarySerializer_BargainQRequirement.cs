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
		public static BargainQRequirement Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, BargainQRequirement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
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
