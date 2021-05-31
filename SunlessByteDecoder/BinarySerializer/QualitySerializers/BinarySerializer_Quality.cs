using SunlessByteDecoder.BinarySerializer.EventSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Quality
    {
		public static Quality Deserialize(BinaryReader bs)
		{
			Quality quality = new Quality();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				quality.QualitiesPossessedList = new List<AspectQPossession>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					quality.QualitiesPossessedList.Add(BinarySerializer_AspectQPossession.Deserialize(bs));
				}
			}
			quality.RelationshipCapable = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				quality.PluralName = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.OwnerName = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Image = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Notes = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Tag = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Cap = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				quality.CapAdvanced = bs.ReadString();
			}
			quality.HimbleLevel = bs.ReadInt32();
			quality.UsePyramidNumbers = bs.ReadBoolean();
			quality.PyramidNumberIncreaseLimit = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				quality.AvailableAt = bs.ReadString();
			}
			quality.PreventNaming = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				quality.CssClasses = bs.ReadString();
			}
			quality.QEffectPriority = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				quality.QEffectMinimalLimit = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				quality.World = BinarySerializer_World.Deserialize(bs);
			}
			quality.Ordering = bs.ReadInt32();
			quality.IsSlot = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				quality.LimitedToArea = BinarySerializer_Area.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				quality.AssignToSlot = Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				quality.ParentQuality = Deserialize(bs);
			}
			quality.Persistent = bs.ReadBoolean();
			quality.Visible = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				quality.Enhancements = new List<QEnhancement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					quality.Enhancements.Add(BinarySerializer_QEnhancement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				quality.EnhancementsDescription = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.SecondChanceQuality = Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				quality.UseEvent = BinarySerializer_Event.Deserialize(bs);
			}
			quality.DifficultyTestType = BinarySerializer_DifficultyTestType.Deserialize(bs);
			quality.DifficultyScaler = bs.ReadInt32();
			quality.AllowedOn = BinarySerializer_QualityAllowedOn.Deserialize(bs);
			quality.Nature = BinarySerializer_Nature.Deserialize(bs);
			quality.Category = BinarySerializer_Category.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				quality.LevelDescriptionText = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.ChangeDescriptionText = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.DescendingChangeDescriptionText = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.LevelImageText = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.VariableDescriptionText = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				quality.Name = bs.ReadString();
			}
			quality.Id = bs.ReadInt32();
			return quality;
		}

		public static List<Quality> DeserializeCollection(BinaryReader bs)
		{
			List<Quality> list = new List<Quality>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Quality o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.QualitiesPossessedList != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesPossessedList.Count);
				foreach (AspectQPossession o2 in o.QualitiesPossessedList)
				{
					BinarySerializer_AspectQPossession.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.RelationshipCapable);
			if (o.PluralName != null)
			{
				bs.Write(true);
				bs.Write(o.PluralName);
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
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
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
			if (o.Notes != null)
			{
				bs.Write(true);
				bs.Write(o.Notes);
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
			if (o.Cap != null)
			{
				bs.Write(true);
				bs.Write(o.Cap.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CapAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.CapAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.HimbleLevel);
			bs.Write(o.UsePyramidNumbers);
			bs.Write(o.PyramidNumberIncreaseLimit);
			if (o.AvailableAt != null)
			{
				bs.Write(true);
				bs.Write(o.AvailableAt);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.PreventNaming);
			if (o.CssClasses != null)
			{
				bs.Write(true);
				bs.Write(o.CssClasses);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.QEffectPriority);
			if (o.QEffectMinimalLimit != null)
			{
				bs.Write(true);
				bs.Write(o.QEffectMinimalLimit.Value);
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
			bs.Write(o.Ordering);
			bs.Write(o.IsSlot);
			if (o.LimitedToArea != null)
			{
				bs.Write(true);
				BinarySerializer_Area.Serialize(bs, o.LimitedToArea);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AssignToSlot != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.AssignToSlot);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ParentQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.ParentQuality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Persistent);
			bs.Write(o.Visible);
			if (o.Enhancements != null)
			{
				bs.Write(true);
				bs.Write(o.Enhancements.Count);
				foreach (QEnhancement o3 in o.Enhancements)
				{
					BinarySerializer_QEnhancement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.EnhancementsDescription != null)
			{
				bs.Write(true);
				bs.Write(o.EnhancementsDescription);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SecondChanceQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.SecondChanceQuality);
			}
			else
			{
				bs.Write(false);
			}
			if (o.UseEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.UseEvent);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_DifficultyTestType.Serialize(bs, o.DifficultyTestType);
			bs.Write(o.DifficultyScaler);
			BinarySerializer_QualityAllowedOn.Serialize(bs, o.AllowedOn);
			BinarySerializer_Nature.Serialize(bs, o.Nature);
			BinarySerializer_Category.Serialize(bs, o.Category);
			if (o.LevelDescriptionText != null)
			{
				bs.Write(true);
				bs.Write(o.LevelDescriptionText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ChangeDescriptionText != null)
			{
				bs.Write(true);
				bs.Write(o.ChangeDescriptionText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.DescendingChangeDescriptionText != null)
			{
				bs.Write(true);
				bs.Write(o.DescendingChangeDescriptionText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LevelImageText != null)
			{
				bs.Write(true);
				bs.Write(o.LevelImageText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.VariableDescriptionText != null)
			{
				bs.Write(true);
				bs.Write(o.VariableDescriptionText);
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
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Quality> c)
		{
			bs.Write(c.Count<Quality>());
			foreach (Quality o in c)
			{
				BinarySerializer_Quality.Serialize(bs, o);
			}
		}
	}
}
