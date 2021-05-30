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
		internal static LivingStoryQRequirement Deserialize(BinaryReader bs)
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
	}
}
