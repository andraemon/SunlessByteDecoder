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
		internal static Branch Deserialize(BinaryReader bs)
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
	}
}
