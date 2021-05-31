using SunlessByteDecoder.BinarySerializer.ActSerializers;
using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses.BranchClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers.BranchSerializers
{
    public class BinarySerializer_Branch
    {
		public static Branch Deserialize(BinaryReader bs)
		{
			Branch branch = new Branch();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				branch.SuccessEvent = BinarySerializer_Event.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				branch.DefaultEvent = BinarySerializer_Event.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				branch.RareDefaultEvent = BinarySerializer_Event.Deserialize(bs);
			}
			branch.RareDefaultEventChance = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				branch.RareSuccessEvent = BinarySerializer_Event.Deserialize(bs);
			}
			branch.RareSuccessEventChance = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				branch.ParentEvent = BinarySerializer_Event.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				branch.QualitiesRequired = new List<BranchQRequirement>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					branch.QualitiesRequired.Add(BinarySerializer_BranchQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				branch.Image = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				branch.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				branch.OwnerName = bs.ReadString();
			}
			branch.DateTimeCreated = BinarySerializer_DateTime.Deserialize(bs);
			branch.CurrencyCost = bs.ReadInt32();
			branch.Archived = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				branch.RenameQualityCategory = new Category?(BinarySerializer_Category.Deserialize(bs));
			}
			if (bs.ReadBoolean())
			{
				branch.ButtonText = bs.ReadString();
			}
			branch.Ordering = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				branch.Act = BinarySerializer_Act.Deserialize(bs);
			}
			branch.ActionCost = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				branch.Name = bs.ReadString();
			}
			branch.Id = bs.ReadInt32();
			return branch;
		}

		public static void Serialize(BinaryWriter bs, Branch o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.SuccessEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.SuccessEvent);
			}
			else
			{
				bs.Write(false);
			}
			if (o.DefaultEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.DefaultEvent);
			}
			else
			{
				bs.Write(false);
			}
			if (o.RareDefaultEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.RareDefaultEvent);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.RareDefaultEventChance);
			if (o.RareSuccessEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.RareSuccessEvent);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.RareSuccessEventChance);
			if (o.ParentEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.ParentEvent);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequired != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequired.Count);
				foreach (BranchQRequirement o2 in o.QualitiesRequired)
				{
					BinarySerializer_BranchQRequirement.Serialize(bs, o2);
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
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
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
			bs.Write(o.CurrencyCost);
			bs.Write(o.Archived);
			if (o.RenameQualityCategory != null)
			{
				bs.Write(true);
				BinarySerializer_Category.Serialize(bs, o.RenameQualityCategory.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ButtonText != null)
			{
				bs.Write(true);
				bs.Write(o.ButtonText);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Ordering);
			if (o.Act != null)
			{
				bs.Write(true);
				BinarySerializer_Act.Serialize(bs, o.Act);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.ActionCost);
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
	}
}
