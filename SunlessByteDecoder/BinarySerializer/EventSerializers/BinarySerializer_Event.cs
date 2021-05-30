using SunlessByteDecoder.BinarySerializer.EventSerializers.BranchSerializers;
using SunlessByteDecoder.BinarySerializer.EventSerializers.LivingStorySerializers;
using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.MetaSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses;
using SunlessByteDecoder.GameClasses.EventClasses.BranchClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Event
    {
		internal static Event Deserialize(BinaryReader bs)
		{
			Event @event = new Event();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				@event.ChildBranches = new List<Branch>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					@event.ChildBranches.Add(BinarySerializer_Branch.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				@event.ParentBranch = BinarySerializer_Branch.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.QualitiesAffected = new List<EventQEffect>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					@event.QualitiesAffected.Add(BinarySerializer_EventQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				@event.QualitiesRequired = new List<EventQRequirement>();
				int num3 = bs.ReadInt32();
				for (int k = 0; k < num3; k++)
				{
					@event.QualitiesRequired.Add(BinarySerializer_EventQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				@event.Image = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.SecondImage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.Tag = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.ExoticEffects = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.Note = bs.ReadString();
			}
			@event.ChallengeLevel = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				@event.UnclearedEditAt = new DateTime?(BinarySerializer_DateTime.Deserialize(bs));
			}
			if (bs.ReadBoolean())
			{
				@event.LastEditedBy = BinarySerializer_User.Deserialize(bs);
			}
			@event.Ordering = bs.ReadSingle();
			@event.ShowAsMessage = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				@event.LivingStory = BinarySerializer_LivingStory.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.LinkToEvent = Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.Deck = BinarySerializer_Deck.Deserialize(bs);
			}
			@event.Category = BinarySerializer_EventCategory.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				@event.LimitedToArea = BinarySerializer_Area.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.World = BinarySerializer_World.Deserialize(bs);
			}
			@event.Transient = bs.ReadBoolean();
			@event.Stickiness = bs.ReadInt32();
			@event.MoveToAreaId = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				@event.MoveToArea = BinarySerializer_Area.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.MoveToDomicile = BinarySerializer_Domicile.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.SwitchToSetting = BinarySerializer_Setting.Deserialize(bs);
			}
			@event.FatePointsChange = bs.ReadInt32();
			@event.BootyValue = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				@event.LogInJournalAgainstQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				@event.Setting = BinarySerializer_Setting.Deserialize(bs);
			}
			@event.Urgency = BinarySerializer_Urgency.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				@event.Teaser = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				@event.OwnerName = bs.ReadString();
			}
			@event.DateTimeCreated = BinarySerializer_DateTime.Deserialize(bs);
			@event.Distribution = bs.ReadInt32();
			@event.Autofire = bs.ReadBoolean();
			@event.CanGoBack = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				@event.Name = bs.ReadString();
			}
			@event.Id = bs.ReadInt32();
			return @event;
		}

		internal static List<Event> DeserializeCollection(BinaryReader bs)
		{
			List<Event> list = new List<Event>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
