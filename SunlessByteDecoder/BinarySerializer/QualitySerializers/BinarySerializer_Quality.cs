using SunlessByteDecoder.BinarySerializer.EventSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Quality
    {
		internal static Quality Deserialize(BinaryReader bs)
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

		internal static List<Quality> DeserializeCollection(BinaryReader bs)
		{
			List<Quality> list = new List<Quality>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
