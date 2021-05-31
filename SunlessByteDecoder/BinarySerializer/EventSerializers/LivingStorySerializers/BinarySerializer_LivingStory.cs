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
		public static LivingStory Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, LivingStory o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.ImageName != null)
			{
				bs.Write(true);
				bs.Write(o.ImageName);
			}
			else
			{
				bs.Write(false);
			}
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Message != null)
			{
				bs.Write(true);
				bs.Write(o.Message);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterMessage != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Tag != null)
			{
				bs.Write(true);
				bs.Write(o.Tag);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SubscriptionMessage != null)
			{
				bs.Write(true);
				bs.Write(o.SubscriptionMessage);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.AfterHours);
			bs.Write(o.Monetizable);
			bs.Write(o.NexCost);
			if (o.LinkedLivingStory != null)
			{
				bs.Write(true);
				BinarySerializer_LivingStory.Serialize(bs, o.LinkedLivingStory);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffected != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffected.Count);
				foreach (LivingStoryQEffect o2 in o.QualitiesAffected)
				{
					BinarySerializer_LivingStoryQEffect.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequired != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequired.Count);
				foreach (LivingStoryQRequirement o3 in o.QualitiesRequired)
				{
					BinarySerializer_LivingStoryQRequirement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
