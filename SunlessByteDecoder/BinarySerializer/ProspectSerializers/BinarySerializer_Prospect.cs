using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses;
using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers
{
    public class BinarySerializer_Prospect
    {
		internal static Prospect Deserialize(BinaryReader bs)
		{
			Prospect prospect = new Prospect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				prospect.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospect.Tags = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.Setting = BinarySerializer_Setting.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospect.Request = BinarySerializer_Quality.Deserialize(bs);
			}
			prospect.Demand = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				prospect.Payment = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.QualitiesAffected = new List<ProspectQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					prospect.QualitiesAffected.Add(BinarySerializer_ProspectQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.QualitiesRequired = new List<ProspectQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					prospect.QualitiesRequired.Add(BinarySerializer_ProspectQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.Completions = new List<Completion>();
				int num3 = bs.ReadInt32();
				for (int k = 0; k < num3; k++)
				{
					prospect.Completions.Add(BinarySerializer_Completion.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.Name = bs.ReadString();
			}
			prospect.Id = bs.ReadInt32();
			return prospect;
		}

		internal static List<Prospect> DeserializeCollection(BinaryReader bs)
		{
			List<Prospect> list = new List<Prospect>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
