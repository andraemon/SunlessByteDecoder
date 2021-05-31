using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses.LivingStoryClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers.LivingStorySerializers
{
    public class BinarySerializer_LivingStoryQRequirement
    {
		public static LivingStoryQRequirement Deserialize(BinaryReader bs)
		{
			LivingStoryQRequirement livingStoryQRequirement = new LivingStoryQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				livingStoryQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			livingStoryQRequirement.Id = bs.ReadInt32();
			return livingStoryQRequirement;
		}

		public static void Serialize(BinaryWriter bs, LivingStoryQRequirement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
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
