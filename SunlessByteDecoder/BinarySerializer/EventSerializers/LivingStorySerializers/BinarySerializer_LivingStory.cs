using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.EventClasses.LivingStoryClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers.LivingStorySerializers
{
    public class BinarySerializer_LivingStory
    {
		internal static LivingStory Deserialize(BinaryReader bs)
		{
			LivingStory livingStory = new LivingStory();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				livingStory.ImageName = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStory.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				livingStory.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStory.Message = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStory.TwitterMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStory.Tag = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				livingStory.SubscriptionMessage = bs.ReadString();
			}
			livingStory.AfterHours = bs.ReadInt32();
			livingStory.Monetizable = bs.ReadBoolean();
			livingStory.NexCost = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				livingStory.LinkedLivingStory = Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				livingStory.QualitiesAffected = new List<LivingStoryQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					livingStory.QualitiesAffected.Add(BinarySerializer_LivingStoryQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				livingStory.QualitiesRequired = new List<LivingStoryQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					livingStory.QualitiesRequired.Add(BinarySerializer_LivingStoryQRequirement.Deserialize(bs));
				}
			}
			livingStory.Id = bs.ReadInt32();
			return livingStory;
		}
	}
}
