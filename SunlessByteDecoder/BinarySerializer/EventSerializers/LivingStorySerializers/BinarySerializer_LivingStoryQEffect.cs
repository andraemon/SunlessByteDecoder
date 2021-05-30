using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses.LivingStoryClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers.LivingStorySerializers
{
    public class BinarySerializer_LivingStoryQEffect
    {
		internal static LivingStoryQEffect Deserialize(BinaryReader bs)
		{
			LivingStoryQEffect livingStoryQEffect = new LivingStoryQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.LivingStory = BinarySerializer_LivingStory.Deserialize(bs);
			}
			livingStoryQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.CompletionMessage = bs.ReadString();
			}
			livingStoryQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				livingStoryQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			livingStoryQEffect.Id = bs.ReadInt32();
			return livingStoryQEffect;
		}
	}
}
