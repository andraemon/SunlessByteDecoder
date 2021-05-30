using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.BargainClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.BargainSerializers
{
    public class BinarySerializer_Bargain
    {
		internal static Bargain Deserialize(BinaryReader bs)
		{
			Bargain bargain = new Bargain();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				bargain.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				bargain.Tags = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Offer = BinarySerializer_Quality.Deserialize(bs);
			}
			bargain.Stock = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				bargain.Price = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.QualitiesRequired = new List<BargainQRequirement>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					bargain.QualitiesRequired.Add(BinarySerializer_BargainQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				bargain.Teaser = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Name = bs.ReadString();
			}
			bargain.Id = bs.ReadInt32();
			return bargain;
		}

		internal static List<Bargain> DeserializeCollection(BinaryReader bs)
		{
			List<Bargain> list = new List<Bargain>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
