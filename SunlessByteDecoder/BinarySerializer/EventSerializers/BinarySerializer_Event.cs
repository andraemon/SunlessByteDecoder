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
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Event
    {
		public static Event Deserialize(BinaryReader bs)
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

		public static List<Event> DeserializeCollection(BinaryReader bs)
		{
			List<Event> list = new List<Event>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Event o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.ChildBranches != null)
			{
				bs.Write(true);
				bs.Write(o.ChildBranches.Count);
				foreach (Branch o2 in o.ChildBranches)
				{
					BinarySerializer_Branch.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.ParentBranch != null)
			{
				bs.Write(true);
				BinarySerializer_Branch.Serialize(bs, o.ParentBranch);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffected != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffected.Count);
				foreach (EventQEffect o3 in o.QualitiesAffected)
				{
					BinarySerializer_EventQEffect.Serialize(bs, o3);
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
				foreach (EventQRequirement o4 in o.QualitiesRequired)
				{
					BinarySerializer_EventQRequirement.Serialize(bs, o4);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Image != null)
			{
				bs.Write(true);
				bs.Write(o.Image);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SecondImage != null)
			{
				bs.Write(true);
				bs.Write(o.SecondImage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
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
			if (o.ExoticEffects != null)
			{
				bs.Write(true);
				bs.Write(o.ExoticEffects);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Note != null)
			{
				bs.Write(true);
				bs.Write(o.Note);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.ChallengeLevel);
			if (o.UnclearedEditAt != null)
			{
				bs.Write(true);
				BinarySerializer_DateTime.Serialize(bs, o.UnclearedEditAt.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LastEditedBy != null)
			{
				bs.Write(true);
				BinarySerializer_User.Serialize(bs, o.LastEditedBy);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Ordering);
			bs.Write(o.ShowAsMessage);
			if (o.LivingStory != null)
			{
				bs.Write(true);
				BinarySerializer_LivingStory.Serialize(bs, o.LivingStory);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LinkToEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.LinkToEvent);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Deck != null)
			{
				bs.Write(true);
				BinarySerializer_Deck.Serialize(bs, o.Deck);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_EventCategory.Serialize(bs, o.Category);
			if (o.LimitedToArea != null)
			{
				bs.Write(true);
				BinarySerializer_Area.Serialize(bs, o.LimitedToArea);
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
			bs.Write(o.Transient);
			bs.Write(o.Stickiness);
			bs.Write(o.MoveToAreaId);
			if (o.MoveToArea != null)
			{
				bs.Write(true);
				BinarySerializer_Area.Serialize(bs, o.MoveToArea);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MoveToDomicile != null)
			{
				bs.Write(true);
				BinarySerializer_Domicile.Serialize(bs, o.MoveToDomicile);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SwitchToSetting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.SwitchToSetting);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.FatePointsChange);
			bs.Write(o.BootyValue);
			if (o.LogInJournalAgainstQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.LogInJournalAgainstQuality);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Setting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.Setting);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_Urgency.Serialize(bs, o.Urgency);
			if (o.Teaser != null)
			{
				bs.Write(true);
				bs.Write(o.Teaser);
			}
			else
			{
				bs.Write(false);
			}
			if (o.OwnerName != null)
			{
				bs.Write(true);
				bs.Write(o.OwnerName);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_DateTime.Serialize(bs, o.DateTimeCreated);
			bs.Write(o.Distribution);
			bs.Write(o.Autofire);
			bs.Write(o.CanGoBack);
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Event> c)
		{
			bs.Write(c.Count());
			foreach (Event o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
